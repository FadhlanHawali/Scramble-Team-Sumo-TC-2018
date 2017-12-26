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
            string[] name = new string[32];
           

          

            Random rand = new Random();
            for (int i = 0; i < name.Length - 1; i++)
            {
                int j = rand.Next(i, name.Length);
                temp = name[i];
                name[i] = name[j];
                name[j] = temp;
            }
        
        }

    
    }
}
