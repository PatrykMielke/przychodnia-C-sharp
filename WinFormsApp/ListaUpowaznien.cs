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
    public partial class ListaUpowaznien : Form
    {
        public ListaUpowaznien(DataGridViewRow row)
        {
            InitializeComponent();
            for (int i = 1; i < 4; i++)
            {
                label1.Text += $"{(string)row.Cells[i].Value} ";
            }
            checkBox1.Text = (string)row.Cells[0].Value;
        }

        private void ListaUpowaznien_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            var reader = obj.BazaSelect(checkBox1.Text);
            Biblioteka.GridView(reader, dataGridView1);

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Biblioteka.eventZmianaZaznaczenia(this, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

            ListaUpowaznienDodaj listaUpowaznienDodaj = new ListaUpowaznienDodaj(Biblioteka.listaUprawnionychNaChwileObecna(dataGridView1), checkBox1.Text);
            listaUpowaznienDodaj.Text = Biblioteka.nazwaFormatkiUpowaznienia(this);
            listaUpowaznienDodaj.ShowDialog();

            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(checkBox1.Text), dataGridView1);

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

            Biblioteka obj = new Biblioteka();
            obj.OdpowiadajacaNazwaTabeli = this.Text;
            obj.BazaUsun(this, dataGridView1);

            obj.ZapytanieSelect = this.Text;
            var reader = obj.BazaSelect(checkBox1.Text);
            Biblioteka.GridView(reader, dataGridView1);

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
    }
}
