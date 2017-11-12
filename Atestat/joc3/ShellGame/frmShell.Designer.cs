namespace ShellGame
{
    partial class frmShell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShell));
            this.lblSaveScor = new System.Windows.Forms.Label();
            this.lblPariu = new System.Windows.Forms.Label();
            this.pbScoica0 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBanca = new System.Windows.Forms.Label();
            this.lblDolar1 = new System.Windows.Forms.Label();
            this.lblDolar3 = new System.Windows.Forms.Label();
            this.lblDolar5 = new System.Windows.Forms.Label();
            this.lblDolar10 = new System.Windows.Forms.Label();
            this.pbScoica1 = new System.Windows.Forms.PictureBox();
            this.pbScoica2 = new System.Windows.Forms.PictureBox();
            this.tmrInchideScoici = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.numBank = new System.Windows.Forms.NumericUpDown();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbScoica0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScoica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScoica2)).BeginInit();
            this.grbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBank)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaveScor
            // 
            this.lblSaveScor.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveScor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveScor.ForeColor = System.Drawing.Color.Chocolate;
            this.lblSaveScor.Location = new System.Drawing.Point(112, 496);
            this.lblSaveScor.Name = "lblSaveScor";
            this.lblSaveScor.Size = new System.Drawing.Size(113, 23);
            this.lblSaveScor.TabIndex = 1;
            this.lblSaveScor.Tag = "";
            this.lblSaveScor.Text = "Salveaza scor";
            this.lblSaveScor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaveScor.Click += new System.EventHandler(this.lblSaveScor_Click);
            // 
            // lblPariu
            // 
            this.lblPariu.BackColor = System.Drawing.Color.Transparent;
            this.lblPariu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPariu.ForeColor = System.Drawing.Color.Chocolate;
            this.lblPariu.Location = new System.Drawing.Point(115, 464);
            this.lblPariu.Name = "lblPariu";
            this.lblPariu.Size = new System.Drawing.Size(110, 19);
            this.lblPariu.TabIndex = 1;
            this.lblPariu.Tag = "1";
            this.lblPariu.Text = "1 $";
            this.lblPariu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbScoica0
            // 
            this.pbScoica0.Image = ((System.Drawing.Image)(resources.GetObject("pbScoica0.Image")));
            this.pbScoica0.Location = new System.Drawing.Point(170, 200);
            this.pbScoica0.Name = "pbScoica0";
            this.pbScoica0.Size = new System.Drawing.Size(110, 101);
            this.pbScoica0.TabIndex = 2;
            this.pbScoica0.TabStop = false;
            this.pbScoica0.Tag = "0";
            this.pbScoica0.Click += new System.EventHandler(this.pbScoica0_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Chocolate;
            this.lblName.Location = new System.Drawing.Point(258, 366);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(223, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Banca";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBanca
            // 
            this.lblBanca.BackColor = System.Drawing.Color.Transparent;
            this.lblBanca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanca.ForeColor = System.Drawing.Color.Chocolate;
            this.lblBanca.Location = new System.Drawing.Point(262, 398);
            this.lblBanca.Name = "lblBanca";
            this.lblBanca.Size = new System.Drawing.Size(219, 19);
            this.lblBanca.TabIndex = 1;
            this.lblBanca.Tag = "20";
            this.lblBanca.Text = "0 $     ";
            this.lblBanca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDolar1
            // 
            this.lblDolar1.BackColor = System.Drawing.Color.Transparent;
            this.lblDolar1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar1.ForeColor = System.Drawing.Color.Khaki;
            this.lblDolar1.Location = new System.Drawing.Point(269, 455);
            this.lblDolar1.Name = "lblDolar1";
            this.lblDolar1.Size = new System.Drawing.Size(51, 51);
            this.lblDolar1.TabIndex = 1;
            this.lblDolar1.Tag = "1";
            this.lblDolar1.Text = "1 $";
            this.lblDolar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDolar1.Click += new System.EventHandler(this.lblDolar1_Click);
            // 
            // lblDolar3
            // 
            this.lblDolar3.BackColor = System.Drawing.Color.Transparent;
            this.lblDolar3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar3.ForeColor = System.Drawing.Color.Khaki;
            this.lblDolar3.Location = new System.Drawing.Point(373, 455);
            this.lblDolar3.Name = "lblDolar3";
            this.lblDolar3.Size = new System.Drawing.Size(51, 51);
            this.lblDolar3.TabIndex = 1;
            this.lblDolar3.Tag = "3";
            this.lblDolar3.Text = "3 $";
            this.lblDolar3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDolar3.Click += new System.EventHandler(this.lblDolar3_Click);
            // 
            // lblDolar5
            // 
            this.lblDolar5.BackColor = System.Drawing.Color.Transparent;
            this.lblDolar5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar5.ForeColor = System.Drawing.Color.Khaki;
            this.lblDolar5.Location = new System.Drawing.Point(466, 455);
            this.lblDolar5.Name = "lblDolar5";
            this.lblDolar5.Size = new System.Drawing.Size(51, 51);
            this.lblDolar5.TabIndex = 1;
            this.lblDolar5.Tag = "5";
            this.lblDolar5.Text = "5 $";
            this.lblDolar5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDolar5.Click += new System.EventHandler(this.lblDolar5_Click);
            // 
            // lblDolar10
            // 
            this.lblDolar10.BackColor = System.Drawing.Color.Transparent;
            this.lblDolar10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar10.ForeColor = System.Drawing.Color.Khaki;
            this.lblDolar10.Location = new System.Drawing.Point(565, 455);
            this.lblDolar10.Name = "lblDolar10";
            this.lblDolar10.Size = new System.Drawing.Size(51, 51);
            this.lblDolar10.TabIndex = 1;
            this.lblDolar10.Tag = "10";
            this.lblDolar10.Text = "10 $";
            this.lblDolar10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDolar10.Click += new System.EventHandler(this.lblDolar10_Click);
            // 
            // pbScoica1
            // 
            this.pbScoica1.Image = ((System.Drawing.Image)(resources.GetObject("pbScoica1.Image")));
            this.pbScoica1.Location = new System.Drawing.Point(305, 200);
            this.pbScoica1.Name = "pbScoica1";
            this.pbScoica1.Size = new System.Drawing.Size(110, 101);
            this.pbScoica1.TabIndex = 2;
            this.pbScoica1.TabStop = false;
            this.pbScoica1.Tag = "1";
            this.pbScoica1.Click += new System.EventHandler(this.pbScoica1_Click);
            // 
            // pbScoica2
            // 
            this.pbScoica2.Image = ((System.Drawing.Image)(resources.GetObject("pbScoica2.Image")));
            this.pbScoica2.Location = new System.Drawing.Point(438, 200);
            this.pbScoica2.Name = "pbScoica2";
            this.pbScoica2.Size = new System.Drawing.Size(110, 101);
            this.pbScoica2.TabIndex = 2;
            this.pbScoica2.TabStop = false;
            this.pbScoica2.Tag = "2";
            this.pbScoica2.Click += new System.EventHandler(this.pbScoica2_Click);
            // 
            // tmrInchideScoici
            // 
            this.tmrInchideScoici.Interval = 1500;
            this.tmrInchideScoici.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(280, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bet and click the shell! Enjoy!";
            // 
            // grbLogin
            // 
            this.grbLogin.Controls.Add(this.numBank);
            this.grbLogin.Controls.Add(this.btnPlay);
            this.grbLogin.Controls.Add(this.txtNume);
            this.grbLogin.Controls.Add(this.label3);
            this.grbLogin.Controls.Add(this.lblNume);
            this.grbLogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.grbLogin.ForeColor = System.Drawing.Color.Chocolate;
            this.grbLogin.Location = new System.Drawing.Point(170, 160);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(378, 141);
            this.grbLogin.TabIndex = 4;
            this.grbLogin.TabStop = false;
            // 
            // numBank
            // 
            this.numBank.ForeColor = System.Drawing.Color.Chocolate;
            this.numBank.Location = new System.Drawing.Point(124, 66);
            this.numBank.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBank.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBank.Name = "numBank";
            this.numBank.ReadOnly = true;
            this.numBank.Size = new System.Drawing.Size(223, 22);
            this.numBank.TabIndex = 8;
            this.numBank.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.Chocolate;
            this.btnPlay.Location = new System.Drawing.Point(159, 98);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(86, 24);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Joaca";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtNume
            // 
            this.txtNume.ForeColor = System.Drawing.Color.Chocolate;
            this.txtNume.Location = new System.Drawing.Point(124, 33);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(223, 22);
            this.txtNume.TabIndex = 5;
            this.txtNume.Text = "Elev la atestat :)\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(31, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Banca:";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.Color.Transparent;
            this.lblNume.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.Color.Chocolate;
            this.lblNume.Location = new System.Drawing.Point(31, 33);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(45, 14);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume:";
            // 
            // frmShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(733, 561);
            this.Controls.Add(this.grbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbScoica2);
            this.Controls.Add(this.pbScoica1);
            this.Controls.Add(this.pbScoica0);
            this.Controls.Add(this.lblPariu);
            this.Controls.Add(this.lblBanca);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDolar10);
            this.Controls.Add(this.lblDolar5);
            this.Controls.Add(this.lblDolar3);
            this.Controls.Add(this.lblDolar1);
            this.Controls.Add(this.lblSaveScor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alba-Neagra";
            this.Load += new System.EventHandler(this.frmShell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbScoica0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScoica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScoica2)).EndInit();
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaveScor;
        private System.Windows.Forms.Label lblPariu;
        private System.Windows.Forms.PictureBox pbScoica0;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBanca;
        private System.Windows.Forms.Label lblDolar1;
        private System.Windows.Forms.Label lblDolar3;
        private System.Windows.Forms.Label lblDolar5;
        private System.Windows.Forms.Label lblDolar10;
        private System.Windows.Forms.PictureBox pbScoica1;
        private System.Windows.Forms.PictureBox pbScoica2;
        private System.Windows.Forms.Timer tmrInchideScoici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.NumericUpDown numBank;
        private System.Windows.Forms.Label label3;
    }
}

