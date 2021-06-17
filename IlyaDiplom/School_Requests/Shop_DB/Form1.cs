using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM allrequests", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                File.WriteAllBytes(@"C:\" + i + "11.png", (byte[])table.Rows[i][11]);
                File.WriteAllBytes(@"C:\" + i + "12.png", (byte[])table.Rows[i][12]);
                File.WriteAllBytes(@"C:\" + i + "13.png", (byte[])table.Rows[i][13]);
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                richTextBox1.AppendText("ID записи: " + table.Rows[i][0] + "\n");
                richTextBox1.AppendText("Фамилия ученика: " + table.Rows[i][1] + "\n");
                richTextBox1.AppendText("Имя ученика: " + table.Rows[i][2] + "\n");
                richTextBox1.AppendText("Отчество ученика: " + table.Rows[i][3] + "\n");
                richTextBox1.AppendText("Домашний адрес: " + table.Rows[i][4] + "\n");
                richTextBox1.AppendText("Фамилия матери: " + table.Rows[i][5] + "\n");
                richTextBox1.AppendText("Имя матери: " + table.Rows[i][6] + "\n");
                richTextBox1.AppendText("Отчество матери: " + table.Rows[i][7] + "\n");
                richTextBox1.AppendText("Фамилия отца: " + table.Rows[i][8] + "\n");
                richTextBox1.AppendText("Имя отца: " + table.Rows[i][9] + "\n");
                richTextBox1.AppendText("Отчество отца: " + table.Rows[i][10] + "\n");
                richTextBox1.AppendText("Копия свидетельства о рождении: " + "\n");
                pasteMyBitmap(@"C:\" + i + "11.png");
                richTextBox1.AppendText("\n" + "Скан заявления о приеме в первый класс: " + "\n");
                pasteMyBitmap(@"C:\" + i + "12.png");
                richTextBox1.AppendText("\n" + "Копия СНИЛС: " + "\n");
                pasteMyBitmap(@"C:\" + i + "13.png");
                richTextBox1.AppendText("\n");
            }
        }

        private bool pasteMyBitmap(string fileName)
        {
            Bitmap myBitmap = new Bitmap(fileName);
            Clipboard.SetDataObject(myBitmap);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);

            if (richTextBox1.CanPaste(myFormat))
            {
                richTextBox1.Paste(myFormat);
                return true;
            }
            else return false;
        }
    }
}
