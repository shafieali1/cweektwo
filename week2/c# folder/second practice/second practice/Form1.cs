using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace second_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_concat_Click(object sender, EventArgs e)
        {
            // Creating variables to store the input values
            string firstName, SecondName, fullName;

            // initial values
            firstName = Txt_Frist_name.Text;
            SecondName = Txt_Second_name.Text;
            // process concatenation using the + operator
            fullName = firstName + " " + SecondName;

            // disply the output using lebel
            lbl_ouput.Text = fullName;


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // clear textbox using clear function
            Txt_Frist_name.Clear();
            Txt_Second_name.Clear();
        }
    }
}
