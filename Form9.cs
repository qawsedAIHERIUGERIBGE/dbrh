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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO путевки ([клиент],[пансионат],[виджилья],[датазаезда],[датаотъезда],[наличиедетей],[наличиемедстраховки],[количествочеловек],[цена],[сумма]) VALUES(@kl,@pan,@vid,@dt,@dtr,@nal,@med,@sel,@sen,@summa)", connection);
            command.Parameters.Add("@kl", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pan", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@vid", SqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@dt", SqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@dtr", SqlDbType.VarChar).Value = textBox5.Text;
            command.Parameters.Add("@nal", SqlDbType.VarChar).Value = textBox6.Text;
            command.Parameters.Add("@med", SqlDbType.VarChar).Value = textBox7.Text;
            command.Parameters.Add("@sel", SqlDbType.VarChar).Value = textBox8.Text;
            command.Parameters.Add("@sen", SqlDbType.VarChar).Value = textBox9.Text;
            command.Parameters.Add("@summa", SqlDbType.VarChar).Value = textBox10.Text;
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Новая путевка добавлена");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
