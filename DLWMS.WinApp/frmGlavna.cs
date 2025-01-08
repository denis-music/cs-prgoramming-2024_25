using DLWMS.WinApp.Asinhorno;
using DLWMS.WinApp.Studenti;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pretragaStudenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmStudentiPretraga());
        }

        private void xOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmXO());
        }
        private void PrikaziFormu(Form forma)
        {
            forma.MdiParent = this;
            forma.Show();
        }

        private void noviStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmStudentAddEdit());
        }

        private void ažuriranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmOProgramu());
        }

        private void provjeraDostupnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmAsinhrono());
        }
    }
}
