using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace _5.Online_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Reg]\r\n           ([Firstname]\r\n           ,[Lastname]\r\n           ,[address]\r\n           ,[gender]\r\n           ,[email]\r\n           ,[phone]\r\n           ,[username]\r\n           ,[Password]\r\n,
VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+comboBox1.SelectedItem.ToString()+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"')");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Successfully");
        }  

    }
}
