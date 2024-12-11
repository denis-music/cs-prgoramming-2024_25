using System.Drawing;

namespace DLWMS.Data
{
    public class Student
    {
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
        public List<PolozeniPredmet> Polozeni { get; set; }
        public Student()
        {
            Polozeni = new List<PolozeniPredmet>();
        }
    }


    public class PolozeniPredmet
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }        
        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; }
    }
}