using DLWMS.Data;
using DLWMS.Infrastructure;

namespace DLWMS.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OsobaServis osobeServis = new OsobaServis();
            List<Osoba> osobe = osobeServis.GetOsobeByOpstina("Mostar");
            //Console.WriteLine($"Broj osoba -> {osobe.Count}");
            MessageBox.Show($"Broj osoba -> {osobe.Count}");

        }
    }
}
