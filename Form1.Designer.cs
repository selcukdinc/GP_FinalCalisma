﻿namespace FinalCalisma
{
    partial class Form1
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpVeritabani = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTelNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOgrNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOku = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.tpManav = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSofor = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSoforIsim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSoforTelNo = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHat2 = new System.Windows.Forms.ComboBox();
            this.cbHat1 = new System.Windows.Forms.ComboBox();
            this.btnSoforRead = new System.Windows.Forms.Button();
            this.btnSoforDelete = new System.Windows.Forms.Button();
            this.btnSoforUpdate = new System.Windows.Forms.Button();
            this.btnSoforCreate = new System.Windows.Forms.Button();
            this.dgvManav = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnManavCreate = new System.Windows.Forms.Button();
            this.btnManavUpdate = new System.Windows.Forms.Button();
            this.btnManavDelete = new System.Windows.Forms.Button();
            this.btnManavRead = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tbSatis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAlis = new System.Windows.Forms.TextBox();
            this.cbUrun = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tcMain.SuspendLayout();
            this.tpVeritabani.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpManav.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSofor)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManav)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpVeritabani);
            this.tcMain.Controls.Add(this.tpManav);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1109, 544);
            this.tcMain.TabIndex = 0;
            // 
            // tpVeritabani
            // 
            this.tpVeritabani.Controls.Add(this.panel1);
            this.tpVeritabani.Controls.Add(this.panel2);
            this.tpVeritabani.Location = new System.Drawing.Point(4, 23);
            this.tpVeritabani.Name = "tpVeritabani";
            this.tpVeritabani.Padding = new System.Windows.Forms.Padding(3);
            this.tpVeritabani.Size = new System.Drawing.Size(945, 517);
            this.tpVeritabani.TabIndex = 0;
            this.tpVeritabani.Text = "CRUD";
            this.tpVeritabani.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvOgrenciler);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 417);
            this.panel1.TabIndex = 1;
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOgrenciler.Location = new System.Drawing.Point(0, 0);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.ReadOnly = true;
            this.dgvOgrenciler.Size = new System.Drawing.Size(939, 327);
            this.dgvOgrenciler.TabIndex = 1;
            this.dgvOgrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenciler_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTemizle);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbTelNo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbOgrNo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbSoyad);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbAd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 90);
            this.panel3.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTemizle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(620, 32);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 25);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon No : ";
            // 
            // tbTelNo
            // 
            this.tbTelNo.Location = new System.Drawing.Point(500, 48);
            this.tbTelNo.Name = "tbTelNo";
            this.tbTelNo.Size = new System.Drawing.Size(100, 22);
            this.tbTelNo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Öğrenci No :";
            // 
            // tbOgrNo
            // 
            this.tbOgrNo.Location = new System.Drawing.Point(500, 20);
            this.tbOgrNo.Name = "tbOgrNo";
            this.tbOgrNo.Size = new System.Drawing.Size(100, 22);
            this.tbOgrNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad :";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(304, 48);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(100, 22);
            this.tbSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad :";
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(304, 20);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(100, 22);
            this.tbAd.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOku);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnOlustur);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 94);
            this.panel2.TabIndex = 2;
            // 
            // btnOku
            // 
            this.btnOku.BackColor = System.Drawing.Color.Aquamarine;
            this.btnOku.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOku.FlatAppearance.BorderSize = 0;
            this.btnOku.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOku.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOku.Location = new System.Drawing.Point(348, 38);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(75, 25);
            this.btnOku.TabIndex = 3;
            this.btnOku.Text = "Read";
            this.btnOku.UseVisualStyleBackColor = false;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(510, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(429, 38);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.LawnGreen;
            this.btnOlustur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOlustur.FlatAppearance.BorderSize = 0;
            this.btnOlustur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlustur.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(267, 38);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 25);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "Create";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // tpManav
            // 
            this.tpManav.Controls.Add(this.panel4);
            this.tpManav.Controls.Add(this.panel5);
            this.tpManav.Location = new System.Drawing.Point(4, 23);
            this.tpManav.Name = "tpManav";
            this.tpManav.Padding = new System.Windows.Forms.Padding(3);
            this.tpManav.Size = new System.Drawing.Size(1101, 517);
            this.tpManav.TabIndex = 1;
            this.tpManav.Text = "Manav";
            this.tpManav.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvSofor);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(534, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(564, 511);
            this.panel4.TabIndex = 0;
            // 
            // dgvSofor
            // 
            this.dgvSofor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSofor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSofor.Location = new System.Drawing.Point(0, 0);
            this.dgvSofor.Name = "dgvSofor";
            this.dgvSofor.Size = new System.Drawing.Size(564, 269);
            this.dgvSofor.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.btnSoforRead);
            this.panel9.Controls.Add(this.btnSoforDelete);
            this.panel9.Controls.Add(this.btnSoforUpdate);
            this.panel9.Controls.Add(this.btnSoforCreate);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 269);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(564, 242);
            this.panel9.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.tbSoforIsim);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.tbSoforTelNo);
            this.panel11.Location = new System.Drawing.Point(127, 42);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(312, 74);
            this.panel11.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "Şöför İsim :";
            // 
            // tbSoforIsim
            // 
            this.tbSoforIsim.Location = new System.Drawing.Point(150, 12);
            this.tbSoforIsim.Name = "tbSoforIsim";
            this.tbSoforIsim.Size = new System.Drawing.Size(124, 22);
            this.tbSoforIsim.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Şöför Telefon No :";
            // 
            // tbSoforTelNo
            // 
            this.tbSoforTelNo.Location = new System.Drawing.Point(150, 40);
            this.tbSoforTelNo.Name = "tbSoforTelNo";
            this.tbSoforTelNo.Size = new System.Drawing.Size(124, 22);
            this.tbSoforTelNo.TabIndex = 16;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.cbHat2);
            this.panel10.Controls.Add(this.cbHat1);
            this.panel10.Location = new System.Drawing.Point(127, 122);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(312, 58);
            this.panel10.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 14);
            this.label8.TabIndex = 20;
            this.label8.Text = "Şöfürün Çalıştığı Hat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "-";
            // 
            // cbHat2
            // 
            this.cbHat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHat2.FormattingEnabled = true;
            this.cbHat2.Location = new System.Drawing.Point(167, 25);
            this.cbHat2.Name = "cbHat2";
            this.cbHat2.Size = new System.Drawing.Size(121, 22);
            this.cbHat2.TabIndex = 12;
            // 
            // cbHat1
            // 
            this.cbHat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHat1.FormattingEnabled = true;
            this.cbHat1.Location = new System.Drawing.Point(24, 25);
            this.cbHat1.Name = "cbHat1";
            this.cbHat1.Size = new System.Drawing.Size(121, 22);
            this.cbHat1.TabIndex = 11;
            // 
            // btnSoforRead
            // 
            this.btnSoforRead.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSoforRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSoforRead.FlatAppearance.BorderSize = 0;
            this.btnSoforRead.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSoforRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoforRead.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoforRead.Location = new System.Drawing.Point(204, 201);
            this.btnSoforRead.Name = "btnSoforRead";
            this.btnSoforRead.Size = new System.Drawing.Size(75, 25);
            this.btnSoforRead.TabIndex = 7;
            this.btnSoforRead.Text = "Read";
            this.btnSoforRead.UseVisualStyleBackColor = false;
            // 
            // btnSoforDelete
            // 
            this.btnSoforDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnSoforDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSoforDelete.FlatAppearance.BorderSize = 0;
            this.btnSoforDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSoforDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoforDelete.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoforDelete.Location = new System.Drawing.Point(366, 201);
            this.btnSoforDelete.Name = "btnSoforDelete";
            this.btnSoforDelete.Size = new System.Drawing.Size(75, 25);
            this.btnSoforDelete.TabIndex = 6;
            this.btnSoforDelete.Text = "Delete";
            this.btnSoforDelete.UseVisualStyleBackColor = false;
            // 
            // btnSoforUpdate
            // 
            this.btnSoforUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnSoforUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSoforUpdate.FlatAppearance.BorderSize = 0;
            this.btnSoforUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSoforUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoforUpdate.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoforUpdate.Location = new System.Drawing.Point(285, 201);
            this.btnSoforUpdate.Name = "btnSoforUpdate";
            this.btnSoforUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnSoforUpdate.TabIndex = 5;
            this.btnSoforUpdate.Text = "Update";
            this.btnSoforUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSoforCreate
            // 
            this.btnSoforCreate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSoforCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSoforCreate.FlatAppearance.BorderSize = 0;
            this.btnSoforCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSoforCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoforCreate.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoforCreate.Location = new System.Drawing.Point(123, 201);
            this.btnSoforCreate.Name = "btnSoforCreate";
            this.btnSoforCreate.Size = new System.Drawing.Size(75, 25);
            this.btnSoforCreate.TabIndex = 4;
            this.btnSoforCreate.Text = "Create";
            this.btnSoforCreate.UseVisualStyleBackColor = false;
            this.btnSoforCreate.Click += new System.EventHandler(this.btnSoforCreate_Click);
            // 
            // dgvManav
            // 
            this.dgvManav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManav.Location = new System.Drawing.Point(0, 0);
            this.dgvManav.Name = "dgvManav";
            this.dgvManav.Size = new System.Drawing.Size(531, 269);
            this.dgvManav.TabIndex = 0;
            this.dgvManav.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManav_CellClick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.btnManavRead);
            this.panel7.Controls.Add(this.btnManavDelete);
            this.panel7.Controls.Add(this.btnManavUpdate);
            this.panel7.Controls.Add(this.btnManavCreate);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 269);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(531, 242);
            this.panel7.TabIndex = 1;
            // 
            // btnManavCreate
            // 
            this.btnManavCreate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnManavCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManavCreate.FlatAppearance.BorderSize = 0;
            this.btnManavCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnManavCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManavCreate.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManavCreate.Location = new System.Drawing.Point(92, 201);
            this.btnManavCreate.Name = "btnManavCreate";
            this.btnManavCreate.Size = new System.Drawing.Size(75, 25);
            this.btnManavCreate.TabIndex = 4;
            this.btnManavCreate.Text = "Create";
            this.btnManavCreate.UseVisualStyleBackColor = false;
            this.btnManavCreate.Click += new System.EventHandler(this.btnManavCreate_Click);
            // 
            // btnManavUpdate
            // 
            this.btnManavUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnManavUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManavUpdate.FlatAppearance.BorderSize = 0;
            this.btnManavUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnManavUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManavUpdate.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManavUpdate.Location = new System.Drawing.Point(254, 201);
            this.btnManavUpdate.Name = "btnManavUpdate";
            this.btnManavUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnManavUpdate.TabIndex = 5;
            this.btnManavUpdate.Text = "Update";
            this.btnManavUpdate.UseVisualStyleBackColor = false;
            this.btnManavUpdate.Click += new System.EventHandler(this.btnManavUpdate_Click);
            // 
            // btnManavDelete
            // 
            this.btnManavDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnManavDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManavDelete.FlatAppearance.BorderSize = 0;
            this.btnManavDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnManavDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManavDelete.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManavDelete.Location = new System.Drawing.Point(335, 201);
            this.btnManavDelete.Name = "btnManavDelete";
            this.btnManavDelete.Size = new System.Drawing.Size(75, 25);
            this.btnManavDelete.TabIndex = 6;
            this.btnManavDelete.Text = "Delete";
            this.btnManavDelete.UseVisualStyleBackColor = false;
            this.btnManavDelete.Click += new System.EventHandler(this.btnManavDelete_Click);
            // 
            // btnManavRead
            // 
            this.btnManavRead.BackColor = System.Drawing.Color.Aquamarine;
            this.btnManavRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManavRead.FlatAppearance.BorderSize = 0;
            this.btnManavRead.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnManavRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManavRead.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManavRead.Location = new System.Drawing.Point(173, 201);
            this.btnManavRead.Name = "btnManavRead";
            this.btnManavRead.Size = new System.Drawing.Size(75, 25);
            this.btnManavRead.TabIndex = 7;
            this.btnManavRead.Text = "Read";
            this.btnManavRead.UseVisualStyleBackColor = false;
            this.btnManavRead.Click += new System.EventHandler(this.btnManavRead_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label12);
            this.panel12.Controls.Add(this.label11);
            this.panel12.Controls.Add(this.tbStok);
            this.panel12.Controls.Add(this.label10);
            this.panel12.Controls.Add(this.cbUrun);
            this.panel12.Controls.Add(this.tbAlis);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Controls.Add(this.tbSatis);
            this.panel12.Location = new System.Drawing.Point(61, 42);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(408, 100);
            this.panel12.TabIndex = 20;
            // 
            // tbSatis
            // 
            this.tbSatis.Location = new System.Drawing.Point(301, 27);
            this.tbSatis.Name = "tbSatis";
            this.tbSatis.Size = new System.Drawing.Size(90, 22);
            this.tbSatis.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 14);
            this.label9.TabIndex = 20;
            this.label9.Text = "Satış Fiyatı : ";
            // 
            // tbAlis
            // 
            this.tbAlis.Location = new System.Drawing.Point(6, 26);
            this.tbAlis.Name = "tbAlis";
            this.tbAlis.Size = new System.Drawing.Size(90, 22);
            this.tbAlis.TabIndex = 21;
            // 
            // cbUrun
            // 
            this.cbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrun.FormattingEnabled = true;
            this.cbUrun.Location = new System.Drawing.Point(178, 63);
            this.cbUrun.Name = "cbUrun";
            this.cbUrun.Size = new System.Drawing.Size(121, 22);
            this.cbUrun.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 14);
            this.label10.TabIndex = 22;
            this.label10.Text = "Alış Fiyatı : ";
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(162, 25);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(90, 22);
            this.tbStok.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 14);
            this.label11.TabIndex = 24;
            this.label11.Text = "Stok Adeti : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(98, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 14);
            this.label12.TabIndex = 25;
            this.label12.Text = "Ürün çeşidi : ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvManav);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(531, 511);
            this.panel5.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 544);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMain.ResumeLayout(false);
            this.tpVeritabani.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tpManav.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSofor)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManav)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpVeritabani;
        private System.Windows.Forms.TabPage tpManav;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.DataGridView dgvOgrenciler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTelNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOgrNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSofor;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHat2;
        private System.Windows.Forms.ComboBox cbHat1;
        private System.Windows.Forms.Button btnSoforRead;
        private System.Windows.Forms.Button btnSoforDelete;
        private System.Windows.Forms.Button btnSoforUpdate;
        private System.Windows.Forms.Button btnSoforCreate;
        private System.Windows.Forms.DataGridView dgvManav;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSoforIsim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSoforTelNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbUrun;
        private System.Windows.Forms.TextBox tbAlis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSatis;
        private System.Windows.Forms.Button btnManavRead;
        private System.Windows.Forms.Button btnManavDelete;
        private System.Windows.Forms.Button btnManavUpdate;
        private System.Windows.Forms.Button btnManavCreate;
    }
}

