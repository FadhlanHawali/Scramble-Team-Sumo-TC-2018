using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Team_TC_Label
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string temp;
            string[] name = new string[10];
            name[0] = "1";
            name[1] = "2";
            name[2] = "3";
            name[3] = "4";
            name[4] = "5";
            name[5] = "6";
            name[6] = "7";
            name[7] = "8";
            name[8] = "9";
            name[9] = "10";


            this.label11.Text = name[0];
            this.label12.Text = name[1];
            this.label13.Text = name[2];
            this.label14.Text = name[3];
            this.label15.Text = name[4];
            this.label16.Text = name[5];
            this.label17.Text = name[6];
            this.label18.Text = name[7];
            this.label19.Text = name[8];
            this.label20.Text = name[9];
           
            Random rand = new Random();
            for (int i = 0; i < name.Length - 1; i++)
            {
                int j = rand.Next(i, name.Length);
                temp = name[i];
                name[i] = name[j];
                name[j] = temp;
            }
            this.label11.Text = name[0];
            this.label12.Text = name[1];
            this.label13.Text = name[2];
            this.label14.Text = name[3];
            this.label15.Text = name[4];
            this.label16.Text = name[5];
            this.label17.Text = name[6];
            this.label18.Text = name[7];
            this.label19.Text = name[8];
            this.label20.Text = name[9];
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
