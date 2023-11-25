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
    public partial class Form2 : Form
    {
        static string str = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = Assignment3; Integrated Security = True;";
        SqlConnection con = new SqlConnection(str);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "Insert Into Product Values (@ID, @Name, @Rate, @Quantity)";
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.CommandType = CommandType.Text;
            int id = int.Parse(textBox1.Text);
            double r = Double.Parse(textBox2.Text);
            int q = Convert.ToInt32(textBox4.Text);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Name", textBox3.Text);
            cmd.Parameters.AddWithValue("@Rate", r);
            cmd.Parameters.AddWithValue("@Quantity", q);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Insertion successful!");
            var f1 = new Form1();
            f1.Show();
        }
    }
}
