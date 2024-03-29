namespace WinFormsApp
{
    partial class Godziny_pracy
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
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            comboBoxGabinet = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBoxPoczatek = new ComboBox();
            comboBoxKoniec = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(11, 34);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(403, 378);
            dataGridView1.TabIndex = 11;
            // 
            // id
            // 
            id.HeaderText = "Column1";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // Column4
            // 
            Column4.HeaderText = "Gabinet";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            Column5.DefaultCellStyle = dataGridViewCellStyle1;
            Column5.HeaderText = "Dzień";
            Column5.MaxInputLength = 10;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Początek";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Koniec";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(294, 557);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 19;
            button3.Text = "Usuń";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(11, 557);
            button1.Name = "button1";
            button1.Size = new Size(277, 40);
            button1.TabIndex = 17;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 21;
            label1.Text = "Godziny pracy: ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(319, 9);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // comboBoxGabinet
            // 
            comboBoxGabinet.FormattingEnabled = true;
            comboBoxGabinet.Location = new Point(11, 453);
            comboBoxGabinet.Name = "comboBoxGabinet";
            comboBoxGabinet.Size = new Size(121, 23);
            comboBoxGabinet.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(12, 515);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // comboBoxPoczatek
            // 
            comboBoxPoczatek.FormattingEnabled = true;
            comboBoxPoczatek.Location = new Point(294, 453);
            comboBoxPoczatek.Name = "comboBoxPoczatek";
            comboBoxPoczatek.Size = new Size(121, 23);
            comboBoxPoczatek.TabIndex = 4;
            // 
            // comboBoxKoniec
            // 
            comboBoxKoniec.FormattingEnabled = true;
            comboBoxKoniec.Location = new Point(294, 515);
            comboBoxKoniec.Name = "comboBoxKoniec";
            comboBoxKoniec.Size = new Size(121, 23);
            comboBoxKoniec.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 435);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 22;
            label2.Text = "Gabinet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 435);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 23;
            label3.Text = "Początek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 497);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 24;
            label4.Text = "Koniec";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 497);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 25;
            label5.Text = "Dzień";
            // 
            // Godziny_pracy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 609);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxKoniec);
            Controls.Add(comboBoxPoczatek);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBoxGabinet);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Godziny_pracy";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Godziny pracy";
            Load += Godziny_pracy_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button1;
        private Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private CheckBox checkBox1;
        private ComboBox comboBoxGabinet;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxPoczatek;
        private ComboBox comboBoxKoniec;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}