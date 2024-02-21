using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace Electronic_training_manual
{

    class Database
    {
        public MySqlConnection cn;
        public void Connect()
        {
            //cn = new MySqlConnection("Server=10.13.11.17; port = 3308; username = student; password = student; database = 083denisov;Convert Zero Datetime=True");
            cn = new MySqlConnection("Server=localhost; port = ; username = root; password = ; database = 083denisov;Convert Zero Datetime=True");

        }
    }


}
