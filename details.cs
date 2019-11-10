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
    public partial class details : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=sample;Integrated Security=True"); 
    
        public details()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String sqlSelectQuery ="select * from pnsdata1 where ID="+int.Parse(textBox1.Text);
            SqlCommand cmd =new SqlCommand(sqlSelectQuery,con);
            SqlDataReader dr= cmd.ExecuteReader();
            if(dr.Read())
            {
                textBox2.Text=(dr["Name"].ToString());
                textBox3.Text = (dr["PhoneNo"].ToString());
                textBox4.Text = (dr["From"].ToString());
                textBox5.Text = (dr["To"].ToString());
                textBox6.Text = (dr["Arrivaltime"].ToString());
                textBox10.Text = (dr["Departuretime"].ToString());
                textBox7.Text = (dr["NoOfInfants"].ToString());
                textBox8.Text = (dr["NoOfadults"].ToString());
             
                textBox11.Text = (dr["Crate"].ToString());
                textBox12.Text = (dr["Prate"].ToString());
               // textBox12.Text = (dr['"+2*"Prate"+"'].ToString());
               

            }
            con.Close();

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
