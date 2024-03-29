using Microsoft.Data.SqlClient;
using System.Reflection.Metadata;
using System;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    // COLLAPSE ALL   CTRL M O 
    public class Biblioteka : ComboBoxItem
    {
        // Bazodanowe
        public SqlDataReader BazaSelect(string parametr = "", string parametr2 = "")
        {
            SqlConnection conn = new SqlConnection(konfiguracja);
            SqlCommand command = new SqlCommand(this.ZapytanieSelect, conn);

            if (parametr != "")
            {
                command.Parameters.AddWithValue("@parametr", parametr);
            }
            if (parametr2 != "")
            {
                command.Parameters.AddWithValue("@parametr2", parametr2);
            }

            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public void BazaDodaj(Form form, DataGridView dataGridView)
        {
            if (QoF_SprawdzanieWypelnieniaPol((Control)form) == 0) return;

            string listaKolumn = nazwyKolumn();
            string insertWartosci = funkcjaParametryInsert(form);

            SqlConnection conn = new SqlConnection(konfiguracja);
            SqlCommand cmd = new SqlCommand($"Insert into {this.OdpowiadajacaNazwaTabeli} ({listaKolumn}) Values ({insertWartosci})", conn);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Dispose();
            wyczyszczenieZaznaczenia(form);
            MessageBox.Show("Dodano");
        }
        public void BazaEdytuj(Form form, DataGridView dataGridView)
        {
            if (!Biblioteka.sprawdzanie(dataGridView)) return;

            string id = nazwyKolumn(0);

            string[] nazwaKolumny = nazwyKolumn().Split(',');
            string[] parametry = funkcjaParametryUpdate(form).Split(',');

            string wyrazenie = "";

            for (int i = 0; i < nazwaKolumny.Length; i++)
            {
                wyrazenie += $"{nazwaKolumny[i]} = {parametry[i]},";
            }
            wyrazenie = wyrazenie.Remove(wyrazenie.Length - 1);

            SqlConnection conn = new SqlConnection(konfiguracja);
            SqlCommand cmd = new SqlCommand($"update {this.OdpowiadajacaNazwaTabeli} set {wyrazenie} where {id} = {dataGridView.SelectedRows[0].Cells[0].Value}", conn);

            conn.Open(); cmd.ExecuteNonQuery(); conn.Dispose();
            wyczyszczenieZaznaczenia(form);
        }
        public void BazaUsun(Form form, DataGridView dataGridView)
        {
            if (!Biblioteka.sprawdzanie(dataGridView)) return;
            if (MessageBox.Show("Czy na pewno chcesz usunąć?", "Usuwanie", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string idTabeli = nazwyKolumn(0);
            string idDataGrid = (string)dataGridView.SelectedRows[0].Cells[0].Value;

            SqlConnection conn = new SqlConnection(konfiguracja);
            SqlCommand cmd = new SqlCommand($"DELETE FROM {this.OdpowiadajacaNazwaTabeli} WHERE {idTabeli} = {idDataGrid}", conn);

            conn.Open(); cmd.ExecuteNonQuery(); conn.Dispose();
            wyczyszczenieZaznaczenia(form);
        }
        private static string funkcjaParametryInsert(Form form)
        {
            List<string> parametryInsert = new List<string>();
            for (int i = 0; i < form.Controls.Count + 1; i++)
            {
                foreach (Control control in form.Controls)
                {
                    if (control.TabIndex > 0 && control.TabIndex < 10)
                    {
                        if (control is System.Windows.Forms.TextBox textbox)
                        {
                            if (textbox.TabIndex == i)
                            {
                                parametryInsert.Add("'" + textbox.Text + "'");
                            }
                        }
                        else if (control is NumericUpDown numericUpDown)
                        {
                            if (numericUpDown.TabIndex == i)
                            {
                                parametryInsert.Add(numericUpDown.Text);
                            }
                        }
                        else if (control is DateTimePicker dateTimePicker)
                        {
                            if (dateTimePicker.TabIndex == i)
                            {
                                parametryInsert.Add("'" + dateTimePicker.Value.ToString("MM.dd.yyyy") + "'");
                            }
                        }
                        else if (control is ComboBox comboBox)
                        {
                            if (comboBox.TabIndex == i)
                            {
                                parametryInsert.Add("'" + (comboBox.SelectedItem as ComboBoxItem).Value.ToString() + "'");
                            }
                        }
                        else if (control is CheckBox checkBox)
                        {
                            if (checkBox.TabIndex == i)
                            {
                                parametryInsert.Add("'" + checkBox.Text + "'");
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            return string.Join(",", parametryInsert);
        }
        private static string funkcjaParametryUpdate(Form form)
        {
            List<string> parametryUpdate = new List<string>();
            for (int i = 0; i < form.Controls.Count + 1; i++)
            {
                foreach (Control control in form.Controls)
                {
                    if (control.TabIndex > 0 && control.TabIndex < 10)
                    {
                        if (control is System.Windows.Forms.TextBox textbox)
                        {
                            if (textbox.TabIndex == i)
                            {
                                parametryUpdate.Add("'" + textbox.Text + "'");
                            }
                        }
                        else if (control is NumericUpDown numericUpDown)
                        {
                            if (numericUpDown.TabIndex == i)
                            {
                                parametryUpdate.Add(numericUpDown.Text);
                            }
                        }
                        else if (control is DateTimePicker dateTimePicker)
                        {
                            if (dateTimePicker.TabIndex == i)
                            {
                                parametryUpdate.Add("'" + dateTimePicker.Value.ToString("MM.dd.yyyy") + "'");
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            return string.Join(",", parametryUpdate);
        }
        public void DodajWizyte(List<string> p)
        {
            SqlConnection conn = new SqlConnection(konfiguracja);
            SqlCommand cmd = new SqlCommand($"Insert into {this.OdpowiadajacaNazwaTabeli} Values ({p[0]},{p[1]},{p[2]},{p[3]},convert(datetime2, '{p[4]}', 105),'{p[5]}')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Dispose();
            MessageBox.Show("Dodano");

        }
        public void EdytujWizyte(List<string> p, DataGridView dataGridView)
        {
            string id = nazwyKolumn(0);

            string[] nazwaKolumny = nazwyKolumn().Split(',');

            string wyrazenie = "";

            for (int i = 0; i < nazwaKolumny.Length; i++)
            {
                if (i==4)
                {
                    wyrazenie += $"{nazwaKolumny[i]} = convert(datetime2, '{p[i]}' ,105),";
                }
                else if (i == 5)
                {
                    wyrazenie += $"{nazwaKolumny[i]} = '{p[i]}',";
                }
                else
                {
                    wyrazenie += $"{nazwaKolumny[i]} = {p[i]},";
                }
                
            }
            wyrazenie = wyrazenie.Remove(wyrazenie.Length - 1);

            SqlConnection conn = new SqlConnection(konfiguracja);
            SqlCommand cmd = new SqlCommand($"update {this.OdpowiadajacaNazwaTabeli} set {wyrazenie} where {id} = {dataGridView.SelectedRows[0].Cells[0].Value}", conn);

            conn.Open(); cmd.ExecuteNonQuery(); conn.Dispose();
        }



        //Wyświetlanie rzeczy
        public static void GridView(SqlDataReader reader, DataGridView dataGridView, int normalnaData = 0)
        {
            dataGridView.Rows.Clear();

            int rowIndex = 0;

            while (reader.Read())
            {
                dataGridView.Rows.Add();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dataGridView.Rows[rowIndex].Cells[i].Value = reader.GetValue(i).ToString();
                }
                rowIndex++;
            }
            reader.Dispose();

            if (normalnaData != 0)
            {
                NormalnaData(dataGridView, normalnaData);
            }

            dataGridView.ClearSelection();
        }
        public static void comboBoxWyswietl(SqlDataReader reader, ComboBox comboBox1, List<string> list)
        {
            while (reader.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Value = Convert.ToInt32(reader.GetValue(0));
                item.Text = reader.GetValue(1).ToString();
                comboBox1.Items.Add(item);
            }
            for (int i = 0; i < list.Count; i++)
            {
                foreach (ComboBoxItem item in comboBox1.Items)
                {
                    if (item.Text == list[i])
                    {
                        comboBox1.Items.Remove(item);
                    }
                }
            }
            if (comboBox1.Items.Count > 0) { comboBox1.SelectedIndex = 0; }
            else { comboBox1.Text = "Brak pozycji do wyświetlenia"; comboBox1.Enabled = false; }
        }
        public static void comboBoxWyswietl(SqlDataReader reader, ComboBox comboBox1)
        {
            while (reader.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Value = Convert.ToInt32(reader.GetValue(0));



                string tekst = "";
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    tekst += reader.GetValue(i).ToString() + " ";
                }
                //item.Text = reader.GetValue(1).ToString();
                item.Text = tekst;
                comboBox1.Items.Add(item);
            }
        }
        private string nazwyKolumn(int index = 1)
        {
            List<string> listaKolumn = new List<string>();

            SqlConnection conn = new SqlConnection(konfiguracja);
            SqlCommand cmd = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @nazwaTabeli", conn);

            cmd.Parameters.AddWithValue("@nazwaTabeli", this.OdpowiadajacaNazwaTabeli);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listaKolumn.Add(reader.GetString(0));
            }
            if (index == 0)
            {
                return listaKolumn[0];
            }
            else
            {
                listaKolumn.RemoveAt(0);
                return string.Join(",", listaKolumn);
            }

        }
        public static int QoF_SprawdzanieWypelnieniaPol(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    if (textBox.Text == "" || textBox.Text == null)
                    {
                        MessageBox.Show("Wypełnij wszystkie pola!");
                        return 0;
                    }
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    if (numericUpDown.Value < 0)
                    {
                        MessageBox.Show("Wypełnij wszystkie pola!");
                        return 0;
                    }

                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    if (dateTimePicker.Value.AddDays(1) < DateTime.Now)
                    {
                        MessageBox.Show("Wybierz odpowiednią datę!");
                        return 0;
                    }
                }
                else
                {
                    continue;
                }
            }
            return 1;
        }
        public static void pokazCheckedBoxList(SqlDataReader readerGodzinyPracy, CheckedListBox clb, SqlDataReader readerListaWizyt, CheckBox checkBox2)
        {
            clb.Items.Clear();
            List<DateTime> zajeteTerminy = new List<DateTime>();
            List<DateTime> zajeteTerminyKoniec = new List<DateTime>();
            List<DateTime> kazdyMozliwyTermin = new List<DateTime>();
            List<DateTime> wolneTerminy = new List<DateTime>();
            List<string> lista_GodzinyPracy = new List<string>();

            //pobiera godzine poczatku 0 i konca zmiany 1
            while (readerGodzinyPracy.Read())
            {
                lista_GodzinyPracy.Add(readerGodzinyPracy.GetString(0));
                lista_GodzinyPracy.Add(readerGodzinyPracy.GetString(1));
                checkBox2.Text = readerGodzinyPracy.GetValue(2).ToString();
            }

            // jeśli pracuje:
            if (lista_GodzinyPracy.Count > 0)
            {
                int poczatek = Int32.Parse(lista_GodzinyPracy[0].Remove(lista_GodzinyPracy[0].Length - 3));
                int koniec = Int32.Parse(lista_GodzinyPracy[1].Remove(lista_GodzinyPracy[1].Length - 3));

                // określa każdy dostępny termin bazując na samych godzinach pracy
                for (int i = poczatek; i < koniec; i += 1)
                {
                    for (int j = 0; j < 60; j += 10)
                    {
                        if (j == 0)
                        {
                            var temp = j.ToString();
                            temp += "0";
                            kazdyMozliwyTermin.Add(DateTime.Parse($"{i}:{temp}"));
                        }
                        else
                        {
                            kazdyMozliwyTermin.Add(DateTime.Parse($"{i}:{j}"));
                        }

                    }
                }


                // pobiera z bazy listę zarezerwowanych już terminów
                while (readerListaWizyt.Read())
                {
                    zajeteTerminy.Add(DateTime.Parse(readerListaWizyt.GetValue(0).ToString()));
                }

                // określa koniec wizyty
                foreach (DateTime dt in zajeteTerminy)
                {
                    zajeteTerminyKoniec.Add(dt.AddMinutes(15));
                }
                // usuwa z listy wszystkich terminów, już zajęte godziny
                for (int i = kazdyMozliwyTermin.Count - 1; i >= 0; i--)
                {
                    for (int j = 0; j < zajeteTerminy.Count; j++)
                    {
                        if (kazdyMozliwyTermin[i].CompareTo(zajeteTerminy[j].AddMinutes(-10)) >= 0 && kazdyMozliwyTermin[i].CompareTo(zajeteTerminyKoniec[j]) <= 0)
                        {
                            kazdyMozliwyTermin.RemoveAt(i);
                            break;
                        }
                    }
                }
                //
                foreach (DateTime dt in kazdyMozliwyTermin)
                {
                    wolneTerminy.Add(dt);
                }

                // wrzuca wolne terminy do clb
                foreach (DateTime dt in wolneTerminy)
                {
                    clb.Items.Add(dt.ToShortTimeString());
                }

                clb.Enabled = true;
            }
            //jeśli nie pracuje
            else
            {
                MessageBox.Show("Ta osoba dzisiaj nie pracuje");
                return;
            }
        }
        
        
        
        //Pierdoły
        public static void eventZmianaZaznaczenia(Form form, DataGridView dataGridView)
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                foreach (Control control in form.Controls)
                {
                    if (control.TabIndex > 0 && control.TabIndex < 10)
                    {
                        if (control is TextBox textbox)
                        {
                            if (textbox.TabIndex == i)
                            {
                                textbox.Text = (string)dataGridView.SelectedRows[0].Cells[i].Value;
                            }
                        }
                        else if (control is NumericUpDown numericUpDown)
                        {
                            if (numericUpDown.TabIndex == i)
                            {
                                numericUpDown.Value = decimal.Parse((string)dataGridView.SelectedRows[0].Cells[i].Value);
                            }
                        }
                        else if (control is DateTimePicker dateTimePicker)
                        {
                            if (dateTimePicker.TabIndex == i)
                            {
                                dateTimePicker.Value = DateTime.Parse(dataGridView.SelectedRows[0].Cells[i].Value.ToString());
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
        public static void eventZmianaZaznaczeniaUprawnienia(Form form, DataGridView dataGridView)
        {
            foreach (Control control in form.Controls)
            {
                if(control is TextBox textbox)
                {
                    textbox.Text = (string)dataGridView.SelectedRows[0].Cells[0].Value;
                }
            }
        }
        public static void wyczyszczenieZaznaczenia(Form form)
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                foreach (Control control in form.Controls)
                {
                    if (control.TabIndex > 0 && control.TabIndex < 10)
                    {
                        if (control is System.Windows.Forms.TextBox textbox)
                        {
                            if (textbox.TabIndex == i)
                            {
                                textbox.Text = "";
                            }
                        }
                        else if (control is NumericUpDown numericUpDown)
                        {
                            if (numericUpDown.TabIndex == i)
                            {
                                numericUpDown.Value = numericUpDown.Minimum;
                            }
                        }
                        else if (control is DateTimePicker dateTimePicker)
                        {
                            if (dateTimePicker.TabIndex == i)
                            {
                                dateTimePicker.Value = DateTime.Now;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
        public static string nazwaFormatkiUpowaznienia(Form form)
        {
            if (form.Text == "Wyświetlanie stanu zdrowia")
            {
                return "Dodaj uprawnienia do stanu zdrowia";
            }
            else
            {
                return "Dodaj uprawnienia do dokumentacji";
            }
        }
        public static List<string> listaUprawnionychNaChwileObecna(DataGridView dataGridView)
        {
            List<string> lista = new List<string>();
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                lista.Add(item.Cells[1].Value.ToString());
            }
            return lista;
        }
        public static bool sprawdzanie(DataGridView dataGridView1)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Wybierz pozycję z listy.");
                return false;
            }
            return true;

        }
        public static void NormalnaData(DataGridView dataGridView1, int index)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string tekst = row.Cells[index].Value.ToString();
                row.Cells[index].Value = tekst.Remove(10);
            }
        }
        private static string konfiguracja = "Data Source = DESKTOP-9PUED6V;Initial Catalog = BazaPrzychodni;Integrated Security = true; TrustServerCertificate=True";

        private string? zapytanieSelect;
        private string? odpowiadajacaNazwaTabeli;
        public string ZapytanieSelect
        {
            get
            {
                switch (zapytanieSelect)
                {
                    //Dodaj czynnosc
                    case "idgabinet":
                        return "SELECT id_gabinet FROM GodzinyPracy where id_lekarz= @parametr and dzien= convert(datetime2, @parametr2 ,105)";
                    case "Poczatek Czynnosci":
                        return "SELECT godzina_poczatek FROM Czynnosci c where c.id_lekarz = @parametr and dzien = convert(datetime2, @parametr2 ,105)";
                    case "KtoMaSpecjalizacje":
                        return "select l.id_lekarz, l.imie, l.nazwisko, l.rok_rozpoczecia_pracy\r\nfrom SpecjalizacjeLekarzy s\r\njoin Lekarze l on l.id_lekarz = s.id_lekarz\r\nwhere s.id_specjalizacja = @parametr";
                    case "CzynnoscGodzinyPracy":
                        return "select poczatek, koniec, id_gabinet from GodzinyPracy where id_lekarz = @parametr and dzien = convert(datetime2, @parametr2 ,105)";
                    case "Dodaj czynnosc":
                        return "select g.nazwa from GodzinyPracy gp join Gabinety g on g.id_gabinet = gp.id_gabinet where gp.id_lekarz = @parametr and gp.dzien = convert(datetime2,@parametr2,105)";
                    case "Strona":
                        return "SELECT nazwisko,g.nazwa,poczatek,koniec,l.id_lekarz\r\nFROM GodzinyPracy gp\r\njoin lekarze l on l.id_lekarz = gp.id_lekarz\r\njoin Gabinety g on g.id_gabinet = gp.id_gabinet\r\njoin SpecjalizacjeLekarzy sl on gp.id_lekarz = sl.id_lekarz\r\njoin Specjalizacje s on s.id_specjalizacja = sl.id_specjalizacja\r\nwhere s.nazwa = @parametr and gp.dzien = @parametr2";
                    case "Nazwa gabinetu":
                        return "select g.nazwa\r\nfrom GodzinyPracy gp\r\njoin Gabinety g on g.id_gabinet = gp.id_gabinet\r\nwhere gp.id_lekarz = @parametr and gp.dzien = convert(datetime2,@parametr2,105)";
                    case "Specjalizacje":
                        return "Select * from specjalizacje";
                    case "Lekarze":
                        return "SELECT *, (SELECT STRING_AGG(specjalizacje.nazwa, ', ') FROM specjalizacjelekarzy LEFT JOIN specjalizacje ON specjalizacje.id_specjalizacja = specjalizacjelekarzy.id_specjalizacja WHERE specjalizacjelekarzy.id_lekarz = lekarze.id_lekarz) AS specjalizacje FROM lekarze";
                    case "Pacjenci":
                        return "select * from pacjenci";
                    case "Gabinety":
                        return "select * from gabinety";
                    case "Godziny pracy":
                        return "select id_dzienpracy,nazwa,dzien,poczatek,koniec from GodzinyPracy join lekarze on Lekarze.id_lekarz = GodzinyPracy.id_lekarz join gabinety on Gabinety.id_gabinet = GodzinyPracy.id_gabinet where GodzinyPracy.id_lekarz = @parametr";
                    case "Przychodnia":
                        return "select id_czynnosc,p.imie Pimie, p.nazwisko Pnazwisko, p.pesel, l.imie Limie, l.nazwisko Lnazwisko, g.nazwa, s.nazwa, dzien, godzina_poczatek from Czynnosci c join Pacjenci p on p.id_pacjent = c.id_pacjent join Gabinety g on g.id_gabinet = c.id_gabinet join Specjalizacje s on s.id_specjalizacja = c.id_specjalizacja join Lekarze l on l.id_lekarz = c.id_lekarz where dzien = convert(datetime2,@parametr,105)";
                    case "Specjalizacje lekarzy":
                        return "SELECT SpecjalizacjeLekarzy.id_specjalizacja_lekarz, specjalizacje.nazwa FROM SpecjalizacjeLekarzy INNER JOIN Specjalizacje on Specjalizacje.id_specjalizacja = SpecjalizacjeLekarzy.id_specjalizacja INNER JOIN lekarze on SpecjalizacjeLekarzy.id_lekarz = Lekarze.id_lekarz WHERE Lekarze.id_lekarz = @parametr ";
                    case "Wyświetlanie stanu zdrowia":
                        return "SELECT id_uprawnienieStanZdrowia,UprawnienieDoStanuZdrowia.id_uprawniony, imie, nazwisko, pesel FROM UprawnienieDoStanuZdrowia JOIN Pacjenci as p ON p.id_pacjent = UprawnienieDoStanuZdrowia.id_uprawniony WHERE UprawnienieDoStanuZdrowia.id_pacjent = @parametr";
                    case "Wyświetlanie dokumentacji":
                        return "SELECT id_uprawnienieDokumentacja, UprawnienieDoDokumentacji.id_uprawniony, imie, nazwisko, pesel FROM UprawnienieDoDokumentacji JOIN Pacjenci as p ON p.id_pacjent = UprawnienieDoDokumentacji.id_uprawniony WHERE UprawnienieDoDokumentacji.id_pacjent = @parametr";
                    
                    default:
                        return "error";
                }
            }
            set => zapytanieSelect = value;
        }
        public string OdpowiadajacaNazwaTabeli {
            get
            {
                switch (odpowiadajacaNazwaTabeli)
                {
                    case "Czynnosci":
                        return "Czynnosci";
                    case "Specjalizacje":
                        return "Specjalizacje";
                    case "Lekarze":
                        return "Lekarze";
                    case "Pacjenci":
                        return "Pacjenci";
                    case "Gabinety":
                        return "Gabinety";
                    case "Specjalizacje lekarzy":
                        return "SpecjalizacjeLekarzy";
                    case "Dodaj uprawnienia do dokumentacji":
                        return "UprawnienieDoDokumentacji";
                    case "Dodaj uprawnienia do stanu zdrowia":
                        return "UprawnienieDoStanuZdrowia";
                    case "Wyświetlanie stanu zdrowia":
                        return "UprawnienieDoStanuZdrowia";
                    case "Wyświetlanie dokumentacji":
                        return "UprawnienieDoDokumentacji";
                    case "Godziny pracy":
                        return "GodzinyPracy";
                    default:
                        return "error";
                }
            }
            set => odpowiadajacaNazwaTabeli = value; 
        }

        // aplikacja internetowa

        public static void rozwijanieSpecjalizacji(ref List<Specjalizacje> specjalizacje)
        {
            Biblioteka obj = new Biblioteka();
            obj.ZapytanieSelect = "Specjalizacje";
            SqlDataReader reader = obj.BazaSelect();
            while (reader.Read())
            {
                Specjalizacje spec = new Specjalizacje();
                spec.Id = Int32.Parse(reader.GetValue(0).ToString());
                spec.Nazwa = reader.GetValue(1).ToString();
                specjalizacje.Add(spec);
            }
        }

        public static List<Dane> selectoptionspecializacje(SqlDataReader reader, ref List<Dane> listaDane)
        {
            while (reader.Read())
            {
                Dane dane = new Dane();
                dane.Nazwisko = reader.GetValue(0).ToString();
                dane.Gabinet = reader.GetValue(1).ToString();
                dane.Poczatek = reader.GetValue(2).ToString();
                dane.Koniec = reader.GetValue(3).ToString();
                dane.id = reader.GetValue(4).ToString();
                listaDane.Add(dane);
            }
            return listaDane;
        }

    }
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
    public class Dane
    {
        public string Nazwisko { get; set; }
        public string Gabinet { get; set; }
        public string Poczatek { get; set; }
        public string Koniec { get; set; }
        public string id { get; set; }
    }
    public class Specjalizacje
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
    }
}
