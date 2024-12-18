using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DLWMS.WinApp.Studenti
{
    public partial class frmStudentAddEdit : Form
    {
        private Student? student;

        DLWMSContext db = new DLWMSContext();


        public frmStudentAddEdit(Student? odabraniStudent = null)
        {
            InitializeComponent();
            this.student =
                db.Studenti.Include(s => s.Uloge)
                .Where(s => s.Id == odabraniStudent.Id).FirstOrDefault()



                ?? new Student();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (ValidanUnos())
            {
                student.Ime = txtIme.Text;
                student.Prezime = txtPrezime.Text;
                student.DatumRodjenja = dtpDatumRodjenja.Value;
                student.SpolId = (int)cmbSpol.SelectedValue;
                student.Email = txtEmail.Text;
                student.BrojIndeksa = txtBrojIndeksa.Text;
                student.Lozinka = txtLozinka.Text;
                student.GradId = (int)cmbGradovi.SelectedValue;
                student.Slika = pbSlika.Image.ToByteArray();
                student.Aktivan = cbAktivan.Checked;

                student.Uloge = clbUloge.CheckedItems.Cast<Uloga>().ToList();


                if (student.Id == 0)
                    //student.Id = InMemoryDB.Studenti.Count + 1;
                    db.Studenti.Add(student);
                else
                    db.Update(student);

                db.SaveChanges();

                DialogResult = DialogResult.OK;
                Close();
            }


        }

        private bool ValidanUnos()
        {
            return
                    Validator.ProvjeriUnos(pbSlika, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(txtIme, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(txtPrezime, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(cmbSpol, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(txtBrojIndeksa, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(txtLozinka, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(cmbGradovi, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(txtEmail, err, Resursi.Get(Kljucevi.RequiredField));
        }

        private void frmStudentAddEdit_Load(object sender, EventArgs e)
        {
            UcitajSpolove();
            UcitajDrzave();
            UcitajUloge();

            if (student.Id == 0)
                UcitajGenerisanePodatke();
            else
                UcitajPodatkeOStudentu();

        }

        private void UcitajUloge()
        {
            clbUloge.DataSource = db.Uloge.ToList();
        }

        private void UcitajPodatkeOStudentu()
        {
            txtIme.Text = student.Ime;
            txtPrezime.Text = student.Prezime;
            dtpDatumRodjenja.Value = student.DatumRodjenja;
            cmbSpol.SelectedValue = student.SpolId;
            txtEmail.Text = student.Email;
            txtBrojIndeksa.Text = student.BrojIndeksa;
            txtLozinka.Text = student.Lozinka;
            cmbDrzave.SelectedValue = db.Gradovi
                .Where(grad => grad.Id == student.GradId).First().DrzavaId;
            cmbGradovi.SelectedValue = student.GradId;
            pbSlika.Image = student.Slika.ToImage();
            cbAktivan.Checked = student.Aktivan;

            for (int i = 0; i < clbUloge.Items.Count; i++)
            {
                var uloga = clbUloge.Items[i] as Uloga;
                if (student.Uloge.Any(x => x.Id == uloga.Id))
                    clbUloge.SetItemChecked(i, true);
            }


        }

        private void GenerisiEmail()
        {
            txtEmail.Text = Generator.GenerisiEmail(txtIme.Text, txtPrezime.Text);
        }

        private void UcitajGenerisanePodatke()
        {
            txtBrojIndeksa.Text = Generator.GenerisiBrojIndeksa();
            txtLozinka.Text = Generator.GenerisiLozinku();
        }

        private void UcitajDrzave()
        {
            cmbDrzave.UcitajPodatke(db.Drzave.ToList());

            //cmbDrzave.UcitajPodatke(InMemoryDB.Drzave);

            //cmbSpol.DataSource = InMemoryDB.Drzave;
            //cmbSpol.DisplayMember = "Naziv";
            //cmbSpol.ValueMember = "Id";
        }

        private void UcitajSpolove()
        {
            cmbSpol.UcitajPodatke(InMemoryDB.Spolovi);

            //cmbSpol.DataSource = InMemoryDB.Spolovi;
            //cmbSpol.DisplayMember = "Naziv";
            //cmbSpol.ValueMember = "Id";
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void cmbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drzava = cmbDrzave.SelectedItem as Drzava;
            //var gradovi = InMemoryDB.Gradovi.Where(x => x.DrzavaId == drzava.Id).ToList();
            var gradovi = db.Gradovi.Where(x => x.DrzavaId == drzava.Id).ToList();
            cmbGradovi.UcitajPodatke(gradovi);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            tcUnosPodataka.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tcUnosPodataka.SelectedIndex = 2;
        }
    }
    public class Generator
    {
        public static string GenerisiEmail(string ime, string prezime)
        {
            return $"{ime.ToLower()}.{prezime.ToLower()}@{Resursi.Get(Kljucevi.Domain)}";
        }

        public static string GenerisiBrojIndeksa()
        {
            return $"IB{(DateTime.Now.Year - 2000) * 10000 + InMemoryDB.Studenti.Count + 1}";
        }

        internal static string GenerisiLozinku(int brojZnakova = 15)
        {
            string znakovi = "ABCDEFGHIJKLMNOPQRSTUVWXYZ*!-+/!$#%&()abcdefghijklmnopqrstuvwxyz0123456789";
            string loznika = "";//Gh0W3rT5
            Random random = new Random();
            for (int i = 0; i < brojZnakova; i++)
            {
                var narednlaLokacija = random.Next(0, znakovi.Length);//32
                loznika += znakovi[narednlaLokacija];
            }
            return loznika;
        }
    }
}
