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
    public partial class confirm : Form
    {
        public confirm()
        {
            InitializeComponent();
        }

        private void confirm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            details ds = new details();
            ds.Show();

        }
    }
}
