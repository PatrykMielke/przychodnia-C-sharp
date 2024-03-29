namespace WinFormsApp
{
    partial class Specjalizacje_lekarzy
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
            labelNazwaLekarza = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Specjalizacja = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Wybrany lekarz:";
            // 
            // labelNazwaLekarza
            // 
            labelNazwaLekarza.AutoSize = true;
            labelNazwaLekarza.Location = new Point(108, 9);
            labelNazwaLekarza.Name = "labelNazwaLekarza";
            labelNazwaLekarza.Size = new Size(0, 15);
            labelNazwaLekarza.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Specjalizacja });
            dataGridView1.Location = new Point(12, 39);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(356, 300);
            dataGridView1.TabIndex = 2;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // id
            // 
            id.HeaderText = "Column1";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // Specjalizacja
            // 
            Specjalizacja.HeaderText = "Specjalizacja";
            Specjalizacja.Name = "Specjalizacja";
            Specjalizacja.ReadOnly = true;
            Specjalizacja.Width = 480;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(230, 374);
            button3.Name = "button3";
            button3.Size = new Size(138, 50);
            button3.TabIndex = 9;
            button3.Text = "Usuń";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 374);
            button1.Name = "button1";
            button1.Size = new Size(212, 50);
            button1.TabIndex = 7;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 345);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(356, 23);
            comboBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(285, 9);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // Specjalizacje_lekarzy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 443);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(labelNazwaLekarza);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Specjalizacje_lekarzy";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Specjalizacje lekarzy";
            Load += Specjalizacje_lekarzy_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNazwaLekarza;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button1;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Specjalizacja;
        private CheckBox checkBox1;
    }
}