using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace турагенство_бдд
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO клиенты ([фамилия],[имя],[отчество],[паспортныеданные],[датарождения],[адрес],[город],[телефон]) VALUES(@fio, @pim, @ot, @spast,@data, @ad, @gor, @tel)", connection);
            command.Parameters.Add("@fio", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pim", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@ot", SqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@spast", SqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@data", SqlDbType.VarChar).Value = textBox5.Text;
            command.Parameters.Add("@ad", SqlDbType.VarChar).Value = textBox7.Text;
            command.Parameters.Add("@gor", SqlDbType.VarChar).Value = textBox8.Text;
            command.Parameters.Add("@tel", SqlDbType.VarChar).Value = textBox6.Text;
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Новый клиент добавлен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
