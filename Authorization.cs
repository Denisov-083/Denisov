using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using Electronic_training_manual.myclass;
using Electronic_training_manual;

namespace Electronic_training_manual
{
    public partial class Authorization : Form
    {
        DataClass database = new DataClass();

        public Authorization()
        {

            InitializeComponent();

        }

        private void Authorization_Load_1(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id, login, password FROM account WHERE login= '{loginUser}' AND password = '{passUser}'";

            MySqlCommand command = new MySqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                Menu a = new Menu();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Неправильные данные", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
