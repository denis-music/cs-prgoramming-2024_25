namespace DLWMS.Data
{
    public class Student : Osoba
    {
        public string BrojIndeksa { get; set; }

        public Student(string brojIndeksa, string imePrezime, string spol, 
            DateTime datumRodjenja, int? gradId = null)
            : base(imePrezime, spol, datumRodjenja, gradId)
        { 
            BrojIndeksa = brojIndeksa;
        }
        public void PrijaviIspit()
        {

        }       
    }

}
