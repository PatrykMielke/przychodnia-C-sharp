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
using Microsoft.Data.SqlClient;

namespace WinFormsApp
{
    public partial class ListaUpowaznienDodaj : Form
    {
        public ListaUpowaznienDodaj(List<string> list, string idWybranegoPacjenta)
        {
            InitializeComponent();

            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = "Pacjenci";
            Biblioteka.GridView(obj.BazaSelect(), dataGridView1);

            wyswietlanie(list, idWybranegoPacjenta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Biblioteka.sprawdzanie(dataGridView1) == false) return;

            Biblioteka obj = new Biblioteka();
            obj.OdpowiadajacaNazwaTabeli = this.Text;
            obj.BazaDodaj(this, dataGridView1);

            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Biblioteka.eventZmianaZaznaczeniaUprawnienia(this, dataGridView1);
        }
        private void wyswietlanie(List<string> list, string idWybranegoPacjenta)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (row.Cells[0].Value.ToString() == list[i])
                    {
                        row.Visible = false;
                        break;
                    }
                }
            }
            checkBox1.Text = idWybranegoPacjenta;
        }
    }
}
