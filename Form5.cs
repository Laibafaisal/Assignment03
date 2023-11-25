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
    public partial class Form5 : Form
    {
        static string str = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = Assignment3; Integrated Security = True;";
        SqlConnection con = new SqlConnection(str);
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string c = "DELETE FROM Product WHERE Product_ID = @PID";
            SqlCommand cmd = new SqlCommand(c, con);
            cmd.Parameters.AddWithValue("@PID", id);
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Recordc deleted successfully!", "Deletion", MessageBoxButtons.OK);
            var f1 = new Form1();
            f1.GetData();
            
        }
    }
}
