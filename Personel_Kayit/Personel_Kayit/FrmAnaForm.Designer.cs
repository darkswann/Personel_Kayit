namespace Personel_Kayit
{
    partial class FrmAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboSehir = new System.Windows.Forms.ComboBox();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.radioBekar = new System.Windows.Forms.RadioButton();
            this.radioEvli = new System.Windows.Forms.RadioButton();
            this.maskMaas = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttnGrafik = new System.Windows.Forms.Button();
            this.bttnİstatik = new System.Windows.Forms.Button();
            this.bttnTemizle = new System.Windows.Forms.Button();
            this.bttnGuncelle = new System.Windows.Forms.Button();
            this.bttnSil = new System.Windows.Forms.Button();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.bttnListele = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriDataSet2 = new Personel_Kayit.PersonelVeriDataSet2();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.PersonelVeriDataSet2TableAdapters.Tbl_PersonelTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboSehir);
            this.groupBox1.Controls.Add(this.txtMeslek);
            this.groupBox1.Controls.Add(this.radioBekar);
            this.groupBox1.Controls.Add(this.radioEvli);
            this.groupBox1.Controls.Add(this.maskMaas);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(346, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // comboSehir
            // 
            this.comboSehir.FormattingEnabled = true;
            this.comboSehir.Location = new System.Drawing.Point(162, 137);
            this.comboSehir.Name = "comboSehir";
            this.comboSehir.Size = new System.Drawing.Size(121, 28);
            this.comboSehir.TabIndex = 15;
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(165, 244);
            this.txtMeslek.Margin = new System.Windows.Forms.Padding(2);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(113, 26);
            this.txtMeslek.TabIndex = 14;
            // 
            // radioBekar
            // 
            this.radioBekar.AutoSize = true;
            this.radioBekar.Location = new System.Drawing.Point(215, 210);
            this.radioBekar.Margin = new System.Windows.Forms.Padding(2);
            this.radioBekar.Name = "radioBekar";
            this.radioBekar.Size = new System.Drawing.Size(69, 24);
            this.radioBekar.TabIndex = 13;
            this.radioBekar.TabStop = true;
            this.radioBekar.Text = "Bekar";
            this.radioBekar.UseVisualStyleBackColor = true;
            this.radioBekar.CheckedChanged += new System.EventHandler(this.radioBekar_CheckedChanged);
            // 
            // radioEvli
            // 
            this.radioEvli.AutoSize = true;
            this.radioEvli.Location = new System.Drawing.Point(165, 210);
            this.radioEvli.Margin = new System.Windows.Forms.Padding(2);
            this.radioEvli.Name = "radioEvli";
            this.radioEvli.Size = new System.Drawing.Size(51, 24);
            this.radioEvli.TabIndex = 12;
            this.radioEvli.TabStop = true;
            this.radioEvli.Text = "Evli";
            this.radioEvli.UseVisualStyleBackColor = true;
            this.radioEvli.CheckedChanged += new System.EventHandler(this.radioEvli_CheckedChanged);
            // 
            // maskMaas
            // 
            this.maskMaas.Location = new System.Drawing.Point(162, 169);
            this.maskMaas.Margin = new System.Windows.Forms.Padding(2);
            this.maskMaas.Mask = "00000";
            this.maskMaas.Name = "maskMaas";
            this.maskMaas.Size = new System.Drawing.Size(113, 26);
            this.maskMaas.TabIndex = 11;
            this.maskMaas.ValidatingType = typeof(int);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(162, 106);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(113, 26);
            this.txtSoyad.TabIndex = 9;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(162, 73);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(113, 26);
            this.txtAd.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(162, 38);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(113, 26);
            this.txtID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Personel Meslek :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Personel Durum :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Personel Maaş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personel Şehir :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttnGrafik);
            this.groupBox2.Controls.Add(this.bttnİstatik);
            this.groupBox2.Controls.Add(this.bttnTemizle);
            this.groupBox2.Controls.Add(this.bttnGuncelle);
            this.groupBox2.Controls.Add(this.bttnSil);
            this.groupBox2.Controls.Add(this.bttnKaydet);
            this.groupBox2.Controls.Add(this.bttnListele);
            this.groupBox2.Location = new System.Drawing.Point(399, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(286, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // bttnGrafik
            // 
            this.bttnGrafik.Location = new System.Drawing.Point(80, 227);
            this.bttnGrafik.Margin = new System.Windows.Forms.Padding(2);
            this.bttnGrafik.Name = "bttnGrafik";
            this.bttnGrafik.Size = new System.Drawing.Size(115, 29);
            this.bttnGrafik.TabIndex = 6;
            this.bttnGrafik.Text = "Grafikler";
            this.bttnGrafik.UseVisualStyleBackColor = true;
            this.bttnGrafik.Click += new System.EventHandler(this.bttnGrafik_Click);
            // 
            // bttnİstatik
            // 
            this.bttnİstatik.Location = new System.Drawing.Point(80, 192);
            this.bttnİstatik.Margin = new System.Windows.Forms.Padding(2);
            this.bttnİstatik.Name = "bttnİstatik";
            this.bttnİstatik.Size = new System.Drawing.Size(115, 29);
            this.bttnİstatik.TabIndex = 5;
            this.bttnİstatik.Text = "İstatistik";
            this.bttnİstatik.UseVisualStyleBackColor = true;
            this.bttnİstatik.Click += new System.EventHandler(this.bttnİstatik_Click);
            // 
            // bttnTemizle
            // 
            this.bttnTemizle.Location = new System.Drawing.Point(80, 158);
            this.bttnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.bttnTemizle.Name = "bttnTemizle";
            this.bttnTemizle.Size = new System.Drawing.Size(115, 29);
            this.bttnTemizle.TabIndex = 4;
            this.bttnTemizle.Text = "Temizle";
            this.bttnTemizle.UseVisualStyleBackColor = true;
            this.bttnTemizle.Click += new System.EventHandler(this.bttnTemizle_Click);
            // 
            // bttnGuncelle
            // 
            this.bttnGuncelle.Location = new System.Drawing.Point(80, 124);
            this.bttnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.bttnGuncelle.Name = "bttnGuncelle";
            this.bttnGuncelle.Size = new System.Drawing.Size(115, 29);
            this.bttnGuncelle.TabIndex = 3;
            this.bttnGuncelle.Text = "Güncelle";
            this.bttnGuncelle.UseVisualStyleBackColor = true;
            this.bttnGuncelle.Click += new System.EventHandler(this.bttnGuncelle_Click);
            // 
            // bttnSil
            // 
            this.bttnSil.Location = new System.Drawing.Point(80, 90);
            this.bttnSil.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSil.Name = "bttnSil";
            this.bttnSil.Size = new System.Drawing.Size(115, 29);
            this.bttnSil.TabIndex = 2;
            this.bttnSil.Text = "Sil ";
            this.bttnSil.UseVisualStyleBackColor = true;
            this.bttnSil.Click += new System.EventHandler(this.bttnSil_Click);
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Location = new System.Drawing.Point(80, 58);
            this.bttnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(115, 27);
            this.bttnKaydet.TabIndex = 1;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            this.bttnKaydet.Click += new System.EventHandler(this.bttnKaydet_Click);
            // 
            // bttnListele
            // 
            this.bttnListele.Location = new System.Drawing.Point(80, 24);
            this.bttnListele.Margin = new System.Windows.Forms.Padding(2);
            this.bttnListele.Name = "bttnListele";
            this.bttnListele.Size = new System.Drawing.Size(115, 29);
            this.bttnListele.TabIndex = 0;
            this.bttnListele.Text = "Listele";
            this.bttnListele.UseVisualStyleBackColor = true;
            this.bttnListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(730, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(19, 347);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(916, 167);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(912, 144);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriDataSet2;
            // 
            // personelVeriDataSet2
            // 
            this.personelVeriDataSet2.DataSetName = "PersonelVeriDataSet2";
            this.personelVeriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(709, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmAnaForm";
            this.Text = "FrmAnaForm";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.RadioButton radioBekar;
        private System.Windows.Forms.RadioButton radioEvli;
        private System.Windows.Forms.MaskedTextBox maskMaas;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttnGrafik;
        private System.Windows.Forms.Button bttnİstatik;
        private System.Windows.Forms.Button bttnTemizle;
        private System.Windows.Forms.Button bttnGuncelle;
        private System.Windows.Forms.Button bttnSil;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Button bttnListele;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriDataSet2 personelVeriDataSet2;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriDataSet2TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboSehir;
    }
}