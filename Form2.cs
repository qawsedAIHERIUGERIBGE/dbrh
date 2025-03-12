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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.вид_жилья". При необходимости она может быть перемещена или удалена.
            this.вид_жильяTableAdapter.Fill(this.dataSet1.вид_жилья);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            connection.Open(); 
            SqlCommand command = new SqlCommand(@"Delete FROM [вид жилья]  WHERE название=@nam", connection);
            command.Parameters.AddWithValue("@nam", dataGridView1.CurrentRow.Cells[0].Value); 
            command.ExecuteNonQuery();
            MessageBox.Show("вид жилья был удален");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM [вид жилья]", connection); 
            connection.Open(); 
            DataSet dat = new DataSet();
            adap.Fill(dat, "вид жилья"); 
            dataGridView1.DataSource = dat.Tables["вид жилья"]; 
            connection.Close(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form12 zz = new Form12();
            zz.Show();
            zz.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            zz.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            zz.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            zz.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            SqlCommand command = new SqlCommand ("SELECT * FROM [вид жилья] WHERE CONCAT ([Название],[пансионат],[описаниеусловийпроживания],[ценазаномервсутки]) like '%" + textBox1.Text + "%'",connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }
    }
}
