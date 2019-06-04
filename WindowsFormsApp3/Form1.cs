using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length < 1)
            {
                richTextBox2.Text = "";
            }
            else
            {


                Regex rxp = new Regex(" ");
                Regex rxpspace = new Regex("");
                string resultscram = rxpspace.Replace(richTextBox1.Text, ";lsdkjcnoi3rueh803uhn4083c038uhc8u3b0f8uh3v083uh83h94hv83uh0v9i2nh0i4uyvpoamOKSMCIR983UHC4");
                string result = rxp.Replace(resultscram, "");
                richTextBox2.Text = resultscram;
                richTextBox1.Text = string.Empty;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Length < 1)
            {
                richTextBox1.Text = "";
            }
            else
            {
                Regex rxp = new Regex(" ");
                Regex rxpspace = new Regex(";lsdkjcnoi3rueh803uhn4083c038uhc8u3b0f8uh3v083uh83h94hv83uh0v9i2nh0i4uyvpoamOKSMCIR983UHC4");
                string resultscram = rxpspace.Replace(richTextBox2.Text, "");
                string result = rxp.Replace(resultscram, "");
                richTextBox1.Text = resultscram;
                richTextBox2.Text = string.Empty;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
