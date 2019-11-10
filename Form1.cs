using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Location = new Point(label2.Location.X+5,label2.Location.Y);

            if (label2.Location.X > this.Width)
            {
                label2.Location = new Point(0 - label2.Width, label2.Location.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "user" && textBox2.Text == "admin")
            {
                Registration rs = new Registration();
                rs.Show();

            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
          

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 15;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pns ps = new pns();
            ps.Show();
        }
    }
}
