using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace Electronic_training_manual.myclass
{
    class DataClass
    {
        //MySqlConnection con = new MySqlConnection("Server=10.13.11.17; port = 3308; username = student; password = student; database = 083denisov");
        MySqlConnection con = new MySqlConnection("Server=localhost; port = ; username = root; password = ; database = 083denisov");




        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return con;
        }

    }

}



