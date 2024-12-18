using System.Drawing;
using System.Security.Principal;

namespace DLWMS.Data
{


    public class Student
    {
        public ICollection<Uloga> Uloge { get; set; } = new HashSet<Uloga>();

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public int GradId { get; set; }
        public int SpolId { get; set; }
        public byte[] Slika { get; set; }//bio tip podatka Image
        public bool Aktivan { get; set; }
        public List<StudentPredmet> Polozeni { get; set; }
        public Student()
        {
            Polozeni = new List<StudentPredmet>();
        }
    }
}