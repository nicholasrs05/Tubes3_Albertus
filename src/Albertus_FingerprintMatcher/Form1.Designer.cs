namespace Albertus_FingerprintMatcher
{
    partial class Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.panelAlgorithm = new System.Windows.Forms.Panel();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelKewarganegaraanOutput = new System.Windows.Forms.Label();
            this.labelPekerjaanOutput = new System.Windows.Forms.Label();
            this.labelStatusOutput = new System.Windows.Forms.Label();
            this.labelAgamaOutput = new System.Windows.Forms.Label();
            this.labelAlamatOutput = new System.Windows.Forms.Label();
            this.labelGolonganDarahOutput = new System.Windows.Forms.Label();
            this.labelJenisKelaminOutput = new System.Windows.Forms.Label();
            this.labelTanggalLahirOutput = new System.Windows.Forms.Label();
            this.labelTempatLahirOutput = new System.Windows.Forms.Label();
            this.labelNamaOutput = new System.Windows.Forms.Label();
            this.labelKewarganegaraan = new System.Windows.Forms.Label();
            this.labelPekerjaan = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelAgama = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelGolonganDarah = new System.Windows.Forms.Label();
            this.labelJenisKelamin = new System.Windows.Forms.Label();
            this.labelTanggalLahir = new System.Windows.Forms.Label();
            this.labelTempatLahir = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.panelExecution = new System.Windows.Forms.Panel();
            this.labelExecTime = new System.Windows.Forms.Label();
            this.labelExecTimeOutput = new System.Windows.Forms.Label();
            this.labelChoosenAlgo = new System.Windows.Forms.Label();
            this.labelChoosenAlgoOutput = new System.Windows.Forms.Label();
            this.labelSimilarity = new System.Windows.Forms.Label();
            this.labelSimilarityOutput = new System.Windows.Forms.Label();
            this.labelNIK = new System.Windows.Forms.Label();
            this.labelNIKOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            this.panelAlgorithm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelExecution.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Albertus_FingerprintMatcher.Properties.Resources.fingerprint;
            this.pictureBox1.Location = new System.Drawing.Point(502, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.Location = new System.Drawing.Point(683, 72);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(396, 49);
            this.labelTitle1.TabIndex = 1;
            this.labelTitle1.Text = "Fingerprint Based";
            // 
            // labelTitle2
            // 
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle2.Location = new System.Drawing.Point(683, 121);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(682, 49);
            this.labelTitle2.TabIndex = 2;
            this.labelTitle2.Text = "Individual Recognition Program";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "made by Kelompok Albertus";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(549, 254);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(264, 28);
            this.labelInput.TabIndex = 4;
            this.labelInput.Text = "Available Fingerprint";
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInput.Location = new System.Drawing.Point(521, 285);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(320, 270);
            this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInput.TabIndex = 5;
            this.pictureBoxInput.TabStop = false;
            // 
            // panelAlgorithm
            // 
            this.panelAlgorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelAlgorithm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlgorithm.Controls.Add(this.comboBoxAlgorithm);
            this.panelAlgorithm.Controls.Add(this.labelAlgorithm);
            this.panelAlgorithm.Location = new System.Drawing.Point(1041, 285);
            this.panelAlgorithm.Name = "panelAlgorithm";
            this.panelAlgorithm.Size = new System.Drawing.Size(231, 93);
            this.panelAlgorithm.TabIndex = 6;
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgorithm.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.ItemHeight = 21;
            this.comboBoxAlgorithm.Items.AddRange(new object[] {
            "KMP",
            "BM"});
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(22, 51);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(188, 29);
            this.comboBoxAlgorithm.TabIndex = 8;
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithm.Location = new System.Drawing.Point(13, 10);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(204, 28);
            this.labelAlgorithm.TabIndex = 7;
            this.labelAlgorithm.Text = "Select Algorithm";
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInput.Location = new System.Drawing.Point(590, 575);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(185, 35);
            this.buttonInput.TabIndex = 7;
            this.buttonInput.Text = "Upload Image";
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSubmit.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(1063, 396);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(188, 35);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOutput.Location = new System.Drawing.Point(521, 702);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(320, 270);
            this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOutput.TabIndex = 9;
            this.pictureBoxOutput.TabStop = false;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(554, 671);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(252, 28);
            this.labelOutput.TabIndex = 10;
            this.labelOutput.Text = "Matching Fingerprint";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelNIKOutput);
            this.panel1.Controls.Add(this.labelNIK);
            this.panel1.Controls.Add(this.labelKewarganegaraanOutput);
            this.panel1.Controls.Add(this.labelPekerjaanOutput);
            this.panel1.Controls.Add(this.labelStatusOutput);
            this.panel1.Controls.Add(this.labelAgamaOutput);
            this.panel1.Controls.Add(this.labelAlamatOutput);
            this.panel1.Controls.Add(this.labelGolonganDarahOutput);
            this.panel1.Controls.Add(this.labelJenisKelaminOutput);
            this.panel1.Controls.Add(this.labelTanggalLahirOutput);
            this.panel1.Controls.Add(this.labelTempatLahirOutput);
            this.panel1.Controls.Add(this.labelNamaOutput);
            this.panel1.Controls.Add(this.labelKewarganegaraan);
            this.panel1.Controls.Add(this.labelPekerjaan);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelAgama);
            this.panel1.Controls.Add(this.labelAlamat);
            this.panel1.Controls.Add(this.labelGolonganDarah);
            this.panel1.Controls.Add(this.labelJenisKelamin);
            this.panel1.Controls.Add(this.labelTanggalLahir);
            this.panel1.Controls.Add(this.labelTempatLahir);
            this.panel1.Controls.Add(this.labelNama);
            this.panel1.Location = new System.Drawing.Point(890, 702);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 270);
            this.panel1.TabIndex = 16;
            // 
            // labelKewarganegaraanOutput
            // 
            this.labelKewarganegaraanOutput.AutoSize = true;
            this.labelKewarganegaraanOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelKewarganegaraanOutput.Location = new System.Drawing.Point(209, 229);
            this.labelKewarganegaraanOutput.Name = "labelKewarganegaraanOutput";
            this.labelKewarganegaraanOutput.Size = new System.Drawing.Size(145, 21);
            this.labelKewarganegaraanOutput.TabIndex = 19;
            this.labelKewarganegaraanOutput.Text = ": [Nationality]";
            // 
            // labelPekerjaanOutput
            // 
            this.labelPekerjaanOutput.AutoSize = true;
            this.labelPekerjaanOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelPekerjaanOutput.Location = new System.Drawing.Point(209, 208);
            this.labelPekerjaanOutput.Name = "labelPekerjaanOutput";
            this.labelPekerjaanOutput.Size = new System.Drawing.Size(73, 21);
            this.labelPekerjaanOutput.TabIndex = 18;
            this.labelPekerjaanOutput.Text = ": [Job]";
            // 
            // labelStatusOutput
            // 
            this.labelStatusOutput.AutoSize = true;
            this.labelStatusOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelStatusOutput.Location = new System.Drawing.Point(209, 187);
            this.labelStatusOutput.Name = "labelStatusOutput";
            this.labelStatusOutput.Size = new System.Drawing.Size(172, 21);
            this.labelStatusOutput.TabIndex = 17;
            this.labelStatusOutput.Text = ": [Marital Status]";
            // 
            // labelAgamaOutput
            // 
            this.labelAgamaOutput.AutoSize = true;
            this.labelAgamaOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelAgamaOutput.Location = new System.Drawing.Point(209, 166);
            this.labelAgamaOutput.Name = "labelAgamaOutput";
            this.labelAgamaOutput.Size = new System.Drawing.Size(118, 21);
            this.labelAgamaOutput.TabIndex = 16;
            this.labelAgamaOutput.Text = ": [Religion]";
            // 
            // labelAlamatOutput
            // 
            this.labelAlamatOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelAlamatOutput.Location = new System.Drawing.Point(209, 144);
            this.labelAlamatOutput.Name = "labelAlamatOutput";
            this.labelAlamatOutput.Size = new System.Drawing.Size(359, 21);
            this.labelAlamatOutput.TabIndex = 15;
            this.labelAlamatOutput.Text = ": [Address]";
            // 
            // labelGolonganDarahOutput
            // 
            this.labelGolonganDarahOutput.AutoSize = true;
            this.labelGolonganDarahOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelGolonganDarahOutput.Location = new System.Drawing.Point(209, 123);
            this.labelGolonganDarahOutput.Name = "labelGolonganDarahOutput";
            this.labelGolonganDarahOutput.Size = new System.Drawing.Size(136, 21);
            this.labelGolonganDarahOutput.TabIndex = 14;
            this.labelGolonganDarahOutput.Text = ": [Blood Type]";
            // 
            // labelJenisKelaminOutput
            // 
            this.labelJenisKelaminOutput.AutoSize = true;
            this.labelJenisKelaminOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelJenisKelaminOutput.Location = new System.Drawing.Point(209, 102);
            this.labelJenisKelaminOutput.Name = "labelJenisKelaminOutput";
            this.labelJenisKelaminOutput.Size = new System.Drawing.Size(100, 21);
            this.labelJenisKelaminOutput.TabIndex = 13;
            this.labelJenisKelaminOutput.Text = ": [Gender]";
            // 
            // labelTanggalLahirOutput
            // 
            this.labelTanggalLahirOutput.AutoSize = true;
            this.labelTanggalLahirOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelTanggalLahirOutput.Location = new System.Drawing.Point(209, 81);
            this.labelTanggalLahirOutput.Name = "labelTanggalLahirOutput";
            this.labelTanggalLahirOutput.Size = new System.Drawing.Size(127, 21);
            this.labelTanggalLahirOutput.TabIndex = 12;
            this.labelTanggalLahirOutput.Text = ": [Birthdate]";
            // 
            // labelTempatLahirOutput
            // 
            this.labelTempatLahirOutput.AutoSize = true;
            this.labelTempatLahirOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelTempatLahirOutput.Location = new System.Drawing.Point(209, 60);
            this.labelTempatLahirOutput.Name = "labelTempatLahirOutput";
            this.labelTempatLahirOutput.Size = new System.Drawing.Size(136, 21);
            this.labelTempatLahirOutput.TabIndex = 11;
            this.labelTempatLahirOutput.Text = ": [Birthplace]";
            // 
            // labelNamaOutput
            // 
            this.labelNamaOutput.AutoSize = true;
            this.labelNamaOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelNamaOutput.Location = new System.Drawing.Point(209, 39);
            this.labelNamaOutput.Name = "labelNamaOutput";
            this.labelNamaOutput.Size = new System.Drawing.Size(127, 21);
            this.labelNamaOutput.TabIndex = 10;
            this.labelNamaOutput.Text = ": [Full Name]";
            // 
            // labelKewarganegaraan
            // 
            this.labelKewarganegaraan.AutoSize = true;
            this.labelKewarganegaraan.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelKewarganegaraan.Location = new System.Drawing.Point(12, 229);
            this.labelKewarganegaraan.Name = "labelKewarganegaraan";
            this.labelKewarganegaraan.Size = new System.Drawing.Size(145, 21);
            this.labelKewarganegaraan.TabIndex = 9;
            this.labelKewarganegaraan.Text = "Kewarganegaraan";
            // 
            // labelPekerjaan
            // 
            this.labelPekerjaan.AutoSize = true;
            this.labelPekerjaan.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelPekerjaan.Location = new System.Drawing.Point(12, 208);
            this.labelPekerjaan.Name = "labelPekerjaan";
            this.labelPekerjaan.Size = new System.Drawing.Size(91, 21);
            this.labelPekerjaan.TabIndex = 8;
            this.labelPekerjaan.Text = "Pekerjaan";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelStatus.Location = new System.Drawing.Point(12, 187);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(163, 21);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status Perkawinan";
            // 
            // labelAgama
            // 
            this.labelAgama.AutoSize = true;
            this.labelAgama.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelAgama.Location = new System.Drawing.Point(12, 166);
            this.labelAgama.Name = "labelAgama";
            this.labelAgama.Size = new System.Drawing.Size(55, 21);
            this.labelAgama.TabIndex = 6;
            this.labelAgama.Text = "Agama";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelAlamat.Location = new System.Drawing.Point(12, 144);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(64, 21);
            this.labelAlamat.TabIndex = 5;
            this.labelAlamat.Text = "Alamat";
            // 
            // labelGolonganDarah
            // 
            this.labelGolonganDarah.AutoSize = true;
            this.labelGolonganDarah.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelGolonganDarah.Location = new System.Drawing.Point(12, 123);
            this.labelGolonganDarah.Name = "labelGolonganDarah";
            this.labelGolonganDarah.Size = new System.Drawing.Size(136, 21);
            this.labelGolonganDarah.TabIndex = 4;
            this.labelGolonganDarah.Text = "Golongan Darah";
            // 
            // labelJenisKelamin
            // 
            this.labelJenisKelamin.AutoSize = true;
            this.labelJenisKelamin.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelJenisKelamin.Location = new System.Drawing.Point(12, 102);
            this.labelJenisKelamin.Name = "labelJenisKelamin";
            this.labelJenisKelamin.Size = new System.Drawing.Size(127, 21);
            this.labelJenisKelamin.TabIndex = 3;
            this.labelJenisKelamin.Text = "Jenis Kelamin";
            // 
            // labelTanggalLahir
            // 
            this.labelTanggalLahir.AutoSize = true;
            this.labelTanggalLahir.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelTanggalLahir.Location = new System.Drawing.Point(12, 81);
            this.labelTanggalLahir.Name = "labelTanggalLahir";
            this.labelTanggalLahir.Size = new System.Drawing.Size(127, 21);
            this.labelTanggalLahir.TabIndex = 2;
            this.labelTanggalLahir.Text = "Tanggal Lahir";
            // 
            // labelTempatLahir
            // 
            this.labelTempatLahir.AutoSize = true;
            this.labelTempatLahir.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelTempatLahir.Location = new System.Drawing.Point(12, 60);
            this.labelTempatLahir.Name = "labelTempatLahir";
            this.labelTempatLahir.Size = new System.Drawing.Size(118, 21);
            this.labelTempatLahir.TabIndex = 1;
            this.labelTempatLahir.Text = "Tempat Lahir";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelNama.Location = new System.Drawing.Point(12, 39);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(46, 21);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(1140, 671);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(60, 28);
            this.labelData.TabIndex = 17;
            this.labelData.Text = "Data";
            // 
            // panelExecution
            // 
            this.panelExecution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelExecution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExecution.Controls.Add(this.labelSimilarityOutput);
            this.panelExecution.Controls.Add(this.labelSimilarity);
            this.panelExecution.Controls.Add(this.labelChoosenAlgoOutput);
            this.panelExecution.Controls.Add(this.labelChoosenAlgo);
            this.panelExecution.Controls.Add(this.labelExecTimeOutput);
            this.panelExecution.Controls.Add(this.labelExecTime);
            this.panelExecution.Location = new System.Drawing.Point(890, 468);
            this.panelExecution.Name = "panelExecution";
            this.panelExecution.Size = new System.Drawing.Size(580, 87);
            this.panelExecution.TabIndex = 18;
            // 
            // labelExecTime
            // 
            this.labelExecTime.AutoSize = true;
            this.labelExecTime.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelExecTime.Location = new System.Drawing.Point(12, 9);
            this.labelExecTime.Name = "labelExecTime";
            this.labelExecTime.Size = new System.Drawing.Size(100, 21);
            this.labelExecTime.TabIndex = 20;
            this.labelExecTime.Text = "Time Taken";
            // 
            // labelExecTimeOutput
            // 
            this.labelExecTimeOutput.AutoSize = true;
            this.labelExecTimeOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelExecTimeOutput.Location = new System.Drawing.Point(209, 9);
            this.labelExecTimeOutput.Name = "labelExecTimeOutput";
            this.labelExecTimeOutput.Size = new System.Drawing.Size(127, 21);
            this.labelExecTimeOutput.TabIndex = 21;
            this.labelExecTimeOutput.Text = ": [Exec Time]";
            // 
            // labelChoosenAlgo
            // 
            this.labelChoosenAlgo.AutoSize = true;
            this.labelChoosenAlgo.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelChoosenAlgo.Location = new System.Drawing.Point(12, 30);
            this.labelChoosenAlgo.Name = "labelChoosenAlgo";
            this.labelChoosenAlgo.Size = new System.Drawing.Size(91, 21);
            this.labelChoosenAlgo.TabIndex = 22;
            this.labelChoosenAlgo.Text = "Algorithm";
            // 
            // labelChoosenAlgoOutput
            // 
            this.labelChoosenAlgoOutput.AutoSize = true;
            this.labelChoosenAlgoOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelChoosenAlgoOutput.Location = new System.Drawing.Point(209, 30);
            this.labelChoosenAlgoOutput.Name = "labelChoosenAlgoOutput";
            this.labelChoosenAlgoOutput.Size = new System.Drawing.Size(172, 21);
            this.labelChoosenAlgoOutput.TabIndex = 23;
            this.labelChoosenAlgoOutput.Text = ": [Algorithm Used]";
            // 
            // labelSimilarity
            // 
            this.labelSimilarity.AutoSize = true;
            this.labelSimilarity.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelSimilarity.Location = new System.Drawing.Point(12, 51);
            this.labelSimilarity.Name = "labelSimilarity";
            this.labelSimilarity.Size = new System.Drawing.Size(100, 21);
            this.labelSimilarity.TabIndex = 24;
            this.labelSimilarity.Text = "Similarity";
            // 
            // labelSimilarityOutput
            // 
            this.labelSimilarityOutput.AutoSize = true;
            this.labelSimilarityOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelSimilarityOutput.Location = new System.Drawing.Point(209, 51);
            this.labelSimilarityOutput.Name = "labelSimilarityOutput";
            this.labelSimilarityOutput.Size = new System.Drawing.Size(235, 21);
            this.labelSimilarityOutput.TabIndex = 25;
            this.labelSimilarityOutput.Text = ": [Similarity Percentage]";
            // 
            // labelNIK
            // 
            this.labelNIK.AutoSize = true;
            this.labelNIK.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelNIK.Location = new System.Drawing.Point(12, 18);
            this.labelNIK.Name = "labelNIK";
            this.labelNIK.Size = new System.Drawing.Size(37, 21);
            this.labelNIK.TabIndex = 20;
            this.labelNIK.Text = "NIK";
            // 
            // labelNIKOutput
            // 
            this.labelNIKOutput.AutoSize = true;
            this.labelNIKOutput.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelNIKOutput.Location = new System.Drawing.Point(209, 18);
            this.labelNIKOutput.Name = "labelNIKOutput";
            this.labelNIKOutput.Size = new System.Drawing.Size(127, 21);
            this.labelNIKOutput.TabIndex = 21;
            this.labelNIKOutput.Text = ": [Full Name]";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelExecution);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.pictureBoxOutput);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.panelAlgorithm);
            this.Controls.Add(this.pictureBoxInput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle2);
            this.Controls.Add(this.labelTitle1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form";
            this.Text = "Fingerprint Matcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            this.panelAlgorithm.ResumeLayout(false);
            this.panelAlgorithm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelExecution.ResumeLayout(false);
            this.panelExecution.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.Panel panelAlgorithm;
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.PictureBox pictureBoxOutput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelKewarganegaraanOutput;
        private System.Windows.Forms.Label labelPekerjaanOutput;
        private System.Windows.Forms.Label labelStatusOutput;
        private System.Windows.Forms.Label labelAgamaOutput;
        private System.Windows.Forms.Label labelAlamatOutput;
        private System.Windows.Forms.Label labelGolonganDarahOutput;
        private System.Windows.Forms.Label labelJenisKelaminOutput;
        private System.Windows.Forms.Label labelTanggalLahirOutput;
        private System.Windows.Forms.Label labelTempatLahirOutput;
        private System.Windows.Forms.Label labelNamaOutput;
        private System.Windows.Forms.Label labelKewarganegaraan;
        private System.Windows.Forms.Label labelPekerjaan;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelAgama;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelGolonganDarah;
        private System.Windows.Forms.Label labelJenisKelamin;
        private System.Windows.Forms.Label labelTanggalLahir;
        private System.Windows.Forms.Label labelTempatLahir;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panelExecution;
        private System.Windows.Forms.Label labelExecTimeOutput;
        private System.Windows.Forms.Label labelExecTime;
        private System.Windows.Forms.Label labelSimilarity;
        private System.Windows.Forms.Label labelChoosenAlgoOutput;
        private System.Windows.Forms.Label labelChoosenAlgo;
        private System.Windows.Forms.Label labelSimilarityOutput;
        private System.Windows.Forms.Label labelNIKOutput;
        private System.Windows.Forms.Label labelNIK;
    }
}

