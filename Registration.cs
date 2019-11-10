using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SS
{
    public partial class Registration : Form
    {
       
       // SqlConnection con=new SqlConnection(@"ProviderMicrosoft.Jet.OLEDB.4.0;Data Source=C:\Users\Shweta\Downloads\Northwind.MDBs");
       // con.ConnectionString==

        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=sample;Integrated Security=True"); 
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

   
            con.Open();
            // SqlCommand cmd=con.CreateCommand();
             SqlCommand cmd = con.CreateCommand();
            cmd.CommandType=CommandType.Text;
            cmd.CommandText = "insert into pnsdata1 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Data succesfully");
            details rsv = new details();
           // reservation rsv = new reservation();
            rsv.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {




            con.Open();
            // SqlCommand cmd=con.CreateCommand();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  pnsdata set name ='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Updated Successfully");






        }

        private void button3_Click(object sender, EventArgs e)
        {

            con.Open();
            // SqlCommand cmd=con.CreateCommand();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from  pnsdata where name ='"+textBox2.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();

           MessageBox.Show("Data Deleted Successfully");
        }

        private void Reserve_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
