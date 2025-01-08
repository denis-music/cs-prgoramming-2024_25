namespace DLWMS.WinApp
{
    partial class frmGlavna
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            odjavaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            krajRadaToolStripMenuItem = new ToolStripMenuItem();
            studentiToolStripMenuItem = new ToolStripMenuItem();
            noviStudentToolStripMenuItem = new ToolStripMenuItem();
            pretragaStudenataToolStripMenuItem = new ToolStripMenuItem();
            igreToolStripMenuItem = new ToolStripMenuItem();
            xOToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            oProgramuToolStripMenuItem = new ToolStripMenuItem();
            ažuriranjaToolStripMenuItem = new ToolStripMenuItem();
            provjeraDostupnostiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, studentiToolStripMenuItem, igreToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(952, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { provjeraDostupnostiToolStripMenuItem, odjavaToolStripMenuItem, toolStripSeparator1, krajRadaToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // odjavaToolStripMenuItem
            // 
            odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            odjavaToolStripMenuItem.Size = new Size(183, 22);
            odjavaToolStripMenuItem.Text = "Odjava";
            odjavaToolStripMenuItem.Click += odjavaToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(180, 6);
            // 
            // krajRadaToolStripMenuItem
            // 
            krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            krajRadaToolStripMenuItem.Size = new Size(183, 22);
            krajRadaToolStripMenuItem.Text = "Kraj rada";
            krajRadaToolStripMenuItem.Click += krajRadaToolStripMenuItem_Click;
            // 
            // studentiToolStripMenuItem
            // 
            studentiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noviStudentToolStripMenuItem, pretragaStudenataToolStripMenuItem });
            studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            studentiToolStripMenuItem.Size = new Size(63, 20);
            studentiToolStripMenuItem.Text = "Studenti";
            // 
            // noviStudentToolStripMenuItem
            // 
            noviStudentToolStripMenuItem.Name = "noviStudentToolStripMenuItem";
            noviStudentToolStripMenuItem.Size = new Size(173, 22);
            noviStudentToolStripMenuItem.Text = "Novi student";
            noviStudentToolStripMenuItem.Click += noviStudentToolStripMenuItem_Click;
            // 
            // pretragaStudenataToolStripMenuItem
            // 
            pretragaStudenataToolStripMenuItem.Name = "pretragaStudenataToolStripMenuItem";
            pretragaStudenataToolStripMenuItem.Size = new Size(173, 22);
            pretragaStudenataToolStripMenuItem.Text = "Pretraga studenata";
            pretragaStudenataToolStripMenuItem.Click += pretragaStudenataToolStripMenuItem_Click;
            // 
            // igreToolStripMenuItem
            // 
            igreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xOToolStripMenuItem });
            igreToolStripMenuItem.Name = "igreToolStripMenuItem";
            igreToolStripMenuItem.Size = new Size(39, 20);
            igreToolStripMenuItem.Text = "Igre";
            // 
            // xOToolStripMenuItem
            // 
            xOToolStripMenuItem.Name = "xOToolStripMenuItem";
            xOToolStripMenuItem.Size = new Size(90, 22);
            xOToolStripMenuItem.Text = "XO";
            xOToolStripMenuItem.Click += xOToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oProgramuToolStripMenuItem, ažuriranjaToolStripMenuItem });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(40, 20);
            infoToolStripMenuItem.Text = "Info";
            // 
            // oProgramuToolStripMenuItem
            // 
            oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            oProgramuToolStripMenuItem.Size = new Size(180, 22);
            oProgramuToolStripMenuItem.Text = "O programu";
            oProgramuToolStripMenuItem.Click += oProgramuToolStripMenuItem_Click;
            // 
            // ažuriranjaToolStripMenuItem
            // 
            ažuriranjaToolStripMenuItem.Name = "ažuriranjaToolStripMenuItem";
            ažuriranjaToolStripMenuItem.Size = new Size(180, 22);
            ažuriranjaToolStripMenuItem.Text = "Ažuriranja";
            ažuriranjaToolStripMenuItem.Click += ažuriranjaToolStripMenuItem_Click;
            // 
            // provjeraDostupnostiToolStripMenuItem
            // 
            provjeraDostupnostiToolStripMenuItem.Name = "provjeraDostupnostiToolStripMenuItem";
            provjeraDostupnostiToolStripMenuItem.Size = new Size(183, 22);
            provjeraDostupnostiToolStripMenuItem.Text = "Provjera dostupnosti";
            provjeraDostupnostiToolStripMenuItem.Click += provjeraDostupnostiToolStripMenuItem_Click;
            // 
            // frmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 553);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmGlavna";
            Text = "DLWMS v.5.0.1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem odjavaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem krajRadaToolStripMenuItem;
        private ToolStripMenuItem studentiToolStripMenuItem;
        private ToolStripMenuItem noviStudentToolStripMenuItem;
        private ToolStripMenuItem pretragaStudenataToolStripMenuItem;
        private ToolStripMenuItem igreToolStripMenuItem;
        private ToolStripMenuItem xOToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem oProgramuToolStripMenuItem;
        private ToolStripMenuItem ažuriranjaToolStripMenuItem;
        private ToolStripMenuItem provjeraDostupnostiToolStripMenuItem;
    }
}