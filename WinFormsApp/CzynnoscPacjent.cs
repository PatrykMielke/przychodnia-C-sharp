using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
namespace WinFormsApp
{
    public partial class CzynnoscPacjent : Form
    {
        private Dodaj_czynność dodajCzynnosc;
        public CzynnoscPacjent(Dodaj_czynność czynnosc)
        {
            InitializeComponent();
            dodajCzynnosc = czynnosc;
        }
        private void CzynnoscPacjent_Load(object sender, EventArgs e)
        {
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(), dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!Biblioteka.sprawdzanie(dataGridView1)) return;

            string pacjent = $"{dataGridView1.SelectedRows[0].Cells[1].Value} {dataGridView1.SelectedRows[0].Cells[2].Value} {dataGridView1.SelectedRows[0].Cells[3].Value}";
            dodajCzynnosc.textBox1.Text = pacjent;
            dodajCzynnosc.checkBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Close();

    }
    }
}
