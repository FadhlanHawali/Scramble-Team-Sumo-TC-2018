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

  
        public void Form1_Load(object sender, EventArgs e)
        {
           
        }



        public void button1_Click(object sender, EventArgs e)
        {
            string temp;
            string[] name = new string[16];

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = "Tim" +" " + i;
            }


            Random rand = new Random();
            for (int i = 0; i < name.Length; i++)
            {
                int j = rand.Next(i, name.Length);
                temp = name[i];
                name[i] = name[j];
                name[j] = temp;
            }
            this.label1.Text = name[0];
            this.label2.Text = name[1];
            this.label3.Text = name[2];
            this.label4.Text = name[3];
            this.label5.Text = name[4];
            this.label6.Text = name[5];
            this.label7.Text = name[6];
            this.label8.Text = name[7];
            this.label9.Text = name[8];
            this.label10.Text = name[9];
            this.label11.Text = name[10];
            this.label12.Text = name[11];
            this.label13.Text = name[12];
            this.label14.Text = name[13];
            this.label15.Text = name[14];
            this.label16.Text = name[15];
         

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.label33.Text = this.label1.Text;        
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.label33.Text = this.label2.Text;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.label34.Text = this.label3.Text;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.label34.Text = this.label4.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.label35.Text = this.label5.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.label35.Text = this.label6.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.label36.Text = this.label7.Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.label36.Text = this.label8.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.label37.Text = this.label9.Text;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.label37.Text = this.label10.Text;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.label38.Text = this.label11.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.label38.Text = this.label12.Text;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.label39.Text = this.label13.Text;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.label39.Text = this.label14.Text;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.label40.Text = this.label15.Text;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.label40.Text = this.label16.Text;
        }

        private void label33_Click(object sender, EventArgs e)
        {
            this.label49.Text = this.label33.Text;
        }

        private void label34_Click(object sender, EventArgs e)
        {
            this.label49.Text = this.label34.Text;
        }

        private void label35_Click(object sender, EventArgs e)
        {
            this.label50.Text = this.label35.Text;
        }

        private void label36_Click(object sender, EventArgs e)
        {
            this.label50.Text = this.label36.Text;
        }

        private void label37_Click(object sender, EventArgs e)
        {
            this.label51.Text = this.label37.Text;
        }

        private void label38_Click(object sender, EventArgs e)
        {
            this.label51.Text = this.label38.Text;
        }

        private void label39_Click(object sender, EventArgs e)
        {
            this.label52.Text = this.label39.Text;
        }

        private void label40_Click(object sender, EventArgs e)
        {
            this.label52.Text = this.label40.Text;
        }

        private void label49_Click(object sender, EventArgs e)
        {
            this.label57.Text = this.label49.Text;
        }

        private void label50_Click(object sender, EventArgs e)
        {
            this.label57.Text = this.label50.Text;
        }

        private void label51_Click(object sender, EventArgs e)
        {
            this.label58.Text = this.label51.Text;
        }

        private void label52_Click(object sender, EventArgs e)
        {
            this.label58.Text = this.label52.Text;
        }

        private void label57_Click(object sender, EventArgs e)
        {
            this.label61.Text = this.label57.Text;
        }

        private void label58_Click(object sender, EventArgs e)
        {
            this.label61.Text = this.label58.Text;
        }

        private void label61_Click(object sender, EventArgs e)
        {
            this.label63.Text = this.label61.Text + "\n" + "Hore Menang";

        }
    }
}
