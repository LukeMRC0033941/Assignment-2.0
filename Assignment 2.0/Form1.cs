using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object Answer1 { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance of a 2 series circuit
            try
            {
                double R1, R2, RT;
                R1 = Convert.ToDouble(textBox2.Text);
                R2 = Convert.ToDouble(textBox3.Text);
                RT = R1 + R2;
                Answer1 = "Total resistance = " + RT;
                textBox1.Text = Answer1.ToString();

            }
            catch
            {
                MessageBox.Show("Type in 2 numbers");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance of a 3 series circuit
            try
            {
                double R1, R2, R3, RT;
                R1 = Convert.ToDouble(textBox5.Text);
                R2 = Convert.ToDouble(textBox6.Text);
                R3 = Convert.ToDouble(textBox7.Text);
                RT = R1 + R2 + R3;
                Answer1 = "Total resistance = " + RT;
                textBox4.Text = Answer1.ToString();
            }
            catch
            {
                MessageBox.Show("Type in 3 numbers");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance of a 4 series circuit
            try
            {
                double R1, R2, R3, R4, RT;
                R1 = Convert.ToDouble(textBox8.Text);
                R2 = Convert.ToDouble(textBox9.Text);
                R3 = Convert.ToDouble(textBox10.Text);
                R4 = Convert.ToDouble(textBox11.Text);
                RT = R1 + R2 + R3 + R4;
                Answer1 = "Total resistance = " + RT;
                textBox12.Text = Answer1.ToString();
            }
            catch
            {
                MessageBox.Show("Type in 4 numbers");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance of a 5 series circuit
            try
            {
                double R1, R2, R3, R4, R5, RT;
                R1 = Convert.ToDouble(textBox14.Text);
                R2 = Convert.ToDouble(textBox13.Text);
                R3 = Convert.ToDouble(textBox18.Text);
                R4 = Convert.ToDouble(textBox17.Text);
                R5 = Convert.ToDouble(textBox16.Text);
                RT = R1 + R2 + R3 + R4;
                Answer1 = "Total resistance = " + RT;
                textBox15.Text = Answer1.ToString();
            }
            catch
            {
                MessageBox.Show("Type in 5 numbers");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance of a 2 parallel circuit
            try
            {
                double R1, R2, RT;
                R1 = Convert.ToDouble(textBox19.Text);
                R2 = Convert.ToDouble(textBox20.Text);
                RT = 1 / (1 / R1 + 1 / R2);
                Answer1 = "Total resistance = " + RT;
                textBox21.Text = Answer1.ToString();

            }
            catch
            {
                MessageBox.Show("Type in 2 numbers");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance of a 3 parallel circuit
            try
            {
                double R1, R2, R3, RT;
                R1 = Convert.ToDouble(textBox22.Text);
                R2 = Convert.ToDouble(textBox23.Text);
                R3 = Convert.ToDouble(textBox24.Text);
                RT = 1 / (1 / R1 + 1 / R2 + 1 / R3);
                Answer1 = "Total resistance = " + RT;
                textBox25.Text = Answer1.ToString();

            }
            catch
            {
                MessageBox.Show("Type in 3 numbers");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance of a 4 parallel circuit
            try
            {
                double R1, R2, R3, R4, RT;
                R1 = Convert.ToDouble(textBox27.Text);
                R2 = Convert.ToDouble(textBox28.Text);
                R3 = Convert.ToDouble(textBox29.Text);
                R4 = Convert.ToDouble(textBox30.Text);
                RT = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4);
                Answer1 = "Total resistance = " + RT;
                textBox26.Text = Answer1.ToString();

            }
            catch
            {
                MessageBox.Show("Type in 4 numbers");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance of a 5 parallel circuit
            try
            {
                double R1, R2, R3, R4, R5, RT;
                R1 = Convert.ToDouble(textBox31.Text);
                R2 = Convert.ToDouble(textBox32.Text);
                R3 = Convert.ToDouble(textBox33.Text);
                R4 = Convert.ToDouble(textBox34.Text);
                R5 = Convert.ToDouble(textBox35.Text);
                RT = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4 + 1 / R5);
                Answer1 = "Total resistance = " + RT;
                textBox36.Text = Answer1.ToString();

            }
            catch
            {
                MessageBox.Show("Type in 5 numbers");
            }
        }
    }
}