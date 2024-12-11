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

namespace DLWMS.WinApp.Edukatori
{
    public partial class frmPredmeti : Form
    {

        DLWMSContext db = new DLWMSContext();

        public frmPredmeti()
        {
            InitializeComponent();
            dgvPredmeti.AutoGenerateColumns = false;
        }

        private void frmPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
        }
        private int OdabraniRed { get; set; }

        private void UcitajPredmete()
        {
            dgvPredmeti.DataSource = null;
            dgvPredmeti.DataSource = db.Predmeti.ToList();

            dgvPredmeti.ClearSelection();
            dgvPredmeti.Rows[OdabraniRed].Selected = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {

                var noviPredmet = new Predmet()
                {
                    Aktivan = cbAktivan.Checked,
                    ECTS = int.Parse(txtEcts.Text),
                    Naziv = txtNaziv.Text,
                    Semestar = int.Parse(cmbSemestri.Text)
                };
                db.Predmeti.Add(noviPredmet);
                //InMemoryDB.Predmeti.Add(noviPredmet);
                db.SaveChanges();
                UcitajPredmete();
            }
        }

        private bool ValidanUnos()
        {
            return
                    Validator.ProvjeriUnos(txtNaziv, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(txtEcts, err, Resursi.Get(Kljucevi.RequiredField)) &&
                    Validator.ProvjeriUnos(cmbSemestri, err, Resursi.Get(Kljucevi.RequiredField));
        }

        private void dgvPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniPredmet = dgvPredmeti.SelectedRows[0].DataBoundItem as Predmet;
            OdabraniRed = e.RowIndex;

            odabraniPredmet.Aktivan = !odabraniPredmet.Aktivan;
            db.Update(odabraniPredmet);
            db.SaveChanges();
            UcitajPredmete();
        }
    }
}
