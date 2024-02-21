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
    public partial class Practice : Form
    {
        public Practice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Кнопка в Меню
        {
            Menu f = new Menu();
            f.Show();
            this.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e) // Кнопка Выход
        {
            Application.Exit();
        }
    }
}
