namespace DLWMS.WinApp.Studenti
{
    partial class frmStudentiUplate
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
            cmbVrstaUplate = new ComboBox();
            cmbAkademskaGodina = new ComboBox();
            cmbGodinaStudija = new ComboBox();
            dtpDatumUplate = new DateTimePicker();
            txtIznos = new TextBox();
            txtNapomena = new TextBox();
            btnDodaj = new Button();
            dgvUplate = new DataGridView();
            VrstaUplate = new DataGridViewTextBoxColumn();
            AkademskaGodina = new DataGridViewTextBoxColumn();
            GodinaStudija = new DataGridViewTextBoxColumn();
            DatumUplate = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvUplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // cmbVrstaUplate
            // 
            cmbVrstaUplate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrstaUplate.FormattingEnabled = true;
            cmbVrstaUplate.Location = new Point(12, 27);
            cmbVrstaUplate.Name = "cmbVrstaUplate";
            cmbVrstaUplate.Size = new Size(260, 23);
            cmbVrstaUplate.TabIndex = 0;
            // 
            // cmbAkademskaGodina
            // 
            cmbAkademskaGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAkademskaGodina.FormattingEnabled = true;
            cmbAkademskaGodina.Location = new Point(278, 27);
            cmbAkademskaGodina.Name = "cmbAkademskaGodina";
            cmbAkademskaGodina.Size = new Size(172, 23);
            cmbAkademskaGodina.TabIndex = 1;
            // 
            // cmbGodinaStudija
            // 
            cmbGodinaStudija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodinaStudija.FormattingEnabled = true;
            cmbGodinaStudija.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cmbGodinaStudija.Location = new Point(456, 27);
            cmbGodinaStudija.Name = "cmbGodinaStudija";
            cmbGodinaStudija.Size = new Size(166, 23);
            cmbGodinaStudija.TabIndex = 2;
            // 
            // dtpDatumUplate
            // 
            dtpDatumUplate.Location = new Point(12, 59);
            dtpDatumUplate.Name = "dtpDatumUplate";
            dtpDatumUplate.Size = new Size(208, 23);
            dtpDatumUplate.TabIndex = 3;
            dtpDatumUplate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(226, 59);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(396, 23);
            txtIznos.TabIndex = 4;
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new Point(12, 88);
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(610, 23);
            txtNapomena.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(547, 117);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvUplate
            // 
            dgvUplate.AllowUserToAddRows = false;
            dgvUplate.AllowUserToDeleteRows = false;
            dgvUplate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUplate.Columns.AddRange(new DataGridViewColumn[] { VrstaUplate, AkademskaGodina, GodinaStudija, DatumUplate, Iznos });
            dgvUplate.Location = new Point(12, 146);
            dgvUplate.Name = "dgvUplate";
            dgvUplate.ReadOnly = true;
            dgvUplate.Size = new Size(610, 194);
            dgvUplate.TabIndex = 7;
            // 
            // VrstaUplate
            // 
            VrstaUplate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VrstaUplate.DataPropertyName = "VrstaUplate";
            VrstaUplate.HeaderText = "Vrsta uplate";
            VrstaUplate.Name = "VrstaUplate";
            VrstaUplate.ReadOnly = true;
            // 
            // AkademskaGodina
            // 
            AkademskaGodina.DataPropertyName = "AkademskaGodina";
            AkademskaGodina.HeaderText = "Ak.god";
            AkademskaGodina.Name = "AkademskaGodina";
            AkademskaGodina.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            GodinaStudija.DataPropertyName = "GodinaStudija";
            GodinaStudija.HeaderText = "Godina";
            GodinaStudija.Name = "GodinaStudija";
            GodinaStudija.ReadOnly = true;
            // 
            // DatumUplate
            // 
            DatumUplate.DataPropertyName = "DatumUplate";
            DatumUplate.HeaderText = "Uplaceno";
            DatumUplate.Name = "DatumUplate";
            DatumUplate.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Iznos";
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmStudentiUplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 354);
            Controls.Add(dgvUplate);
            Controls.Add(btnDodaj);
            Controls.Add(txtNapomena);
            Controls.Add(txtIznos);
            Controls.Add(dtpDatumUplate);
            Controls.Add(cmbGodinaStudija);
            Controls.Add(cmbAkademskaGodina);
            Controls.Add(cmbVrstaUplate);
            Name = "frmStudentiUplate";
            Text = "Uplate studenta";
            Load += frmStudentiUplate_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbVrstaUplate;
        private ComboBox cmbAkademskaGodina;
        private ComboBox cmbGodinaStudija;
        private DateTimePicker dtpDatumUplate;
        private TextBox txtIznos;
        private TextBox txtNapomena;
        private Button btnDodaj;
        private DataGridView dgvUplate;
        private DataGridViewTextBoxColumn VrstaUplate;
        private DataGridViewTextBoxColumn AkademskaGodina;
        private DataGridViewTextBoxColumn GodinaStudija;
        private DataGridViewTextBoxColumn DatumUplate;
        private DataGridViewTextBoxColumn Iznos;
        private ErrorProvider err;
    }
}