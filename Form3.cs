using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03_213002
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = Assignment3; Integrated Security = True;";
            SqlConnection con = new SqlConnection(str);

            int id = int.Parse(textBox1.Text);
            SqlCommand c = new SqlCommand("SELECT * FROM Product WHERE Product_ID = @id", con);
            c.Parameters.AddWithValue("@id", id);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader dr = c.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridView1.DataSource = dt;

            var f = new Form1();
            f.Show();
        }
    }
}
