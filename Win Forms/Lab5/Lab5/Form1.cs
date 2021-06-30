using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public string Login = "Admin";
        public string Password = "Admin";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.studentsTableAdapter1.Fill(this.dataBaseDataSet1.Students);
            this.studentsTableAdapter.Fill(this.dataBaseDataSet.Students);
            tabPage2.Parent = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Update(this.dataBaseDataSet.Students);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                studentsBindingSource1.Filter = "Фамилия Not Like '%Абв%'";
                if (!String.IsNullOrWhiteSpace(textBox1.Text)) studentsBindingSource1.Filter += "AND [Номер дела] = \'" + textBox1.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox2.Text)) studentsBindingSource1.Filter += "AND Фамилия = \'" + textBox2.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox3.Text)) studentsBindingSource1.Filter += "AND Имя = \'" + textBox3.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox4.Text)) studentsBindingSource1.Filter += "AND Отчество = \'" + textBox4.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox5.Text)) studentsBindingSource1.Filter += "AND Специальность = \'" + textBox5.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox6.Text)) studentsBindingSource1.Filter += "AND Курс = \'" + textBox6.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox7.Text)) studentsBindingSource1.Filter += "AND [Год рождения] = \'" + textBox7.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox8.Text)) studentsBindingSource1.Filter += "AND [Приказ зачисления] = \'" + textBox8.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox9.Text)) studentsBindingSource1.Filter += "AND [Приказ отчисления] = \'" + textBox9.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox10.Text)) studentsBindingSource1.Filter += "AND [Приказ восстановления] = \'" + textBox10.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox11.Text)) studentsBindingSource1.Filter += "AND [Приказ академа] = \'" + textBox11.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox12.Text)) studentsBindingSource1.Filter += "AND [Приказ диплома] = \'" + textBox12.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox13.Text)) studentsBindingSource1.Filter += "AND [Оценка] = \'" + textBox13.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox14.Text)) studentsBindingSource1.Filter += "AND [Приказ 2-й курс] = \'" + textBox14.Text + "\'";
                if (!String.IsNullOrWhiteSpace(textBox15.Text)) studentsBindingSource1.Filter += "AND [Приказ 3-й курс] = \'" + textBox15.Text + "\'";
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
            textBox10.Text = null;
            textBox11.Text = null;
            textBox12.Text = null;
            textBox13.Text = null;
            textBox14.Text = null;
            textBox15.Text = null;
            studentsBindingSource1.Filter = "Фамилия Not Like '%Абв%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox16.Text == Login && textBox17.Text == Password)
            {
                MessageBox.Show("Вы успешно авторизовались");
                tabPage3.Parent = null;
                tabPage2.Parent = tabControl1;
                tabControl1.SelectedTab = tabPage2;

                textBox16.Text = null;
                textBox17.Text = null;
            }
            else MessageBox.Show("Ошибка авторизации");
        }

        public bool Log(string a, string b)
        {
            if (a == "Admin" && b == "Admin") return true;
            else return false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabPage2.Parent = null;
            tabPage3.Parent = tabControl1;
            tabControl1.SelectedTab = tabPage3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter1.Fill(this.dataBaseDataSet1.Students);
        }
    }
}
