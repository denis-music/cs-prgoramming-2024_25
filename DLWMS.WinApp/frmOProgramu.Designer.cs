namespace DLWMS.WinApp
{
    partial class frmOProgramu
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            lblAutori = new Label();
            linkLabel1 = new LinkLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_fit;
            pictureBox1.Location = new Point(134, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblAutori
            // 
            lblAutori.Font = new Font("Segoe UI", 11F);
            lblAutori.Location = new Point(12, 164);
            lblAutori.Name = "lblAutori";
            lblAutori.Size = new Size(404, 310);
            lblAutori.TabIndex = 1;
            lblAutori.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(178, 496);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(64, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "www.fit.ba";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 700;
            timer1.Tick += timer1_Tick;
            // 
            // frmOProgramu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 536);
            Controls.Add(linkLabel1);
            Controls.Add(lblAutori);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOProgramu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "O programu";
            Load += frmOProgramu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblAutori;
        private LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}