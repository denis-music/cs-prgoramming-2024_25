namespace DLWMS.Data
{
    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return Naziv;
        }

        public ICollection<Student> Studenti { get; set; } = new HashSet<Student>();

    }
}