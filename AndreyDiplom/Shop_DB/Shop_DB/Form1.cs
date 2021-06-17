using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_DB
{
    public partial class Form1 : Form
    {
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();

            DataTable table = new DataTable();
            DataTable table2 = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT ID FROM eventtype", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++) comboBox1.Items.Add(table.Rows[i][0]);

            MySqlCommand command2 = new MySqlCommand("SELECT ID_member FROM eventsmembers", db.GetConnection());

            adapter2.SelectCommand = command2;
            adapter2.Fill(table2);

            for (int i = 0; i < table2.Rows.Count; i++) comboBox2.Items.Add(table2.Rows[i][0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Запрос к БД
            MySqlCommand command = new MySqlCommand("INSERT INTO eventsmembers VALUES (NULL, @Name, @Surname, @Patronymic)", db.GetConnection());

            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@Patronymic", MySqlDbType.VarChar).Value = textBox2.Text;

            db.openConnection(); //Открытие подключения
            //Проверка
            if (command.ExecuteNonQuery() == 1) MessageBox.Show("Успех!");
            else MessageBox.Show("Ошибка!");

            db.closeConnection(); //Закрытие подключения
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Запрос к БД
            MySqlCommand command = new MySqlCommand("INSERT INTO eventresults VALUES (NULL, @TypeMP, @NameMP, @ID_member, @Year, @Place)", db.GetConnection());

            command.Parameters.Add("@TypeMP", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@NameMP", MySqlDbType.VarChar).Value = textBox5.Text;
            command.Parameters.Add("@ID_member", MySqlDbType.VarChar).Value = comboBox2.Text;
            command.Parameters.Add("@Year", MySqlDbType.VarChar).Value = textBox6.Text;
            command.Parameters.Add("@Place", MySqlDbType.VarChar).Value = textBox7.Text;

            db.openConnection(); //Открытие подключения
            //Проверка
            if (command.ExecuteNonQuery() == 1) MessageBox.Show("Успех!");
            else MessageBox.Show("Ошибка!");

            db.closeConnection(); //Закрытие подключения
        }
    }
}
