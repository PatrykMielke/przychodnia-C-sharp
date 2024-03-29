using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class Specjalizacje_lekarzy : Form
    {
        public Specjalizacje_lekarzy(DataGridViewRow row)
        {
            InitializeComponent();

            for (int i = 0; i < row.Cells.Count - 1; i++)
            {
                labelNazwaLekarza.Text += $"{row.Cells[i].Value} ";
            }
            checkBox1.Text = (string)row.Cells[0].Value;
        }

        private void Specjalizacje_lekarzy_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            var reader = obj.BazaSelect(checkBox1.Text);
            Biblioteka.GridView(reader, dataGridView1);

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            obj = new Biblioteka();
            obj.ZapytanieSelect = "Specjalizacje";
            reader = obj.BazaSelect();

            List<string> list = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                list.Add((string)row.Cells[1].Value);
            }
            Biblioteka.comboBoxWyswietl(reader, comboBox1, list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

            Biblioteka obj = new Biblioteka();
            obj.OdpowiadajacaNazwaTabeli = this.Text;
            obj.BazaDodaj(this, dataGridView1);

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

            Biblioteka obj = new Biblioteka();
            obj.OdpowiadajacaNazwaTabeli = this.Text;
            obj.BazaUsun(this, dataGridView1);

            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(checkBox1.Text), dataGridView1);

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Biblioteka.eventZmianaZaznaczenia(this, dataGridView1);
        }
    }
}
