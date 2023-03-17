namespace GUI
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.Slideshow = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.picLogoMacbook = new System.Windows.Forms.PictureBox();
            this.picLogoDell = new System.Windows.Forms.PictureBox();
            this.picLogoMSI = new System.Windows.Forms.PictureBox();
            this.picLogoAsus = new System.Windows.Forms.PictureBox();
            this.picLogoAcer = new System.Windows.Forms.PictureBox();
            this.picLogoHP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Slideshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMacbook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoDell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMSI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAsus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAcer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoHP)).BeginInit();
            this.SuspendLayout();
            // 
            // Slideshow
            // 
            this.Slideshow.Image = ((System.Drawing.Image)(resources.GetObject("Slideshow.Image")));
            this.Slideshow.Location = new System.Drawing.Point(20, 85);
            this.Slideshow.Name = "Slideshow";
            this.Slideshow.Size = new System.Drawing.Size(980, 496);
            this.Slideshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Slideshow.TabIndex = 0;
            this.Slideshow.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 2000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(389, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(251, 38);
            this.lblTitlePage.TabIndex = 13;
            this.lblTitlePage.Text = "Đẳng cấp Gaming";
            // 
            // picLogoMacbook
            // 
            this.picLogoMacbook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogoMacbook.Image = ((System.Drawing.Image)(resources.GetObject("picLogoMacbook.Image")));
            this.picLogoMacbook.Location = new System.Drawing.Point(20, 617);
            this.picLogoMacbook.Name = "picLogoMacbook";
            this.picLogoMacbook.Size = new System.Drawing.Size(125, 50);
            this.picLogoMacbook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoMacbook.TabIndex = 14;
            this.picLogoMacbook.TabStop = false;
            // 
            // picLogoDell
            // 
            this.picLogoDell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogoDell.Image = ((System.Drawing.Image)(resources.GetObject("picLogoDell.Image")));
            this.picLogoDell.Location = new System.Drawing.Point(187, 617);
            this.picLogoDell.Name = "picLogoDell";
            this.picLogoDell.Size = new System.Drawing.Size(120, 50);
            this.picLogoDell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoDell.TabIndex = 15;
            this.picLogoDell.TabStop = false;
            // 
            // picLogoMSI
            // 
            this.picLogoMSI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogoMSI.Image = ((System.Drawing.Image)(resources.GetObject("picLogoMSI.Image")));
            this.picLogoMSI.Location = new System.Drawing.Point(361, 617);
            this.picLogoMSI.Name = "picLogoMSI";
            this.picLogoMSI.Size = new System.Drawing.Size(120, 50);
            this.picLogoMSI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoMSI.TabIndex = 16;
            this.picLogoMSI.TabStop = false;
            // 
            // picLogoAsus
            // 
            this.picLogoAsus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogoAsus.Image = ((System.Drawing.Image)(resources.GetObject("picLogoAsus.Image")));
            this.picLogoAsus.Location = new System.Drawing.Point(535, 617);
            this.picLogoAsus.Name = "picLogoAsus";
            this.picLogoAsus.Size = new System.Drawing.Size(120, 50);
            this.picLogoAsus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoAsus.TabIndex = 17;
            this.picLogoAsus.TabStop = false;
            // 
            // picLogoAcer
            // 
            this.picLogoAcer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogoAcer.Image = ((System.Drawing.Image)(resources.GetObject("picLogoAcer.Image")));
            this.picLogoAcer.Location = new System.Drawing.Point(710, 617);
            this.picLogoAcer.Name = "picLogoAcer";
            this.picLogoAcer.Size = new System.Drawing.Size(120, 50);
            this.picLogoAcer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoAcer.TabIndex = 18;
            this.picLogoAcer.TabStop = false;
            // 
            // picLogoHP
            // 
            this.picLogoHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogoHP.Image = ((System.Drawing.Image)(resources.GetObject("picLogoHP.Image")));
            this.picLogoHP.Location = new System.Drawing.Point(880, 617);
            this.picLogoHP.Name = "picLogoHP";
            this.picLogoHP.Size = new System.Drawing.Size(120, 50);
            this.picLogoHP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoHP.TabIndex = 19;
            this.picLogoHP.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picLogoHP);
            this.Controls.Add(this.picLogoAcer);
            this.Controls.Add(this.picLogoAsus);
            this.Controls.Add(this.picLogoMSI);
            this.Controls.Add(this.picLogoDell);
            this.Controls.Add(this.picLogoMacbook);
            this.Controls.Add(this.lblTitlePage);
            this.Controls.Add(this.Slideshow);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Slideshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMacbook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoDell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMSI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAsus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAcer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Slideshow;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.PictureBox picLogoMacbook;
        private System.Windows.Forms.PictureBox picLogoDell;
        private System.Windows.Forms.PictureBox picLogoMSI;
        private System.Windows.Forms.PictureBox picLogoAsus;
        private System.Windows.Forms.PictureBox picLogoAcer;
        private System.Windows.Forms.PictureBox picLogoHP;
    }
}
