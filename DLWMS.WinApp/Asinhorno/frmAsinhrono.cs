using ClosedXML.Excel;

using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Izvjestaji;
using DLWMS.WinApp.Studenti;

using Microsoft.EntityFrameworkCore.Metadata;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static DLWMS.WinApp.Izvjestaji.dsDLWMS;

namespace DLWMS.WinApp.Asinhorno
{
    public partial class frmAsinhrono : Form
    {
        public frmAsinhrono()
        {
            InitializeComponent();
        }

        private async Task<string> PingBugHr()
        {
            await Task.Run(() => ProvjeriDostupnost(new dtoPing() { Adresa = "www.bug.hr", BrojPonavljanja = 10, Pauza = 200 }));
            return "Bug.hr OK";
        }

        private async void btnPing_Click(object sender, EventArgs e)
        {
            try
            {
                var adresa = cmbAdrese.Text;
                var brojPonavljanja = int.Parse(cmbBrojPonavljanja.Text);
                var pauza = int.Parse(cmbPauza.Text);

                await Task.Run(() => ProvjeriDostupnost(new dtoPing() { Adresa = adresa, BrojPonavljanja = brojPonavljanja, Pauza = pauza }));

                var poruka = await PingBugHr();                
                Sadrzaj+=poruka;                
            }
            catch (Exception ex)
            {
                txtIspis.Text += ex.Message;
            }
        }

        public int Brojac { get; set; }
        public string Sadrzaj { get; set; }
        private void ProvjeriDostupnost(dtoPing dtoPing)
        {
            var ping = new Ping();
            for (int i = 0; i < dtoPing.BrojPonavljanja; i++)
            {
                var odgovor = ping.Send(dtoPing.Adresa);
                BeginInvoke(() => DodajOdgovor(odgovor));
                Thread.Sleep(dtoPing.Pauza);
            }
        }
        private void DodajOdgovor(PingReply odgovor)
        {
            Sadrzaj += $"{Brojac++} ->\t{odgovor.Address}\t\t{odgovor.Status}\t\t{odgovor.RoundtripTime}{Environment.NewLine}";
            PrikaziSadrzaj();
        }

        private void PrikaziSadrzaj()
        {
            txtIspis.Text = Sadrzaj;
            txtIspis.SelectionStart = txtIspis.Text.Length;
            txtIspis.ScrollToCaret();
        }

        private void frmAsinhrono_Load(object sender, EventArgs e)
        {
            cmbAdrese.SelectedIndex = cmbBrojPonavljanja.SelectedIndex = 0;
            cmbPauza.SelectedIndex = 1;
        }

       


        private void btnUcitajStudente_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel files|*.xlsx";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    Thread studenti = new Thread(()=>DodajStudnete(dialog.FileName));
                    studenti.Start();
                }
            }
            catch (Exception ex)
            {
                txtIspis.Text += ex.Message;               
            }
        }
        DLWMSContext db = new DLWMSContext();
        private void DodajStudnete(string fileName)
        {
            var podaciIzExcela = UcitajPodatkeIzExcelFajla(fileName);
            var slika = db.Studenti.Find(1).Slika;

            foreach (var student in podaciIzExcela)
            {
                var noviStudent = new Student()
                {
                    BrojIndeksa = student.Indeks,
                    Ime = student.Ime,
                    Prezime = student.Prezime,
                    Email = student.Email,
                    Aktivan = true,
                    DatumRodjenja = DateTime.Now,
                    GradId = 1,
                    Lozinka = Generator.GenerisiLozinku(),
                    SpolId =1,
                    Slika = slika
                };
                db.Studenti.Add(noviStudent);
                Sadrzaj += $"Dodan student -> {noviStudent.BrojIndeksa} {noviStudent.Ime} {noviStudent.Prezime}{Environment.NewLine}";
                Thread.Sleep(200);
                db.SaveChanges();
            }
        }

        private StudentiDataTable UcitajPodatkeIzExcelFajla(string fileName)
        {
            var tblStudenti = new dsDLWMS.StudentiDataTable();
            
            var excelFajl = new XLWorkbook(fileName);
            var sheetStudenti = excelFajl.Worksheet(1);

            foreach (var red in sheetStudenti.RowsUsed())
            {
                var redStudent = tblStudenti.NewStudentiRow();
                
                redStudent.Indeks= red.Cell(1).GetString();
                redStudent.Ime = red.Cell(2).GetString();
                redStudent.Prezime = red.Cell(3).GetString();
                redStudent.Email = red.Cell(4).GetString();
                tblStudenti.AddStudentiRow(redStudent);
            }
            return tblStudenti;
        }
    }

    public class dtoPing
    {
        public string Adresa { get; set; }
        public int BrojPonavljanja { get; set; }
        public int Pauza { get; set; }
    }

}
