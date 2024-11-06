using DLWMS.Data;

namespace DLWMS.Infrastructure
{
    public class InMemoryDB
    {
        public static List<Korisnik> Korisnici { get; set; } = GenerisKorisnike();

        private static List<Korisnik> GenerisKorisnike()
        {
            return new List<Korisnik>
            {
                new Korisnik() { Id = 1, Ime = "John", Prezime = "Doe", Email = "john.doe@fit.ba", Aktivan = true, KorisnickoIme = "johndoe", Lozinka = "johndoe" },
                new Korisnik() { Id = 2, Ime = "Denis", Prezime = "Music", Email = "denis.music@fit.ba", Aktivan = true, KorisnickoIme = "denis", Lozinka = "denis" },
                new Korisnik() { Id = 3, Ime = "Jasmin", Prezime = "Azemovic", Email = "jasmin.azemovic@fit.ba", Aktivan = true, KorisnickoIme = "jasmin", Lozinka = "jasmin" },
            };
        }
    }
}
