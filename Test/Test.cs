﻿using System;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Electronic_training_manual
{
    public partial class TestirForm : Form
    {
        XmlReader xmlReader;
        string PersonName; //Имя пользователя
        string Theme; //Тема теста
        int nv;  // общее количество вопросов
        int RightAnsw; //Количество правильных ответов
        int position = 0;   // оставшееся количество вопросов
        int nepqw = 0; // кол-во неправильных вопросов

        List<string> errors = new List<string>(); //Неправильные вопросы
        string qw; //Вопрос
        string[] answ = new string[4]; //Варианты ответов
        string right; //Верный ответ
        bool righting; //Правота пользователя

        public TestirForm(string TestPath, string personName, string theme)

        {
            InitializeComponent();

            PersonName = personName; //Имя пользователя
            Theme = theme; //Тема теста


            xmlReader = new XmlTextReader(TestPath); //Создаем xmlReader
            xmlReader.Read();

            ReadNombers(); //Читаем количество вопросов
            LoadQwest();    // загружаем их
            ShowQwest();    // выводим
            righting = false; //Сбрасываем "правоту"

        }

        #region Чтение количества вопросов
        public void ReadNombers()
        {
            //Ищем узел <qw>
            do xmlReader.Read();
            while (xmlReader.Name != "qw");

            nv = Convert.ToInt32(xmlReader.GetAttribute("numbers")); //Читаем атрибут узла <qw> 

            xmlReader.Read(); //Входим в узел <qw>
        }
        #endregion

        #region Загрузка вопроса
        public void LoadQwest()
        {
            position++;

            if (position > nv)
                Itog();
            else
            {
                //Ищем узел вопроса
                do xmlReader.Read();
                while (xmlReader.Name != "q" + position);

                if (xmlReader.Name == "q" + position)
                {
                    qw = xmlReader.GetAttribute("text"); //Считываем вопрос
                    right = xmlReader.GetAttribute("right"); //Считываем правильный ответ

                    xmlReader.Read(); //Входим в узел <q>

                    //Ищем узел <answers>
                    do xmlReader.Read();
                    while (xmlReader.Name != "answers");

                    xmlReader.Read(); //Входим в узел <answers>

                    answ = xmlReader.Value.Split('|'); //Cохраняем варианты ответов в массив
                }
            }
            radioButton0.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
        #endregion

        #region Вывод вопроса
        public void ShowQwest()
        {
            QwLabel.Text = qw; //Выводим вопрос

            //Выводим варианты ответов
            radioButton0.Text = answ[0];
            radioButton1.Text = answ[1];
            radioButton2.Text = answ[2];
            radioButton3.Text = answ[3];

            pictureBox2.Enabled = false; //закрываем кнопку
        }
        #endregion

        #region Проверка
        public void Checked()
        {
            if (righting == true)
                RightAnsw++;
            else
            {
                nepqw = nepqw + 1;
                errors.Add(qw);
            }
        }
        #endregion

        #region передача итогов тестирования Itog
        public void Itog()
        {
            Final FF = new Final(PersonName, Theme, nv, RightAnsw, nepqw, errors);
            this.Dispose();
            FF.ShowDialog();
        }
        #endregion

        #region Проверка правоты при выделении RadioButton'a
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            righting = false;

            if (radioButton0.Checked)
            {
                if (radioButton0.Text == right)
                    righting = true;
            }
            if (radioButton1.Checked)
            {
                if (radioButton1.Text == right)
                    righting = true;
            }
            if (radioButton2.Checked)
            {
                if (radioButton2.Text == right)
                    righting = true;
            }
            if (radioButton3.Checked)
            {
                if (radioButton3.Text == right)
                    righting = true;
            }

            pictureBox2.Enabled = true;

        }
        #endregion

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); //Вызываем Closing 1-ой формы
        }

        #region следующий вопрос
        private void NextButton_Click_1(object sender, EventArgs e)
        {
            Checked();
            LoadQwest(); //Загружаем вопрос
            ShowQwest(); //Выводим вопрос
            righting = false; //Сбрасываем "правоту"
        }
        #endregion
        private int remainingSeconds;
        
        private void TestirForm_Load(object sender, EventArgs e)
        {
            // Установка времени таймера на 10 минут
            remainingSeconds = 20 * 60;

            // Запуск таймера
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Обновление оставшегося времени
            remainingSeconds--;

            // Вычисление минут и секунд
            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;

            // Отображение времени на форме
            label1.Text = string.Format("Осталось времени: {0:00}:{1:00}", minutes, seconds);

            // Проверка, если время закончилось
            if (remainingSeconds == 0)
            {
                // Остановка таймера
                timer1.Stop();

                // Вывод сообщения об окончании времени
                MessageBox.Show("Ваше время истекло!","Тест");
                
                Final FF = new Final(PersonName, Theme, nv, RightAnsw, nepqw, errors);
                this.Dispose();
                FF.ShowDialog();

            }
        }

        private void QwLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Checked();
            LoadQwest(); //Загружаем вопрос
            ShowQwest(); //Выводим вопрос
            righting = false; //Сбрасываем "правоту"
        }
    }
}
