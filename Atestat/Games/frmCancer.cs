using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class frmCancer : Form
    {
        public frmCancer()
        {
            InitializeComponent();
        }

        int care = 0;
        int descopera = 1;

        private void pariu(int suma)
        {
            int banca = Convert.ToInt16(lblBanca.Tag);
            Random r = new Random();
            care = r.Next() % 3;


            if (banca >= suma)
            {
                lblPariu.Text = suma.ToString() + " $";
                lblPariu.Tag = suma;
                descopera = 1;
            }
            else
            {
                MessageBox.Show("Suma disponibila este insuficienta!", "Ati pierdut!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblDolar1_Click(object sender, EventArgs e)
        {
            pariu(1);
        }

        private void lblDolar3_Click(object sender, EventArgs e)
        {
            pariu(3);
        }

        private void lblDolar5_Click(object sender, EventArgs e)
        {
            pariu(5);
        }

        private void lblDolar10_Click(object sender, EventArgs e)
        {
            pariu(10);
        }

        private void pbScoica0_Click(object sender, EventArgs e)
        {
            alege(pbScoica0);
        }

        private void pbScoica1_Click(object sender, EventArgs e)
        {
            alege(pbScoica1);
        }

        private void pbScoica2_Click(object sender, EventArgs e)
        {
            alege(pbScoica2);
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            pbScoica0.Image = pbScoica1.Image = pbScoica2.Image = new Bitmap("img/1.png");
            tmrInchideScoici.Stop();
            descopera = 1;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtNume.Text.Trim() != "")
            {
                grbLogin.Visible = false;
                lblBanca.Text = numBank.Value + " $ ";
                lblBanca.Tag = numBank.Value;
            }
        }


        private void alege(PictureBox p)
        {
            int banca = Convert.ToInt16(lblBanca.Tag);
            int pariu = Convert.ToInt16(lblPariu.Tag);
            if (descopera == 0 || pariu > banca)
                return;
            if (care.ToString() == p.Tag.ToString())
            {
                banca += pariu;
                p.Image = new Bitmap("img/0.png");

            }
            else
            {
                banca -= pariu;
                p.Image = new Bitmap("img/2.png");

            }
            descopera = 0;
            lblBanca.Text = banca.ToString() + " $";
            lblBanca.Tag = banca;
            tmrInchideScoici.Start();

        }

        private void lblSaveScor_Click(object sender, EventArgs e)
        {
            this.Text = (3 < 4.5).ToString();
        }

        private void frmCancer_Load(object sender, EventArgs e)
        {

        }
    }
}
