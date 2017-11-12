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
        int[] a = new int[10];
        string[] salvate=new string[1000];
        int nr=0;
        int timp = 0,scor=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JocNou();
        }

        private void btnJocNou_Click(object sender, EventArgs e)
        {
            JocNou();
        }
        //-----------------------------functiile mele
        private string alege()
        {
            Random r = new Random();
            int x;
            do
            {
                x=r.Next(10000)%9;
            }while(a[x]==1);

            a[x] = 1;
            return x.ToString();
        }

        private void seteaza(Label l)
        {
            l.Text = alege();
            l.BackColor = Color.RoyalBlue;
            
            if (l.Text == "0")
            {
                l.Text = " ";
                l.BackColor = Color.Cyan;
            }
        }

        private void ScrieTimp()
        {
            int minute = timp / 60;
            int secundr = timp % 60;
            lblm.Text = (minute < 10 ? "0" : "") + minute.ToString();
            lbls.Text = (secundr < 10 ? "0" : "") + secundr.ToString();
        
        }

        private void inregistreaza()
        {
            nr++;
            salvate[nr] = lbl0.Text + lbl1.Text + lbl2.Text + lbl3.Text + lbl4.Text + lbl5.Text + lbl6.Text + lbl7.Text + lbl8.Text;
        }

        private void seteaza(Label l, int poz)
        {

            l.Text = salvate[nr][poz].ToString();
            l.BackColor = Color.RoyalBlue;

            if (l.Text == " ")
            {
            
                l.BackColor = Color.Cyan;
            }
        }
        private void refacere()
        {
            seteaza(lbl0, 0);
            seteaza(lbl1, 1);
            seteaza(lbl2, 2);
            seteaza(lbl3, 3);
            seteaza(lbl4, 4);
            seteaza(lbl5, 5);
            seteaza(lbl6, 6);
            seteaza(lbl7, 7);
            seteaza(lbl8, 8);
        }

        private void JocNou()
        {
            for (int i = 0; i <= 8; i++)
                a[i] = 0;
            lbl1.Enabled = true;
            lbl3.Enabled = true;
            seteaza(lbl0);
            seteaza(lbl1);
            seteaza(lbl2);
            seteaza(lbl3);
            seteaza(lbl4);
            seteaza(lbl5);
            seteaza(lbl6);
            seteaza(lbl7);
            seteaza(lbl8);
            tmr.Enabled = true;
            timp = 0;
            ScrieTimp();
            nr = 0;
        }

        private void Rezolva()
        {
            lbl0.Text = " ";
            lbl1.Text = "1";
            lbl2.Text = "2";
            lbl3.Text = "3";
            lbl4.Text = "4";
            lbl5.Text = "5";
            lbl6.Text = "6";
            lbl7.Text = "7";
            lbl8.Text = "8";
        }
        
       
        private void schimba(Label x,Label y)
        {
            inregistreaza();
            Color aux;
            string aux1;
            aux1 = x.Text;
            x.Text = y.Text;
            y.Text = aux1;

            aux = x.BackColor;
            x.BackColor = y.BackColor;
            y.BackColor = aux;
           


        }



       private Boolean verifica()
        {
            return ((lbl0.Text == "") && (lbl1.Text == "1") && (lbl2.Text == "2") && (lbl3.Text == "3") && (lbl4.Text == "4") && (lbl5.Text == "5") && (lbl6.Text == "6") && (lbl7.Text == "7") && (lbl8.Text == "8"));
            
        }

       private void termina()
       {
           if (verifica())
           {
               tmr.Enabled = false;
               MessageBox.Show("Ai castigat", "Puzzle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               lbl1.Enabled = false;
               lbl3.Enabled = false;
           }
       }

        private void lbl0_Click(object sender, EventArgs e)
        {
            if (lbl1.Text == " ")
            {
                schimba(lbl1, lbl0);
            }
            if (lbl3.Text == " ")
            {
                schimba(lbl3, lbl0);
            }
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            if (lbl0.Text == " ")
            {
                schimba(lbl0, lbl1);
            }
            if (lbl4.Text == " ")
            {
                schimba(lbl4, lbl1);
            }
            if (lbl2.Text == " ")
            {
                schimba(lbl2, lbl1);
            }
        }
        private void lbl2_Click(object sender, EventArgs e)
        {
            if (lbl1.Text == " ")
            {
                schimba(lbl1, lbl2);
            }
            if (lbl5.Text == " ")
            {
                schimba(lbl5, lbl2);
            }
        }
        private void lbl3_Click(object sender, EventArgs e)
        {
            if (lbl0.Text == " ")
            {
                schimba(lbl0, lbl3);
            }
            if (lbl4.Text == " ")
            {
                schimba(lbl4, lbl3);
            }
            if (lbl6.Text == " ")
            {
                schimba(lbl6, lbl3);
            }
        }
       
        private void lbl4_Click_1(object sender, EventArgs e)
        {
            if (lbl1.Text == " ")
            {
                schimba(lbl1, lbl4);
            }
            if (lbl3.Text == " ")
            {
                schimba(lbl3, lbl4);
            }
            if (lbl5.Text == " ")
            {
                schimba(lbl5, lbl4);
            }
            if (lbl7.Text == " ")
            {
                schimba(lbl7, lbl4);
            }
        }

        private void lbl5_Click_1(object sender, EventArgs e)
        {
            if (lbl2.Text == " ")
            {
                schimba(lbl2, lbl5);
            }
            if (lbl4.Text == " ")
            {
                schimba(lbl4, lbl5);
            }
            if (lbl8.Text == " ")
            {
                schimba(lbl8, lbl5);
            }
        }

        private void lbl6_Click_1(object sender, EventArgs e)
        {
            if (lbl3.Text == " ")
            {
                schimba(lbl3, lbl6);
            }
            if (lbl7.Text == " ")
            {
                schimba(lbl7, lbl6);
            }
        }

        private void lbl7_Click_1(object sender, EventArgs e)
        {
            if (lbl6.Text == " ")
            {
                schimba(lbl6, lbl7);
            }
            if (lbl4.Text == " ")
            {
                schimba(lbl4, lbl7);
            }
            if (lbl8.Text == " ")
            {
                schimba(lbl8, lbl7);
            }
        }

        private void lbl8_Click_1(object sender, EventArgs e)
        {
            if (lbl7.Text == " ")
            {
                schimba(lbl7, lbl8);
            }
            if (lbl5.Text == " ")
            {
                schimba(lbl5, lbl8);
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            timp++;
            ScrieTimp();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int care=e.KeyChar;
            if ((care == 26)&&(nr>0))
            {
                refacere();
                nr--;
            }
            //MessageBox.Show(care.ToString());
        }
    }
}
