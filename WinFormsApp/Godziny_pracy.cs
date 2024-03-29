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

namespace WinFormsApp
{
    public partial class Godziny_pracy : Form
    {
        public Godziny_pracy(DataGridViewRow row)
        {
            InitializeComponent();

            for (int i = 1; i < 4; i++)
            {
                label1.Text += $"{(string)row.Cells[i].Value} ";
            }
            checkBox1.Text = (string)row.Cells[0].Value;

        }

        private void Godziny_pracy_Load(object sender, EventArgs e)
        {
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = this.Text;
            var reader = obj.BazaSelect(checkBox1.Text);
            Biblioteka.GridView(reader, dataGridView1, 2);

            
            //combobox gabinetów
            obj = new Biblioteka();
            obj.ZapytanieSelect = "Gabinety";
            Biblioteka.comboBoxWyswietl(obj.BazaSelect(), comboBoxGabinet);

            GodzinyPracyComboBox();
            //comboboxy godzin
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Biblioteka obj = new Biblioteka();
            obj.OdpowiadajacaNazwaTabeli = this.Text;
            obj.BazaDodaj(this, dataGridView1);

            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(checkBox1.Text), dataGridView1, 2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Biblioteka obj = new Biblioteka();
            obj.OdpowiadajacaNazwaTabeli = this.Text;
            obj.BazaUsun(this, dataGridView1);

            obj.ZapytanieSelect = this.Text;
            Biblioteka.GridView(obj.BazaSelect(checkBox1.Text), dataGridView1, 2);
        }
        private void GodzinyPracyComboBox()
        {
            for (int i = 0; i < 24; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = $"{i}:00";
                item.Value = $"{i}:00";
                comboBoxPoczatek.Items.Add(item);
                comboBoxKoniec.Items.Add(item);
            }
            comboBoxPoczatek.SelectedIndex = 0;
            comboBoxKoniec.SelectedIndex = 0;
            comboBoxGabinet.SelectedIndex = 0;
        }

    }
}
