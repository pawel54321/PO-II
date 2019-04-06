namespace KOLOKWIUM_II
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Wprowadzanie = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Powierzchnia = new System.Windows.Forms.Label();
            this.Liczba_mieszkańców = new System.Windows.Forms.Label();
            this.Rodzaj_wprowadz = new System.Windows.Forms.TextBox();
            this.Rodzaj = new System.Windows.Forms.Label();
            this.Dane = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rodzaj_tab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liczba_mieszkancow_tab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Powierzchnia_tab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rodzaj_wprowadz_2 = new System.Windows.Forms.TextBox();
            this.Rodzaj_2 = new System.Windows.Forms.Label();
            this.Wyszukaj = new System.Windows.Forms.Button();
            this.Wyczysc = new System.Windows.Forms.Button();
            this.Plik = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.Wprowadzanie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Dane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Plik.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Wprowadzanie);
            this.tabControl1.Controls.Add(this.Dane);
            this.tabControl1.Controls.Add(this.Plik);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(357, 277);
            this.tabControl1.TabIndex = 0;
            // 
            // Wprowadzanie
            // 
            this.Wprowadzanie.Controls.Add(this.numericUpDown2);
            this.Wprowadzanie.Controls.Add(this.numericUpDown1);
            this.Wprowadzanie.Controls.Add(this.Dodaj);
            this.Wprowadzanie.Controls.Add(this.Powierzchnia);
            this.Wprowadzanie.Controls.Add(this.Liczba_mieszkańców);
            this.Wprowadzanie.Controls.Add(this.Rodzaj_wprowadz);
            this.Wprowadzanie.Controls.Add(this.Rodzaj);
            this.Wprowadzanie.Location = new System.Drawing.Point(4, 22);
            this.Wprowadzanie.Name = "Wprowadzanie";
            this.Wprowadzanie.Padding = new System.Windows.Forms.Padding(3);
            this.Wprowadzanie.Size = new System.Drawing.Size(349, 251);
            this.Wprowadzanie.TabIndex = 0;
            this.Wprowadzanie.Text = "Wprowadzanie";
            this.Wprowadzanie.UseVisualStyleBackColor = true;
            this.Wprowadzanie.Click += new System.EventHandler(this.Wprowadzanie_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(134, 65);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown2.TabIndex = 16;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(134, 37);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(149, 104);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 15;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Powierzchnia
            // 
            this.Powierzchnia.AutoSize = true;
            this.Powierzchnia.Location = new System.Drawing.Point(6, 72);
            this.Powierzchnia.Name = "Powierzchnia";
            this.Powierzchnia.Size = new System.Drawing.Size(70, 13);
            this.Powierzchnia.TabIndex = 5;
            this.Powierzchnia.Text = "Powierzchnia";
            this.Powierzchnia.Click += new System.EventHandler(this.label4_Click);
            // 
            // Liczba_mieszkańców
            // 
            this.Liczba_mieszkańców.AutoSize = true;
            this.Liczba_mieszkańców.Location = new System.Drawing.Point(6, 44);
            this.Liczba_mieszkańców.Name = "Liczba_mieszkańców";
            this.Liczba_mieszkańców.Size = new System.Drawing.Size(105, 13);
            this.Liczba_mieszkańców.TabIndex = 3;
            this.Liczba_mieszkańców.Text = "Liczba mieszkańców";
            this.Liczba_mieszkańców.Click += new System.EventHandler(this.label2_Click);
            // 
            // Rodzaj_wprowadz
            // 
            this.Rodzaj_wprowadz.Location = new System.Drawing.Point(134, 13);
            this.Rodzaj_wprowadz.Name = "Rodzaj_wprowadz";
            this.Rodzaj_wprowadz.Size = new System.Drawing.Size(100, 20);
            this.Rodzaj_wprowadz.TabIndex = 2;
            this.Rodzaj_wprowadz.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Rodzaj
            // 
            this.Rodzaj.AutoSize = true;
            this.Rodzaj.Location = new System.Drawing.Point(6, 16);
            this.Rodzaj.Name = "Rodzaj";
            this.Rodzaj.Size = new System.Drawing.Size(40, 13);
            this.Rodzaj.TabIndex = 0;
            this.Rodzaj.Text = "Rodzaj";
            this.Rodzaj.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dane
            // 
            this.Dane.Controls.Add(this.button2);
            this.Dane.Controls.Add(this.dataGridView1);
            this.Dane.Controls.Add(this.Rodzaj_wprowadz_2);
            this.Dane.Controls.Add(this.Rodzaj_2);
            this.Dane.Controls.Add(this.Wyszukaj);
            this.Dane.Controls.Add(this.Wyczysc);
            this.Dane.Location = new System.Drawing.Point(4, 22);
            this.Dane.Name = "Dane";
            this.Dane.Padding = new System.Windows.Forms.Padding(3);
            this.Dane.Size = new System.Drawing.Size(349, 251);
            this.Dane.TabIndex = 1;
            this.Dane.Text = "Dane";
            this.Dane.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Wyczyść i pokaż cała listę \r\n(w tabeli)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rodzaj_tab,
            this.Liczba_mieszkancow_tab,
            this.Powierzchnia_tab});
            this.dataGridView1.Location = new System.Drawing.Point(1, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 170);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Rodzaj_tab
            // 
            this.Rodzaj_tab.HeaderText = "Rodzaj";
            this.Rodzaj_tab.Name = "Rodzaj_tab";
            // 
            // Liczba_mieszkancow_tab
            // 
            this.Liczba_mieszkancow_tab.HeaderText = "Liczba Mieszkańców";
            this.Liczba_mieszkancow_tab.Name = "Liczba_mieszkancow_tab";
            // 
            // Powierzchnia_tab
            // 
            this.Powierzchnia_tab.HeaderText = "Powierzchnia";
            this.Powierzchnia_tab.Name = "Powierzchnia_tab";
            // 
            // Rodzaj_wprowadz_2
            // 
            this.Rodzaj_wprowadz_2.Location = new System.Drawing.Point(60, 186);
            this.Rodzaj_wprowadz_2.Name = "Rodzaj_wprowadz_2";
            this.Rodzaj_wprowadz_2.Size = new System.Drawing.Size(76, 20);
            this.Rodzaj_wprowadz_2.TabIndex = 5;
            this.Rodzaj_wprowadz_2.TextChanged += new System.EventHandler(this.Rodzaj_wprowadz_2_TextChanged);
            // 
            // Rodzaj_2
            // 
            this.Rodzaj_2.AutoSize = true;
            this.Rodzaj_2.Location = new System.Drawing.Point(15, 189);
            this.Rodzaj_2.Name = "Rodzaj_2";
            this.Rodzaj_2.Size = new System.Drawing.Size(40, 13);
            this.Rodzaj_2.TabIndex = 4;
            this.Rodzaj_2.Text = "Rodzaj";
            this.Rodzaj_2.Click += new System.EventHandler(this.label3_Click);
            // 
            // Wyszukaj
            // 
            this.Wyszukaj.Location = new System.Drawing.Point(155, 184);
            this.Wyszukaj.Name = "Wyszukaj";
            this.Wyszukaj.Size = new System.Drawing.Size(75, 23);
            this.Wyszukaj.TabIndex = 3;
            this.Wyszukaj.Text = "Wyszukaj";
            this.Wyszukaj.UseVisualStyleBackColor = true;
            this.Wyszukaj.Click += new System.EventHandler(this.Wyszukaj_Click);
            // 
            // Wyczysc
            // 
            this.Wyczysc.Location = new System.Drawing.Point(236, 184);
            this.Wyczysc.Name = "Wyczysc";
            this.Wyczysc.Size = new System.Drawing.Size(105, 64);
            this.Wyczysc.TabIndex = 2;
            this.Wyczysc.Text = "Wyczyść \r\n(tylko tabele)";
            this.Wyczysc.UseVisualStyleBackColor = true;
            this.Wyczysc.Click += new System.EventHandler(this.button1_Click);
            // 
            // Plik
            // 
            this.Plik.Controls.Add(this.button4);
            this.Plik.Controls.Add(this.groupBox2);
            this.Plik.Controls.Add(this.groupBox1);
            this.Plik.Controls.Add(this.button1);
            this.Plik.Controls.Add(this.checkBox1);
            this.Plik.Location = new System.Drawing.Point(4, 22);
            this.Plik.Name = "Plik";
            this.Plik.Size = new System.Drawing.Size(349, 251);
            this.Plik.TabIndex = 2;
            this.Plik.Text = "Plik";
            this.Plik.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(222, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Odczytaj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(206, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 75);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Separator";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(28, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = ".";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 42);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(28, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = ";";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Separator";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(28, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = ".";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(28, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = ";";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Nadpisywanie";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 279);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Kolokwium_II";
            this.tabControl1.ResumeLayout(false);
            this.Wprowadzanie.ResumeLayout(false);
            this.Wprowadzanie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Dane.ResumeLayout(false);
            this.Dane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Plik.ResumeLayout(false);
            this.Plik.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Wprowadzanie;
        private System.Windows.Forms.TabPage Dane;
        private System.Windows.Forms.Label Rodzaj;
        private System.Windows.Forms.TextBox Rodzaj_wprowadz;
        private System.Windows.Forms.Label Liczba_mieszkańców;
        private System.Windows.Forms.TextBox Rodzaj_wprowadz_2;
        private System.Windows.Forms.Label Rodzaj_2;
        private System.Windows.Forms.Button Wyszukaj;
        private System.Windows.Forms.Button Wyczysc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Powierzchnia;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.TabPage Plik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rodzaj_tab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba_mieszkancow_tab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Powierzchnia_tab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

