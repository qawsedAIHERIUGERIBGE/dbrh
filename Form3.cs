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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.dataSet1.клиенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            connection.Open();
            SqlCommand command = new SqlCommand(@"Delete FROM клиенты WHERE фамилия=@fam", connection); 
            command.Parameters.AddWithValue("@fam", dataGridView1.CurrentRow.Cells[0].Value); 
            command.ExecuteNonQuery();
            MessageBox.Show("клиент был удален");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM клиенты", connection);
            connection.Open();
            DataSet dat = new DataSet();
            adap.Fill(dat, "клиенты");
            dataGridView1.DataSource = dat.Tables["клиенты"]; // вывод всех строк в элемент dataGridView
            connection.Close(); // конец
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form13 zz = new Form13();
            zz.Show();
            zz.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            zz.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            zz.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            zz.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            zz.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            zz.textBox6.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            zz.textBox7.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            zz.textBox8.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            SqlCommand command = new SqlCommand("SELECT * FROM клиенты WHERE CONCAT ([фамилия],[имя],[отчество],[паспортныеданные],[датарождения],[адрес],[город],[телефон]) like '%" + textBox1.Text + "%'", connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }
    }
}
