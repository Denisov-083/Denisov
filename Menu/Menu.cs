using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_training_manual
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonTheory_Click(object sender, EventArgs e) // Кнопка перехода на теоретический материал
        {
            Theory theory = new Theory();
            theory.Show();
            this.Hide(); 
        }

        private void buttonTesting_Click(object sender, EventArgs e) // Кнопка перехода на тестирование
        {
            TestMenu f = new TestMenu();
            f.Show();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Menu_Closing (object sender, CancelEventArgs e) // закрытие программы
        { Application.Exit(); }

        private void pictureBox1_Click(object sender, EventArgs e) // о программе
        {
            //Information f = new Information();
            //f.Show();
            Help.ShowHelp(this, "denisov083.chm", "Введение.htm");
        }
    }

}
