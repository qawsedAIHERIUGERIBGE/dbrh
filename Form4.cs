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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.пансионаты". При необходимости она может быть перемещена или удалена.
            this.пансионатыTableAdapter.Fill(this.dataSet1.пансионаты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            connection.Open();
            SqlCommand command = new SqlCommand(@"Delete FROM пансионаты  WHERE названиепансионата=@kli", connection);
            command.Parameters.AddWithValue("@kli", dataGridView1.CurrentRow.Cells[0].Value);
            command.ExecuteNonQuery();
            MessageBox.Show("пансионат был удален");
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
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM пансионаты", connection);
            connection.Open();
            DataSet dat = new DataSet();
            adap.Fill(dat, "пансионаты");
            dataGridView1.DataSource = dat.Tables["пансионаты"]; // вывод всех строк в элемент dataGridView
            connection.Close(); // конец
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 form14 = new Form14();
            form14.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form14 zz = new Form14();
            zz.Show();
            zz.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            zz.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            zz.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            zz.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            zz.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            zz.textBox6.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            zz.textBox7.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            zz.textBox8.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            zz.textBox9.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            zz.textBox10.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            zz.textBox11.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            zz.textBox12.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            SqlCommand command = new SqlCommand("SELECT * FROM пансионаты WHERE CONCAT ([названиепансионата],[адрес],[город],[страна],[телефон],[описаниетеритории],[количествокомнат],[наличиебасейна],[наличиемедицинскихуслуг],[наличиеспасалана],[уровеньпансионата],[растояниедоморя]) like '%" + textBox1.Text + "%'", connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }
    }
}
