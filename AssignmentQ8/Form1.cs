using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentQ8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Programming III");
            listBox1.Items.Add("ata structure");
            listBox1.Items.Add("Operating System");
            listBox1.Items.Add("Software Engineering");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          DialogResult Answer = MessageBox.Show("Are you sure you want to clear", "Clear" , MessageBoxButtons.YesNo);

            if (DialogResult.Yes == Answer)
            {
                textBox1.Text = null;
                textBox2.Text = null;
                listBox1.SelectedItems.Clear();
                checkBox1.Checked = false;
                textBox1.Focus();
            }
            else
                textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndices.Count <2)
            {
                MessageBox.Show("Please select At least two Courses");
                checkBox1.AutoCheck = false;
            }else
            checkBox1.Checked = true;
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            
        }

        private void Form1_Validated(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 10)
            {
                MessageBox.Show("Please Enter a valied Name, should be less than 10 character. ");
                textBox1.Focus();
                textBox1.Text = null;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            int Age = int.Parse(textBox2.Text);
            if (Age <= 16 || Age >= 26)
            {
                MessageBox.Show("Please Enter a valied Age! should be between 16 and 26");
                textBox2.Focus();
                textBox2.Text = null;
            }

        }
    }
}
