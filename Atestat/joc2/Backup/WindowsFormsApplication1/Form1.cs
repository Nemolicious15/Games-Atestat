using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //System.Windows.Forms.Label[] l = new System.Windows.Forms.Label[16];
        int[] ales = new int[20];
        Label[] l = new Label[16];
        private void genereaza()
        {
            int i,a;
            for (i = 0; i < 16; i++) ales[i] = 0;
            for (i = 0; i < 16; i++)
            {
                Random rnd = new Random();
                do
                    a = rnd.Next(0, 100000) % 16;
                while (ales[a] != 0);
                ales[a] = 1;
                l[i].Text = (a != 0 ? a + "" : "");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            int sus = 50, stanga = 50, i;
         

            for (i = 0; i < 16; i++)
            {
                l[i] = new Label();
                l[i].Left = stanga + (i % 4) * 48;
                l[i].Top = sus;
                l[i].Size = new Size(48, 40);
                l[i].ForeColor = Color.DarkSalmon;
                l[i].Text = (i != 0 ? i + "" : "");
                l[i].BackColor = Color.MistyRose  ;
                l[i].Tag = i + "";
                l[i].Font = label1.Font;
                l[i].TextAlign =  label1.TextAlign;
                l[i].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(l[i]);
                this.l[i].Click += new System.EventHandler(this.moveL);
                if ((i + 1) % 4 == 0)
                {
                    sus += 40;
                    stanga = 50;
                }

            }
            
        }

        private void schimb(ref string  x,ref string  y)
        {
            string aux= x;
            x=y;
            y=aux; 
        }

        private void moveL(object sender, EventArgs e)
        {
            int i=Convert.ToInt16(((Label)sender).Tag.ToString());
           // int i = int.Parse(((Label)sender).Tag.ToString());
            //MessageBox.Show(i+"");
            int sus = i - 4, jos = i + 4, st = i - 1, dr = i + 1;
            if (sus >= 0 && l[sus].Text.Trim() == "")
            {
                //schimb(ref l[sus].Text,ref l[i].Text);
                l[sus].Text = l[i].Text;
                l[i].Text = "";
            }
            
            if (jos <=15 &&  l[jos].Text.Trim() == "")
            {
                l[jos].Text = l[i].Text;
                l[i].Text = "";
            }

            if (st >= 0  && (i%4>0) && l[st].Text.Trim() == "")
            {
                l[st].Text = l[i].Text;
                l[i].Text = "";
            }
            if (dr <=15 && (i % 4 <3) && l[dr].Text.Trim() == "")
            {
                l[dr].Text = l[i].Text;
                l[i].Text = "";
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            genereaza();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            genereaza();
                           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            /*if (MessageBox.Show("Stergeti datele clientului? ", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MessageBox.Show("ok, il sterg");*/
            //MessageBox.Show(e.ToString());
         }

        

       
    }
}
