using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DLWMS.WinApp
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            var korisnickoIme = txtKorisnickoIme.Text;
            var lozinka = txtLozinka.Text;
            if (ValidanUnos())
            {
                foreach (var korisnik in InMemoryDB.Korisnici)
                {
                    if (korisnik.KorisnickoIme == korisnickoIme && korisnik.Lozinka == lozinka)
                    {
                        if (korisnik.Aktivan)
                        {
                            Hide();
                            if (new frmGlavna().ShowDialog() == DialogResult.OK)
                                Show();
                            else
                                Close();
                        }
                        else
                            MessageBox.Show(Resursi.Get(Kljucevi.NotActive));
                        return;
                    }
                }
                MessageBox.Show(Resursi.Get(Kljucevi.UsernameOrPasswordNotValid),
                    Resursi.Get(Kljucevi.Warning),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(txtKorisnickoIme, err, Resursi.Get(Kljucevi.RequiredField)) &&
                Validator.ProvjeriUnos(txtLozinka, err, Resursi.Get(Kljucevi.RequiredField));
        }

        private void llblRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registracija = new frmRegistracija();
            registracija.Show();  
        }
    }
    public class Kljucevi
    {
        public const string NotActive = "NotActive";
        public const string UsernameOrPasswordNotValid = "UsernameOrPasswordNotValid";
        public const string Warning = "Warning";
        public const string Domain = "Domain";
        public const string RequiredField= "RequiredField";
        public const string UserAddSuccess = "UserAddSuccess";
        public const string Information = "Information";

        


    }

    public class Resursi
    {
        static ResourceManager Manager = new ResourceManager("DLWMS.WinApp.Resource1",
                                                    typeof(frmPrijava).Assembly);
        public static string Get(string key)
        {
            return Manager.GetString(key);
        }
    }

    public class Validator
    {
        public static bool ProvjeriUnos(TextBox textBox, ErrorProvider err, string poruka)
        {
            if (!textBox.Text.IsSet())
            {
                err.SetError(textBox, poruka);
                return false;
            }
            err.Clear();
            return true;
        }
    }

    public static class Ekstenzije
    {
        public static bool IsSet(this string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }
    }
    public class InMemoryDB
    {
        public static List<Korisnik> Korisnici { get; set; } = GenerisKorisnike();

        private static List<Korisnik> GenerisKorisnike()
        {
            return new List<Korisnik>
            {
                new Korisnik() { Id = 1, Ime = "John", Prezime = "Doe", Email = "john.doe@fit.ba", Aktivan = true, KorisnickoIme = "johndoe", Lozinka = "johndoe" },
                new Korisnik() { Id = 2, Ime = "Denis", Prezime = "Music", Email = "denis.music@fit.ba", Aktivan = false, KorisnickoIme = "denis", Lozinka = "denis" },
                new Korisnik() { Id = 3, Ime = "Jasmin", Prezime = "Azemovic", Email = "jasmin.azemovic@fit.ba", Aktivan = true, KorisnickoIme = "jasmin", Lozinka = "jasmin" },
            };
        }
    }

    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }
    }
}
