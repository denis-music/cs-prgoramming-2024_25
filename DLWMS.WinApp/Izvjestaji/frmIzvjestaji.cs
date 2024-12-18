using DLWMS.WinApp.Studenti;

using Microsoft.Reporting.WinForms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private dtoPolozeniPredmetPrint dto;
        
        public frmIzvjestaji(dtoPolozeniPredmetPrint dto)
        {
            InitializeComponent();
            this.dto = dto;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

            var parametri = new ReportParameterCollection();            
            parametri.Add(new ReportParameter("pImePrezime", $"{dto.Student.Ime} {dto.Student.Prezime}"));
            parametri.Add(new ReportParameter("pIndeks", dto.Student.BrojIndeksa));
            parametri.Add(new ReportParameter("pSlika", Convert.ToBase64String(dto.Student.Slika)));
            parametri.Add(new ReportParameter("pAkademskaGodina", "2023/24"));
            parametri.Add(new ReportParameter("pGodinaStudija", "1"));
            parametri.Add(new ReportParameter("pStatus", "Redovan"));
            parametri.Add(new ReportParameter("pOdgovornaOsoba", "prof.dr Nina Bijedić"));

            var tblPolozeni = new dsDLWMS.PolozeniPredmetiDataTable();
            for (int i = 0; i < dto.Polozeni.Count; i++)
            {
                var polozeni = dto.Polozeni[i];
                var red = tblPolozeni.NewPolozeniPredmetiRow();
                red.Rb = (i + 1).ToString();
                red.Naziv = polozeni.Predmet.Naziv;
                red.Ocjena = polozeni.Ocjena.ToString();
                red.Datum = polozeni.DatumPolaganja.ToString("dd.MM.yyyy");
                red.ECTS = polozeni.Predmet.ECTS.ToString();
                
                tblPolozeni.AddPolozeniPredmetiRow(red);
            }

            var dsPolozeni = new ReportDataSource();
            dsPolozeni.Name = "dsPolozeni";
            dsPolozeni.Value = tblPolozeni;


            reportViewer1.LocalReport.DataSources.Add(dsPolozeni);
            reportViewer1.LocalReport.SetParameters(parametri);
            reportViewer1.RefreshReport(); 

        }
    }
}
