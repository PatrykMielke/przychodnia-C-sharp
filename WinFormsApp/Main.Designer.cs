namespace WinFormsApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnGabinety = new Button();
            btnListaPacjentow = new Button();
            btnListaLekarzy = new Button();
            btnTypyWizyt = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(222, 49);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(904, 582);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.HeaderText = "Pacjent imię";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Pacjent nazwisko";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Pacjent PESEL";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Lekarz imię";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Lekarz nazwisko";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Gabinet";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Specjalizacja";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Dzień";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "Początek";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnGabinety);
            panel1.Controls.Add(btnListaPacjentow);
            panel1.Controls.Add(btnListaLekarzy);
            panel1.Controls.Add(btnTypyWizyt);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 702);
            panel1.TabIndex = 1;
            // 
            // btnGabinety
            // 
            btnGabinety.Location = new Point(13, 503);
            btnGabinety.Name = "btnGabinety";
            btnGabinety.Size = new Size(190, 40);
            btnGabinety.TabIndex = 7;
            btnGabinety.Text = "Gabinety";
            btnGabinety.UseVisualStyleBackColor = true;
            btnGabinety.Click += btnGabinety_Click;
            // 
            // btnListaPacjentow
            // 
            btnListaPacjentow.Location = new Point(13, 641);
            btnListaPacjentow.Name = "btnListaPacjentow";
            btnListaPacjentow.Size = new Size(190, 40);
            btnListaPacjentow.TabIndex = 6;
            btnListaPacjentow.Text = "Lista pacjentów";
            btnListaPacjentow.UseVisualStyleBackColor = true;
            btnListaPacjentow.Click += btnListaPacjentow_Click;
            // 
            // btnListaLekarzy
            // 
            btnListaLekarzy.Location = new Point(13, 595);
            btnListaLekarzy.Name = "btnListaLekarzy";
            btnListaLekarzy.Size = new Size(190, 40);
            btnListaLekarzy.TabIndex = 4;
            btnListaLekarzy.Text = "Lista lekarzy";
            btnListaLekarzy.UseVisualStyleBackColor = true;
            btnListaLekarzy.Click += btnListaLekarzy_Click;
            // 
            // btnTypyWizyt
            // 
            btnTypyWizyt.Location = new Point(13, 549);
            btnTypyWizyt.Name = "btnTypyWizyt";
            btnTypyWizyt.Size = new Size(190, 40);
            btnTypyWizyt.TabIndex = 3;
            btnTypyWizyt.Text = "Specjalizacje";
            btnTypyWizyt.UseVisualStyleBackColor = true;
            btnTypyWizyt.Click += btnTypyWizyt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 13);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 2;
            label1.Text = "PRZYCHODNIA";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(389, 232);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(222, 14);
            label2.Name = "label2";
            label2.Size = new Size(384, 25);
            label2.TabIndex = 2;
            label2.Text = "Zaplanowane czynności medyczne na dzień:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(612, 14);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 3;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(594, 637);
            button3.Name = "button3";
            button3.Size = new Size(180, 40);
            button3.TabIndex = 19;
            button3.Text = "Usuń";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(408, 637);
            button2.Name = "button2";
            button2.Size = new Size(180, 40);
            button2.TabIndex = 18;
            button2.Text = "Edytuj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(222, 637);
            button1.Name = "button1";
            button1.Size = new Size(180, 40);
            button1.TabIndex = 17;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(772, 14);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 21;
            label4.Text = "label5";
            label4.Click += label4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(953, 14);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 22;
            label5.Text = "label6";
            label5.Click += label5_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 689);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDown1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Przychodnia";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Button btnListaPacjentow;
        private Button btnListaLekarzy;
        private Button btnTypyWizyt;
        private Label label2;
        private Label label3;
        private Button btnGabinety;
        private NumericUpDown numericUpDown1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}