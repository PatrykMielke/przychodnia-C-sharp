using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp
{
    public partial class Lekarze : Form
    {
        public Lekarze()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lekarze_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(), dataGridView1);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

            Biblioteka obj = new Biblioteka();
            obj.OdpowiadajacaNazwaTabeli = this.Text;
            obj.BazaDodaj(this, dataGridView1);
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(), dataGridView1);

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

            Biblioteka obj = new Biblioteka();
            obj.OdpowiadajacaNazwaTabeli = this.Text;
            obj.BazaEdytuj(this, dataGridView1);
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(), dataGridView1);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

            Biblioteka obj = new Biblioteka();
            obj.OdpowiadajacaNazwaTabeli = this.Text;
            obj.BazaUsun(this, dataGridView1);

            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(), dataGridView1);

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Biblioteka.sprawdzanie(dataGridView1)) return;

            Specjalizacje_lekarzy specjalizacje = new Specjalizacje_lekarzy(dataGridView1.SelectedRows[0]);
            specjalizacje.ShowDialog();

            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(), dataGridView1);

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Biblioteka.eventZmianaZaznaczenia(this, dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!Biblioteka.sprawdzanie(dataGridView1)) return;

            Godziny_pracy godziny_pracy = new Godziny_pracy(dataGridView1.SelectedRows[0]);
            godziny_pracy.ShowDialog();

            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(), dataGridView1);

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
    }
}
