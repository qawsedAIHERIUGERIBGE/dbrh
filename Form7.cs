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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            connection.Open(); 
            SqlCommand command = new SqlCommand("INSERT INTO [вид жилья] ([Название],[пансионат],[описаниеусловийпроживания],[ценазаномервсутки]) VALUES(@nam, @pan, @opis, @sena)", connection);                                                                                                                                                  
            command.Parameters.Add("@nam", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pan", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@opis", SqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@sena", SqlDbType.VarChar).Value = textBox4.Text;
            command.ExecuteNonQuery(); 
            connection.Close(); 
            MessageBox.Show("Новый вид жилья добавлен"); // 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
