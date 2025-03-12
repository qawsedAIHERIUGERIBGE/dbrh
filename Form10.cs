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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO пансионаты ([названиепансионата],[адрес],[город],[страна],[телефон],[описаниетеритории],[количествокомнат],[наличиебасейна],[наличиемедицинскихуслуг],[наличиеспасалана],[уровеньпансионата],[растояниедоморя]) VALUES(@kla,@pana,@vida,@dtr,@dtre,@nala,@meda,@sela,@sena,@summas,@sene,@summaw)", connection);
            command.Parameters.Add("@kla", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pana", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@vida", SqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@dtr", SqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@dtre", SqlDbType.VarChar).Value = textBox5.Text;
            command.Parameters.Add("@nala", SqlDbType.VarChar).Value = textBox6.Text;
            command.Parameters.Add("@meda", SqlDbType.VarChar).Value = textBox7.Text;
            command.Parameters.Add("@sela", SqlDbType.VarChar).Value = textBox8.Text;
            command.Parameters.Add("@sena", SqlDbType.VarChar).Value = textBox9.Text;
            command.Parameters.Add("@summas", SqlDbType.VarChar).Value = textBox10.Text;
            command.Parameters.Add("@sene", SqlDbType.VarChar).Value = textBox11.Text;
            command.Parameters.Add("@summaw", SqlDbType.VarChar).Value = textBox12.Text;
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Новый пансионат добавлен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
