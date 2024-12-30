namespace DLWMS.WinApp.Asinhorno
{
    partial class frmAsinhrono
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
            cmbAdrese = new ComboBox();
            cmbBrojPonavljanja = new ComboBox();
            cmbPauza = new ComboBox();
            btnPing = new Button();
            txtIspis = new TextBox();
            btnUcitajStudente = new Button();
            SuspendLayout();
            // 
            // cmbAdrese
            // 
            cmbAdrese.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdrese.FormattingEnabled = true;
            cmbAdrese.Items.AddRange(new object[] { "www.google.com", "www.microsoft.com", "www.oracle.com" });
            cmbAdrese.Location = new Point(21, 47);
            cmbAdrese.Name = "cmbAdrese";
            cmbAdrese.Size = new Size(180, 23);
            cmbAdrese.TabIndex = 0;
            // 
            // cmbBrojPonavljanja
            // 
            cmbBrojPonavljanja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrojPonavljanja.FormattingEnabled = true;
            cmbBrojPonavljanja.Items.AddRange(new object[] { "20", "50", "100" });
            cmbBrojPonavljanja.Location = new Point(207, 47);
            cmbBrojPonavljanja.Name = "cmbBrojPonavljanja";
            cmbBrojPonavljanja.Size = new Size(98, 23);
            cmbBrojPonavljanja.TabIndex = 1;
            // 
            // cmbPauza
            // 
            cmbPauza.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPauza.FormattingEnabled = true;
            cmbPauza.Items.AddRange(new object[] { "100", "200", "500", "1000" });
            cmbPauza.Location = new Point(311, 47);
            cmbPauza.Name = "cmbPauza";
            cmbPauza.Size = new Size(98, 23);
            cmbPauza.TabIndex = 2;
            // 
            // btnPing
            // 
            btnPing.Location = new Point(415, 47);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(75, 23);
            btnPing.TabIndex = 3;
            btnPing.Text = "Ping";
            btnPing.UseVisualStyleBackColor = true;
            btnPing.Click += btnPing_Click;
            // 
            // txtIspis
            // 
            txtIspis.Font = new Font("Segoe UI", 13F);
            txtIspis.Location = new Point(21, 76);
            txtIspis.Multiline = true;
            txtIspis.Name = "txtIspis";
            txtIspis.Size = new Size(684, 351);
            txtIspis.TabIndex = 4;
            // 
            // btnUcitajStudente
            // 
            btnUcitajStudente.Location = new Point(583, 46);
            btnUcitajStudente.Name = "btnUcitajStudente";
            btnUcitajStudente.Size = new Size(121, 23);
            btnUcitajStudente.TabIndex = 5;
            btnUcitajStudente.Text = "Ucitaj studente";
            btnUcitajStudente.UseVisualStyleBackColor = true;
            btnUcitajStudente.Click += btnUcitajStudente_Click;
            // 
            // frmAsinhrono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 434);
            Controls.Add(btnUcitajStudente);
            Controls.Add(txtIspis);
            Controls.Add(btnPing);
            Controls.Add(cmbPauza);
            Controls.Add(cmbBrojPonavljanja);
            Controls.Add(cmbAdrese);
            Name = "frmAsinhrono";
            Text = "frmAsinhrono";
            Load += frmAsinhrono_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAdrese;
        private ComboBox cmbBrojPonavljanja;
        private ComboBox cmbPauza;
        private Button btnPing;
        private TextBox txtIspis;
        private Button btnUcitajStudente;
    }
}