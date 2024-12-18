using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;

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
    public partial class frmStudentiUplate : Form
    {
        DLWMSContext db = new DLWMSContext();
        Student student;
        public frmStudentiUplate(int studentId)
        {
            InitializeComponent();
            student = db.Studenti.Find(studentId);
            dgvUplate.AutoGenerateColumns = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmStudentiUplate_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPodatke();
                UcitajUplate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void UcitajUplate()
        {
            dgvUplate.DataSource = null;
            dgvUplate.DataSource = 
                db.StudentiUplate.Where(x => x.Student.Id == student.Id).ToList();

        }

        private void UcitajPodatke()
        {
            cmbAkademskaGodina.UcitajPodatke(db.AkademskeGodine.ToList());
            cmbVrstaUplate.UcitajPodatke(db.VrsteUplata.ToList());


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {

                var uplata = new StudentUplata
                {
                    AkademskaGodinaId = (cmbAkademskaGodina.SelectedItem as AkademskaGodina).Id,
                    DatumUplate = dtpDatumUplate.Value,
                    GodinaStudija = int.Parse(cmbGodinaStudija.Text),
                    Iznos = decimal.Parse(txtIznos.Text),
                    Napomena = txtNapomena.Text,
                    StudentId = student.Id,
                    VrstaUplateId = (cmbVrstaUplate.SelectedItem as VrstaUplate).Id,
                };
                db.StudentiUplate.Add(uplata);
                db.SaveChanges();
                UcitajUplate();

            }
        }
        private bool ValidanUnos()
        {
            return
            Validator.ProvjeriUnos(cmbAkademskaGodina, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(cmbGodinaStudija, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(cmbVrstaUplate, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(txtIznos, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(txtNapomena, err, Resursi.Get(Kljucevi.RequiredField)) ;
        }
    }
}
