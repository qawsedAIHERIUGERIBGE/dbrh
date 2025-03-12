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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.туры". При необходимости она может быть перемещена или удалена.
            this.турыTableAdapter.Fill(this.dataSet1.туры);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            connection.Open();
            SqlCommand command = new SqlCommand(@"Delete  FROM туры WHERE названиетура=@tur", connection);
            command.Parameters.AddWithValue("@tur", dataGridView1.CurrentRow.Cells[0].Value);
            command.ExecuteNonQuery();
            MessageBox.Show("тур был удален");
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
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM туры", connection);
            connection.Open();
            DataSet dat = new DataSet();
            adap.Fill(dat, "туры");
            dataGridView1.DataSource = dat.Tables["туры"];
            connection.Close(); // конец
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form16 zz = new Form16();
            zz.Show();
            zz.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            zz.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            zz.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            zz.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            zz.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=WIN-8K19KB6IDBS;Integrated Security=SSPI;Initial Catalog=турагенство бдд");
            SqlCommand command = new SqlCommand("SELECT * FROM туры WHERE CONCAT ([названиетура],[видтранспорта],[категорияжильянаночь],[видпитания],[ценатуравсутки]) like '%" + textBox1.Text + "%'", connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }
    }
}
