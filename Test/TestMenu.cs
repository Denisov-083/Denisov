using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Electronic_training_manual
{
    public partial class TestMenu : Form
    {
        XmlReader xmlThemeRead;
        DirectoryInfo testsDirectory = new DirectoryInfo("Тест"); //Создаем объект соответствующей папке Tests
        public TestMenu()

        {
            InitializeComponent();

            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Dispose();
            }

            if (testsDirectory.Exists == false)
                //CreateTestDir();

            comboBox1.Items.AddRange(testsDirectory.GetDirectories()); //Добавление подпапок из директории Tests
        }


        #region Обновление ListBox'a
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ThemeLabel.Text = "Выбрано: "; //Принудительная очистка темы
            DirectoryInfo testsDir = new DirectoryInfo("Тест\\" + comboBox1.Text); //Создем объект соответствующий выбраной папке
            listBox1.Items.Clear(); //Очищаем listBox1

            foreach (FileInfo file in testsDir.GetFiles())
            {
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }

            LoadButton.Enabled = false;
        }
        #endregion

        #region Выбор теста в listBox'e
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                xmlThemeRead = new XmlTextReader("Тест\\" + comboBox1.Text + "\\" + listBox1.Text + ".xml");

                // ищем узел <Theme>
                do xmlThemeRead.Read();
                while (xmlThemeRead.Name != "Theme");

                // считываем тему теста
                xmlThemeRead.Read();

                // вывести тему теста
                ThemeLabel.Text = "Выбрано: " + xmlThemeRead.Value;

                // выходим из узла <Theme>
                xmlThemeRead.Read();

                LoadButton.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Такого файла не существует или нет прав для его открытия!\n\t\tВыберите другой файл!", "Ошибка!");
            }
        }
        #endregion

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Введите вашу фамилию и группу!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Просим ввести имя
            else
            {
                string xmlPath = "Тест\\" + "Test\\" + "Test.xml"; //Сохраняем путь к xml - файлу
                 
                TestirForm MF = new TestirForm(xmlPath, textBox1.Text, ThemeLabel.Text); //Передаем во 2ую форму путь к тесту и имя пользователя
                MF.Show(); //Вызываем форму тестирования
                this.Visible = false; //Скрываем первую форму
            }
        }

        private void Load_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) // Кнопка перехода в "Меню"
        {
            Menu f = new Menu();
            f.Show();
            this.Visible = false;
        }

        private void ThemeLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "denisov083.chm", "Тест.htm");
        }
    }
    }

