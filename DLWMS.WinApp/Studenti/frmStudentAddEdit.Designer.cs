namespace DLWMS.WinApp.Studenti
{
    partial class frmStudentAddEdit
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
            btnSacuvaj = new Button();
            pbSlika = new PictureBox();
            btnUcitajSliku = new Button();
            txtBrojIndeksa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtPrezime = new TextBox();
            label4 = new Label();
            txtIme = new TextBox();
            dtpDatumRodjenja = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            txtLozinka = new TextBox();
            cmbSpol = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            cmbDrzave = new ComboBox();
            label9 = new Label();
            cmbGradovi = new ComboBox();
            cbAktivan = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            err = new ErrorProvider(components);
            clbUloge = new CheckedListBox();
            tcUnosPodataka = new TabControl();
            tabPage1 = new TabPage();
            btnDalje = new Button();
            tabPage2 = new TabPage();
            button1 = new Button();
            label10 = new Label();
            tabPage3 = new TabPage();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            tcUnosPodataka.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(310, 255);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 10;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(30, 20);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(184, 228);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 1;
            pbSlika.TabStop = false;
            // 
            // btnUcitajSliku
            // 
            btnUcitajSliku.Location = new Point(30, 254);
            btnUcitajSliku.Name = "btnUcitajSliku";
            btnUcitajSliku.Size = new Size(184, 23);
            btnUcitajSliku.TabIndex = 2;
            btnUcitajSliku.Text = "Učitaj sliku";
            btnUcitajSliku.UseVisualStyleBackColor = true;
            btnUcitajSliku.Click += btnUcitajSliku_Click;
            // 
            // txtBrojIndeksa
            // 
            txtBrojIndeksa.Location = new Point(39, 141);
            txtBrojIndeksa.Name = "txtBrojIndeksa";
            txtBrojIndeksa.Size = new Size(171, 23);
            txtBrojIndeksa.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 123);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 4;
            label1.Text = "Broj indeksa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 216);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(39, 234);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 23);
            txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 25);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 10;
            label3.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(214, 43);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(172, 23);
            txtPrezime.TabIndex = 1;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 25);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(39, 43);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(171, 23);
            txtIme.TabIndex = 0;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(39, 92);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(171, 23);
            dtpDatumRodjenja.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 74);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 12;
            label5.Text = "Datum rođenja:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(214, 123);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 14;
            label6.Text = "Lozinka:";
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(214, 141);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(171, 23);
            txtLozinka.TabIndex = 5;
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(214, 92);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(170, 23);
            cmbSpol.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(214, 74);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 16;
            label7.Text = "Spol:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 167);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 18;
            label8.Text = "Država:";
            // 
            // cmbDrzave
            // 
            cmbDrzave.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzave.FormattingEnabled = true;
            cmbDrzave.Location = new Point(39, 185);
            cmbDrzave.Name = "cmbDrzave";
            cmbDrzave.Size = new Size(170, 23);
            cmbDrzave.TabIndex = 6;
            cmbDrzave.SelectedIndexChanged += cmbDrzave_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(214, 167);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 20;
            label9.Text = "Grad:";
            // 
            // cmbGradovi
            // 
            cmbGradovi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradovi.FormattingEnabled = true;
            cmbGradovi.Location = new Point(214, 185);
            cmbGradovi.Name = "cmbGradovi";
            cmbGradovi.Size = new Size(170, 23);
            cmbGradovi.TabIndex = 7;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(217, 236);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 9;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // clbUloge
            // 
            clbUloge.CheckOnClick = true;
            clbUloge.FormattingEnabled = true;
            clbUloge.Location = new Point(21, 34);
            clbUloge.Name = "clbUloge";
            clbUloge.Size = new Size(364, 202);
            clbUloge.TabIndex = 21;
            // 
            // tcUnosPodataka
            // 
            tcUnosPodataka.Controls.Add(tabPage1);
            tcUnosPodataka.Controls.Add(tabPage2);
            tcUnosPodataka.Controls.Add(tabPage3);
            tcUnosPodataka.Location = new Point(12, 21);
            tcUnosPodataka.Name = "tcUnosPodataka";
            tcUnosPodataka.SelectedIndex = 0;
            tcUnosPodataka.Size = new Size(427, 334);
            tcUnosPodataka.TabIndex = 22;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDalje);
            tabPage1.Controls.Add(txtLozinka);
            tabPage1.Controls.Add(txtBrojIndeksa);
            tabPage1.Controls.Add(cbAktivan);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(cmbGradovi);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtIme);
            tabPage1.Controls.Add(cmbDrzave);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtPrezime);
            tabPage1.Controls.Add(cmbSpol);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(dtpDatumRodjenja);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(419, 306);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Podaci o studentu";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDalje
            // 
            btnDalje.Location = new Point(309, 261);
            btnDalje.Name = "btnDalje";
            btnDalje.Size = new Size(75, 23);
            btnDalje.TabIndex = 21;
            btnDalje.Text = "Dalje >>";
            btnDalje.UseVisualStyleBackColor = true;
            btnDalje.Click += btnDalje_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(pbSlika);
            tabPage2.Controls.Add(btnUcitajSliku);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(419, 306);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Slika";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(324, 254);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Dalje >>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.Location = new Point(233, 20);
            label10.Name = "label10";
            label10.Size = new Size(166, 81);
            label10.TabIndex = 3;
            label10.Text = "Slika mora biti u .png formatu, dimenzija 500*350 na kojoj moraju biti jasno vidljivi";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(btnSacuvaj);
            tabPage3.Controls.Add(clbUloge);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(419, 306);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Uloge";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 14);
            label11.Name = "label11";
            label11.Size = new Size(144, 15);
            label11.TabIndex = 22;
            label11.Text = "Odaberite uloge studenta:";
            // 
            // frmStudentAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 370);
            Controls.Add(tcUnosPodataka);
            Name = "frmStudentAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o studentu";
            Load += frmStudentAddEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            tcUnosPodataka.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSacuvaj;
        private PictureBox pbSlika;
        private Button btnUcitajSliku;
        private TextBox txtBrojIndeksa;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtPrezime;
        private Label label4;
        private TextBox txtIme;
        private DateTimePicker dtpDatumRodjenja;
        private Label label5;
        private Label label6;
        private TextBox txtLozinka;
        private ComboBox cmbSpol;
        private Label label7;
        private Label label8;
        private ComboBox cmbDrzave;
        private Label label9;
        private ComboBox cmbGradovi;
        private CheckBox cbAktivan;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider err;
        private CheckedListBox clbUloge;
        private TabControl tcUnosPodataka;
        private TabPage tabPage1;
        private Button btnDalje;
        private TabPage tabPage2;
        private Button button1;
        private Label label10;
        private TabPage tabPage3;
        private Label label11;
    }
}