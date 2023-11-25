using System.Data;
using System.Data.SqlClient;

namespace Assignment03_213002
{
    public partial class Form1 : Form
    {
        static string str = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = Assignment3; Integrated Security = True;";
        SqlConnection con = new SqlConnection(str);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Form3();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Form4();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new Form5();
            f.Show();
        }
    }
}
