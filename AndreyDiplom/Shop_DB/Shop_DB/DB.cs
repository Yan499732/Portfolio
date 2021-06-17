using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_DB
{
    class DB
    {
    	//Подключение к БД
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=school");

        public void openConnection() //Открытие подключения
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection() //Закрытие подключения
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Clone();
        }

        public MySqlConnection GetConnection() //Проверка подключения
        {
            return connection;
        }
    }
}
