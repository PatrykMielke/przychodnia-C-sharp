namespace WinFormsApp
{
    partial class Pacjenci
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBox3 = new TextBox();
            numericUpDown3 = new NumericUpDown();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(768, 378);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // id
            // 
            id.HeaderText = "Column1";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // Column2
            // 
            Column2.HeaderText = "Imię";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nazwisko";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "PESEL";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            Column5.DefaultCellStyle = dataGridViewCellStyle1;
            Column5.HeaderText = "Rok urodz.";
            Column5.MaxInputLength = 10;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Adres";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Telefon";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "E-mail";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 170;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(384, 538);
            button3.Name = "button3";
            button3.Size = new Size(180, 40);
            button3.TabIndex = 16;
            button3.Text = "Usuń";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(570, 454);
            button4.Name = "button4";
            button4.Size = new Size(210, 56);
            button4.TabIndex = 15;
            button4.Text = "Uprawnienia do informacji o stanie zdrowia";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(198, 538);
            button2.Name = "button2";
            button2.Size = new Size(180, 40);
            button2.TabIndex = 14;
            button2.Text = "Edytuj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 538);
            button1.Name = "button1";
            button1.Size = new Size(180, 40);
            button1.TabIndex = 13;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 408);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Imię";
            textBox1.Size = new Size(185, 40);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 408);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nazwisko";
            textBox2.Size = new Size(185, 40);
            textBox2.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(203, 487);
            numericUpDown1.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(185, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 100000000, 0, 0, 0 });
            // 
            // textBox3
            // 
            textBox3.Location = new Point(394, 408);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Adres";
            textBox3.Size = new Size(185, 40);
            textBox3.TabIndex = 5;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(12, 487);
            numericUpDown3.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(185, 23);
            numericUpDown3.TabIndex = 3;
            numericUpDown3.Value = new decimal(new int[] { 1410065408, 2, 0, 0 });
            // 
            // textBox4
            // 
            textBox4.Location = new Point(585, 408);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "E-mail";
            textBox4.Size = new Size(195, 40);
            textBox4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 469);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 24;
            label1.Text = "PESEL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 469);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 25;
            label2.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 469);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 26;
            label3.Text = "Data urodzenia";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(394, 487);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(570, 516);
            button5.Name = "button5";
            button5.Size = new Size(210, 62);
            button5.TabIndex = 27;
            button5.Text = "Uprawnienia do dokumentacji medycznej";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Pacjenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 590);
            Controls.Add(button5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(numericUpDown3);
            Controls.Add(textBox3);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Pacjenci";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pacjenci";
            Load += Pacjenci_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox3;
        private NumericUpDown numericUpDown3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button button5;
    }
}