using ClassLibrary1;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortDateString();
            label4.Text = DateTime.Now.AddDays(1).ToShortDateString();
            label5.Text = DateTime.Now.AddDays(2).ToShortDateString();

            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(label3.Text), dataGridView1, 8);

        }
        private void btnTypyWizyt_Click(object sender, EventArgs e)
        {
            Specjalizacje typy_Wizyt = new Specjalizacje();
            typy_Wizyt.ShowDialog();
        }

        private void btnListaLekarzy_Click(object sender, EventArgs e)
        {
            Lekarze lekarze = new Lekarze();
            lekarze.ShowDialog();
        }

        private void btnListaPacjentow_Click(object sender, EventArgs e)
        {
            Pacjenci pacjenci = new Pacjenci();
            pacjenci.ShowDialog();
        }

        private void btnGabinety_Click(object sender, EventArgs e)
        {
            Gabinety gabinet = new Gabinety();
            gabinet.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(label3.Text), dataGridView1, 8);
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(label4.Text), dataGridView1, 8);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(label5.Text), dataGridView1, 8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dodaj_czynnoœæ formDodaj = new Dodaj_czynnoœæ();
            formDodaj.Text = "Dodaj czynnoœæ";
            formDodaj.ShowDialog();
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(label3.Text), dataGridView1, 8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Biblioteka.sprawdzanie(dataGridView1)) return;
            bool update = true;
            Dodaj_czynnoœæ formDodaj = new Dodaj_czynnoœæ(dataGridView1,update);
            formDodaj.Text = "Edytuj czynnoœæ";
            
            formDodaj.ShowDialog();
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(label3.Text), dataGridView1, 8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Biblioteka.sprawdzanie(dataGridView1)) return;
            Biblioteka obj = new Biblioteka();
            obj.OdpowiadajacaNazwaTabeli = "Czynnosci";
            obj.BazaUsun(this,dataGridView1);

            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(label3.Text), dataGridView1, 8);
        }
    }
}