namespace WinFormsApp
{
    partial class Dodaj_czynność
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBoxSpecjalizacje = new ComboBox();
            label2 = new Label();
            comboBoxLekarz = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            checkBox2 = new CheckBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Specjalizacja";
            // 
            // comboBoxSpecjalizacje
            // 
            comboBoxSpecjalizacje.FormattingEnabled = true;
            comboBoxSpecjalizacje.Location = new Point(12, 27);
            comboBoxSpecjalizacje.Name = "comboBoxSpecjalizacje";
            comboBoxSpecjalizacje.Size = new Size(177, 23);
            comboBoxSpecjalizacje.TabIndex = 1;
            comboBoxSpecjalizacje.SelectedIndexChanged += comboBoxSpecjalizacje_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Lekarz";
            // 
            // comboBoxLekarz
            // 
            comboBoxLekarz.FormattingEnabled = true;
            comboBoxLekarz.Location = new Point(12, 71);
            comboBoxLekarz.Name = "comboBoxLekarz";
            comboBoxLekarz.Size = new Size(177, 23);
            comboBoxLekarz.TabIndex = 3;
            comboBoxLekarz.SelectedIndexChanged += comboBoxLekarz_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Enabled = false;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(196, 27);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(93, 328);
            checkedListBox1.TabIndex = 26;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(12, 115);
            dateTimePicker1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(177, 23);
            dateTimePicker1.TabIndex = 32;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 33;
            label3.Text = "Dzień:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 221);
            button1.Name = "button1";
            button1.Size = new Size(178, 23);
            button1.TabIndex = 35;
            button1.Text = "Wybierz pacjenta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 250);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Wybierz pacjenta klikając w przycisk";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 36;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 279);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 37;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(12, 325);
            button2.Name = "button2";
            button2.Size = new Size(178, 30);
            button2.TabIndex = 38;
            button2.Text = "Zatwierdź";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 144);
            button3.Name = "button3";
            button3.Size = new Size(177, 23);
            button3.TabIndex = 39;
            button3.Text = "Sprawdź wolne terminy";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(108, 279);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 40;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 41;
            label4.Text = "Godzina";
            // 
            // Dodaj_czynność
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 363);
            Controls.Add(label4);
            Controls.Add(checkBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBoxLekarz);
            Controls.Add(label2);
            Controls.Add(comboBoxSpecjalizacje);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dodaj_czynność";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Czynność";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxSpecjalizacje;
        private Label label2;
        private ComboBox comboBoxLekarz;
        private CheckedListBox checkedListBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button button1;
        internal TextBox textBox1;
        internal CheckBox checkBox1;
        private Button button2;
        private Button button3;
        internal CheckBox checkBox2;
        private Label label4;
    }
}