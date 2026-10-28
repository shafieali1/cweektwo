using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_project_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("welcome to c#");
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             // close form using keyword and close function
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lblplay.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set the label using textproberty 
            lblplay.Text = "mohamed mohameud";


        }
    }
}
