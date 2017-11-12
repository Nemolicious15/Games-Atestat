namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnJocNou = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblscor = new System.Windows.Forms.Label();
            this.lblm = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl0
            // 
            this.lbl0.BackColor = System.Drawing.Color.Cyan;
            this.lbl0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.ForeColor = System.Drawing.Color.White;
            this.lbl0.Location = new System.Drawing.Point(73, 72);
            this.lbl0.Name = "lbl0";
            this.lbl0.Padding = new System.Windows.Forms.Padding(10);
            this.lbl0.Size = new System.Drawing.Size(50, 50);
            this.lbl0.TabIndex = 0;
            this.lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl0.Click += new System.EventHandler(this.lbl0_Click);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(185, 71);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(50, 50);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "4";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.ForeColor = System.Drawing.Color.White;
            this.lbl7.Location = new System.Drawing.Point(129, 177);
            this.lbl7.Name = "lbl7";
            this.lbl7.Padding = new System.Windows.Forms.Padding(10);
            this.lbl7.Size = new System.Drawing.Size(50, 50);
            this.lbl7.TabIndex = 2;
            this.lbl7.Text = "1";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl7.Click += new System.EventHandler(this.lbl7_Click_1);
            // 
            // lbl8
            // 
            this.lbl8.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(185, 177);
            this.lbl8.Name = "lbl8";
            this.lbl8.Padding = new System.Windows.Forms.Padding(10);
            this.lbl8.Size = new System.Drawing.Size(50, 50);
            this.lbl8.TabIndex = 3;
            this.lbl8.Text = "1";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl8.Click += new System.EventHandler(this.lbl8_Click_1);
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(185, 126);
            this.lbl5.Name = "lbl5";
            this.lbl5.Padding = new System.Windows.Forms.Padding(10);
            this.lbl5.Size = new System.Drawing.Size(50, 50);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "1";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click_1);
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(129, 126);
            this.lbl4.Name = "lbl4";
            this.lbl4.Padding = new System.Windows.Forms.Padding(10);
            this.lbl4.Size = new System.Drawing.Size(50, 50);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "1";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click_1);
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(73, 126);
            this.lbl3.Name = "lbl3";
            this.lbl3.Padding = new System.Windows.Forms.Padding(10);
            this.lbl3.Size = new System.Drawing.Size(50, 50);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "1";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(73, 177);
            this.lbl6.Name = "lbl6";
            this.lbl6.Padding = new System.Windows.Forms.Padding(10);
            this.lbl6.Size = new System.Drawing.Size(50, 50);
            this.lbl6.TabIndex = 7;
            this.lbl6.Text = "1";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl6.Click += new System.EventHandler(this.lbl6_Click_1);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(129, 72);
            this.lbl1.Name = "lbl1";
            this.lbl1.Padding = new System.Windows.Forms.Padding(10);
            this.lbl1.Size = new System.Drawing.Size(50, 50);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "1";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // btnJocNou
            // 
            this.btnJocNou.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJocNou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnJocNou.Location = new System.Drawing.Point(114, 255);
            this.btnJocNou.Name = "btnJocNou";
            this.btnJocNou.Size = new System.Drawing.Size(84, 36);
            this.btnJocNou.TabIndex = 9;
            this.btnJocNou.Text = "Joc nou";
            this.btnJocNou.UseVisualStyleBackColor = true;
            this.btnJocNou.Click += new System.EventHandler(this.btnJocNou_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Scor:";
            // 
            // lblscor
            // 
            this.lblscor.AutoSize = true;
            this.lblscor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblscor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblscor.Location = new System.Drawing.Point(111, 31);
            this.lblscor.Name = "lblscor";
            this.lblscor.Size = new System.Drawing.Size(16, 16);
            this.lblscor.TabIndex = 10;
            this.lblscor.Text = "0";
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblm.Location = new System.Drawing.Point(157, 31);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(24, 16);
            this.lblm.TabIndex = 10;
            this.lblm.Text = "00";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbls.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbls.Location = new System.Drawing.Point(180, 31);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(24, 16);
            this.lbls.TabIndex = 10;
            this.lbls.Text = "00";
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(292, 316);
            this.Controls.Add(this.lblscor);
            this.Controls.Add(this.lblm);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJocNou);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl0);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sliding Puzzle- Incepator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnJocNou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblscor;
        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Timer tmr;
    }
}

