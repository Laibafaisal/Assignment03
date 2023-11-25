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
    public partial class Form4 : Form
    {
        static string str = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = Assignment3; Integrated Security = True;";
        SqlConnection con = new SqlConnection(str);
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            decimal up = decimal.Parse(textBox3.Text);
            int q = int.Parse(textBox4.Text);
            string cmd = "UPDATE Product SET Name = @name, unitPrice = @up, quantityInStock = @q WHERE Product_ID = @id";
            SqlCommand command = new SqlCommand(cmd, con);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", textBox2.Text);
            command.Parameters.AddWithValue("@up", up);
            command.Parameters.AddWithValue("@q", q);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated Successfully");
            var f1 = new Form1();
            f1.Show();


        }
    }
}
