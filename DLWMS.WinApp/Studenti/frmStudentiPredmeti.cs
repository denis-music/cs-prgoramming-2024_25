using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.Izvjestaji;

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
    public partial class frmStudentiPredmeti : Form
    {

        private Student student;
        DLWMSContext db = new DLWMSContext();

        public frmStudentiPredmeti(int studentId)
        {
            InitializeComponent();
            dgvPolozeni.AutoGenerateColumns = false;
            this.student = db.Studenti.Find(studentId);
        }

        private void frmStudentiPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPolozenePredmete();
            UcitajPodatkeOStudentu();
            UcitajPredmete();
        }

        private void UcitajPodatkeOStudentu()
        {
            pbSlika.Image = student.Slika.ToImage();
            lblImePrezime.Text = student.Ime + " " + student.Prezime;
            lblIndeks.Text = student.BrojIndeksa;
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.UcitajPodatke(db.Predmeti.ToList());
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeni.DataSource = null;
            dgvPolozeni.DataSource = db.StudentiPredmeti.Include(x=>x.Predmet).Where(sp=>sp.StudentId == student.Id).ToList();
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {

                var predmet = cmbPredmeti.SelectedItem as Predmet;
                var polozeni = new StudentPredmet
                {                   
                    StudentId = student.Id,
                    Student = student,
                    PredmetId = predmet.Id,
                    Predmet = predmet,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    DatumPolaganja = dtpDatumPolaganja.Value,
                    Napomena = txtNapomena.Text
                };
                //student.Polozeni.Add(polozeni);
                db.StudentiPredmeti.Add(polozeni);  
                db.SaveChanges();
                UcitajPolozenePredmete();
            }
        }
        private bool ValidanUnos()
        {
            return
            Validator.ProvjeriUnos(cmbPredmeti, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(cmbOcjene, err, Resursi.Get(Kljucevi.RequiredField));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var dto = new dtoPolozeniPredmetPrint
            {
                Student = student,
                Polozeni = dgvPolozeni.DataSource as List<StudentPredmet>
            };
            var frmIzvjezstaji = new frmIzvjestaji(dto);
            frmIzvjezstaji.ShowDialog();

        }
    }

    public class dtoPolozeniPredmetPrint
    {
        public Student Student { get; set; }
        public List<StudentPredmet> Polozeni { get; set; }

    }
}
