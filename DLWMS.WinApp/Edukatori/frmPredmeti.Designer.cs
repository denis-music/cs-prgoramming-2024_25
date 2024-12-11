namespace DLWMS.WinApp.Edukatori
{
    partial class frmPredmeti
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
            dgvPredmeti = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Semestar = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            txtNaziv = new TextBox();
            txtEcts = new TextBox();
            cmbSemestri = new ComboBox();
            cbAktivan = new CheckBox();
            btnDodaj = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPredmeti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // dgvPredmeti
            // 
            dgvPredmeti.AllowUserToAddRows = false;
            dgvPredmeti.AllowUserToDeleteRows = false;
            dgvPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPredmeti.Columns.AddRange(new DataGridViewColumn[] { Naziv, ECTS, Semestar, Aktivan });
            dgvPredmeti.Location = new Point(12, 113);
            dgvPredmeti.Name = "dgvPredmeti";
            dgvPredmeti.ReadOnly = true;
            dgvPredmeti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPredmeti.Size = new Size(617, 217);
            dgvPredmeti.TabIndex = 0;
            dgvPredmeti.CellContentClick += dgvPredmeti_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // ECTS
            // 
            ECTS.DataPropertyName = "ECTS";
            ECTS.HeaderText = "ECTS";
            ECTS.Name = "ECTS";
            ECTS.ReadOnly = true;
            // 
            // Semestar
            // 
            Semestar.DataPropertyName = "Semestar";
            Semestar.HeaderText = "Semestar";
            Semestar.Name = "Semestar";
            Semestar.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(12, 84);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(199, 23);
            txtNaziv.TabIndex = 1;
            // 
            // txtEcts
            // 
            txtEcts.Location = new Point(217, 84);
            txtEcts.Name = "txtEcts";
            txtEcts.Size = new Size(84, 23);
            txtEcts.TabIndex = 2;
            // 
            // cmbSemestri
            // 
            cmbSemestri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestri.FormattingEnabled = true;
            cmbSemestri.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbSemestri.Location = new Point(307, 84);
            cmbSemestri.Name = "cmbSemestri";
            cmbSemestri.Size = new Size(121, 23);
            cmbSemestri.TabIndex = 3;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(434, 86);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 4;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(506, 82);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(122, 23);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPredmeti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 338);
            Controls.Add(btnDodaj);
            Controls.Add(cbAktivan);
            Controls.Add(cmbSemestri);
            Controls.Add(txtEcts);
            Controls.Add(txtNaziv);
            Controls.Add(dgvPredmeti);
            Name = "frmPredmeti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o predmetima";
            Load += frmPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPredmeti).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPredmeti;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewTextBoxColumn Semestar;
        private DataGridViewCheckBoxColumn Aktivan;
        private TextBox txtNaziv;
        private TextBox txtEcts;
        private ComboBox cmbSemestri;
        private CheckBox cbAktivan;
        private Button btnDodaj;
        private ErrorProvider err;
    }
}