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
using ClassLibrary1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class Dodaj_czynność : Form
    {
        public List<DateTime> wolneTerminy = new List<DateTime>();
        private bool CzyUpdate { get; set; }
        private DataGridView dataGridView { get;set;}
        public Dodaj_czynność(DataGridView dataGridView = null, bool update = false)
        {
            InitializeComponent();
            CzyUpdate = update;
            this.dataGridView = dataGridView;
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = "Specjalizacje";
            Biblioteka.comboBoxWyswietl(obj.BazaSelect(), comboBoxSpecjalizacje);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            // BUTTON DODAJ 

            if (checkBox1.Text == "" || checkBox2.Text == "" || (comboBoxLekarz.SelectedItem as ComboBoxItem).Value == null || checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Wybierz wszystkie opcje"); return;
            }
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = "Poczatek Czynnosci";

            List<string> parametry = new List<string>
            {
                checkBox1.Text,
                (comboBoxLekarz.SelectedItem as ComboBoxItem).Value.ToString(),
                (comboBoxSpecjalizacje.SelectedItem as ComboBoxItem).Value.ToString(),
                checkBox2.Text,
                dateTimePicker1.Value.ToShortDateString(),
                checkedListBox1.CheckedItems[0].ToString()
            };
            obj = new Biblioteka();
            obj.OdpowiadajacaNazwaTabeli = "Czynnosci";
            if(CzyUpdate == true)
            {
                obj.EdytujWizyte(parametry,dataGridView);
            }
            else
            {
                obj.DodajWizyte(parametry);
            }
            Close();
        }
        // BUTTON SPRAWDZANIE GODZIN PRACY I CHECKBOX
        private void button3_Click(object sender, EventArgs e)
        {
            //pokaz terminy
            if (comboBoxSpecjalizacje.SelectedIndex < 0) return;
            if (comboBoxLekarz.SelectedIndex < 0) return;

            // Zwraca godziny pracy lekarza
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = "CzynnoscGodzinyPracy";
            var reader1 = obj.BazaSelect((comboBoxLekarz.SelectedItem as ComboBoxItem).Value.ToString(), dateTimePicker1.Value.ToShortDateString());

            // Zwraca godziny czynności danego dnia dla danego lekarza
            Biblioteka obj2 = new Biblioteka();
            obj2.ZapytanieSelect = "Poczatek Czynnosci";
            var reader2 = obj2.BazaSelect((comboBoxLekarz.SelectedItem as ComboBoxItem).Value.ToString(), dateTimePicker1.Value.ToShortDateString());

            // Self-explanatory
            Biblioteka.pokazCheckedBoxList(reader1, checkedListBox1, reader2, checkBox2);
        }
        private void comboBoxSpecjalizacje_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.SelectedItem = -1;
            checkedListBox1.Enabled = false;
            checkedListBox1.Items.Clear();

            comboBoxLekarz.Items.Clear();
            comboBoxLekarz.SelectedIndex = -1;

            comboBoxLekarz.Text = null;

            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = "KtoMaSpecjalizacje";
            Biblioteka.comboBoxWyswietl(obj.BazaSelect((comboBoxSpecjalizacje.SelectedItem as ComboBoxItem).Value.ToString()), comboBoxLekarz);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            checkedListBox1.SelectedItem = -1;
            checkedListBox1.Enabled = false;
        }
        private void comboBoxLekarz_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.SelectedItem = -1;
            checkedListBox1.Enabled = false;
            checkBox2.Text = "";
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            checkedListBox1.SetItemChecked(index, true);
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
            checkedListBox1.SetItemChecked(index, true);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CzynnoscPacjent czynnoscPacjent = new CzynnoscPacjent(this);
            czynnoscPacjent.ShowDialog();
        }
    }
}
