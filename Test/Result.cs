using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace Electronic_training_manual
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        public Final(string PersonName, string Theme, int NumbersOfQwest, int RightAnswers, int nepqw, List<string> errors)
        {
            InitializeComponent();
            //Заполняем текстовые поля
            NameLabel.Text += PersonName;
            ThemeLabel.Text = Theme;
            NumbersLabel.Text += NumbersOfQwest.ToString(); // количество вопросов
            RightLabel.Text += RightAnswers.ToString(); // правильные ответы
            nepqw1.Text += nepqw; //неправильные ответы
            foreach (string str in errors)
            {
                errorsLable.Text += "\n" + str ;
            }

            //Вычисляем оценку
            double percentage = ((double)RightAnswers / NumbersOfQwest) * 100;
            int Mark;

            if (percentage >= 90)
            {
                Mark = 5;
                
            }
            else if (percentage >= 70)
            {
                Mark = 4;
                
            }
            else if (percentage >= 50)
            {
                Mark = 3;
            }

            else if (percentage >= 0)
            {
                Mark = 2;
            }

            else
            {
                Mark = 2;
            }

            //Выводим оценку
            MarkLabel.Text += Mark.ToString();

        } 

        private void Final_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e) // Сохрание оценок 
        {
            string res = string.Format(NameLabel.Text + "\n" + MarkLabel.Text + "\n-----------\n");
            string path = Path.Combine(Application.StartupPath, "Результаты студентов");

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            File.WriteAllText(Path.Combine(path, string.Format("{0}.doc", NameLabel.Text.Remove(0, NameLabel.Text.IndexOf(':') + 1))), res);
            Menu f = new Menu();
            f.Show();
            this.Visible = false;
        }
    }
}
