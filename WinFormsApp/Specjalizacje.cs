using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Specjalizacje : Form
    {
        public Specjalizacje()
        {
            InitializeComponent();
        }

        private void Typy_wizyt_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            SqlDataReader reader = obj.BazaSelect();
            Biblioteka.GridView(reader, dataGridView1);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Biblioteka.eventZmianaZaznaczenia(this, dataGridView1);
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
    }
}
