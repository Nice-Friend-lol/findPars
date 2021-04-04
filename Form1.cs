using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace найди_пару
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int[] a = new int[6];
        
        public Form1()
        {
            InitializeComponent();
           
            for (int  i=0; i<3; i++)
            {
                a[i] = rnd.Next(0, 5000);
            }
            for (int  i = 3; i < 6; i++)
            {
                a[i] = a[i-3];
            }

            for (int j = 0; j < 100; j++) {
             int  f = rnd.Next(0,6);//2
                int g = a[f];
                int s = rnd.Next(0,6);//4
                a[f] = a[s];
                a[s] = g;
            }
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       
       
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = (a[0]).ToString();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = (a[1]).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = (a[2]).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = (a[3]).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = (a[5]).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = (a[1]).ToString();
        }
    }
}
