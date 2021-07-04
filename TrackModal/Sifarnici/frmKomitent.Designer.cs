namespace TrackModal.Sifarnici
{
    partial class frmKomitent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKomitent));
            this.chkBrodar = new System.Windows.Forms.CheckBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUgovor = new System.Windows.Forms.ToolStrip();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPrvi = new System.Windows.Forms.ToolStripButton();
            this.tsNazad = new System.Windows.Forms.ToolStripButton();
            this.tsNapred = new System.Windows.Forms.ToolStripButton();
            this.tsPoslednja = new System.Windows.Forms.ToolStripButton();
            this.tsUgovor = new System.Windows.Forms.ToolStripButton();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKontaktOsoba = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkPosiljalac = new System.Windows.Forms.CheckBox();
            this.chkPrimalac = new System.Windows.Forms.CheckBox();
            this.chkPlatilac = new System.Windows.Forms.CheckBox();
            this.chkOrganizator = new System.Windows.Forms.CheckBox();
            this.chkVlasnik = new System.Windows.Forms.CheckBox();
            this.chkOperator = new System.Windows.Forms.CheckBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSifraERP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPIB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaticniBroj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUgovor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBrodar
            // 
            this.chkBrodar.AutoSize = true;
            this.chkBrodar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkBrodar.ForeColor = System.Drawing.Color.White;
            this.chkBrodar.Location = new System.Drawing.Point(834, 57);
            this.chkBrodar.Name = "chkBrodar";
            this.chkBrodar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBrodar.Size = new System.Drawing.Size(70, 20);
            this.chkBrodar.TabIndex = 15;
            this.chkBrodar.Text = "Brodar";
            this.chkBrodar.UseVisualStyleBackColor = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNaziv.Location = new System.Drawing.Point(135, 115);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(223, 22);
            this.txtNaziv.TabIndex = 12;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNaziv.ForeColor = System.Drawing.Color.White;
            this.lblNaziv.Location = new System.Drawing.Point(29, 118);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(47, 16);
            this.lblNaziv.TabIndex = 14;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtSifra
            // 
            this.txtSifra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSifra.Location = new System.Drawing.Point(135, 57);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(88, 22);
            this.txtSifra.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Šifra:";
            // 
            // btnUgovor
            // 
            this.btnUgovor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUgovor.BackgroundImage")));
            this.btnUgovor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNew,
            this.tsSave,
            this.tsDelete,
            this.toolStripSeparator1,
            this.tsPrvi,
            this.tsNazad,
            this.tsNapred,
            this.tsPoslednja,
            this.tsUgovor});
            this.btnUgovor.Location = new System.Drawing.Point(0, 0);
            this.btnUgovor.Name = "btnUgovor";
            this.btnUgovor.Size = new System.Drawing.Size(1370, 25);
            this.btnUgovor.TabIndex = 109;
            this.btnUgovor.Text = "Komitent ugovor";
            // 
            // tsNew
            // 
            this.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNew.Image = ((System.Drawing.Image)(resources.GetObject("tsNew.Image")));
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(23, 22);
            this.tsNew.Text = "Novi";
            this.tsNew.Click += new System.EventHandler(this.tsNew_Click);
            // 
            // tsSave
            // 
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSave.Image = ((System.Drawing.Image)(resources.GetObject("tsSave.Image")));
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(23, 22);
            this.tsSave.Text = "tsSave";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsDelete.Image")));
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(23, 22);
            this.tsDelete.Text = "toolStripButton1";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsPrvi
            // 
            this.tsPrvi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPrvi.Image = ((System.Drawing.Image)(resources.GetObject("tsPrvi.Image")));
            this.tsPrvi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrvi.Name = "tsPrvi";
            this.tsPrvi.Size = new System.Drawing.Size(23, 22);
            this.tsPrvi.Text = "toolStripButton1";
            this.tsPrvi.Click += new System.EventHandler(this.tsPrvi_Click);
            // 
            // tsNazad
            // 
            this.tsNazad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNazad.Image = ((System.Drawing.Image)(resources.GetObject("tsNazad.Image")));
            this.tsNazad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNazad.Name = "tsNazad";
            this.tsNazad.Size = new System.Drawing.Size(23, 22);
            this.tsNazad.Text = "toolStripButton1";
            this.tsNazad.Click += new System.EventHandler(this.tsNazad_Click);
            // 
            // tsNapred
            // 
            this.tsNapred.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNapred.Image = ((System.Drawing.Image)(resources.GetObject("tsNapred.Image")));
            this.tsNapred.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNapred.Name = "tsNapred";
            this.tsNapred.Size = new System.Drawing.Size(23, 22);
            this.tsNapred.Text = "toolStripButton1";
            this.tsNapred.Click += new System.EventHandler(this.tsNapred_Click);
            // 
            // tsPoslednja
            // 
            this.tsPoslednja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPoslednja.Image = ((System.Drawing.Image)(resources.GetObject("tsPoslednja.Image")));
            this.tsPoslednja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPoslednja.Name = "tsPoslednja";
            this.tsPoslednja.Size = new System.Drawing.Size(23, 22);
            this.tsPoslednja.Text = "toolStripButton1";
            this.tsPoslednja.Click += new System.EventHandler(this.tsPoslednja_Click);
            // 
            // tsUgovor
            // 
            this.tsUgovor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsUgovor.ForeColor = System.Drawing.Color.White;
            this.tsUgovor.Image = ((System.Drawing.Image)(resources.GetObject("tsUgovor.Image")));
            this.tsUgovor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUgovor.Name = "tsUgovor";
            this.tsUgovor.Size = new System.Drawing.Size(73, 22);
            this.tsUgovor.Text = "Ugovor";
            this.tsUgovor.Click += new System.EventHandler(this.tsUgovor_Click);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAdresa.Location = new System.Drawing.Point(135, 144);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(223, 22);
            this.txtAdresa.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 111;
            this.label2.Text = "Adresa";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTelefon.Location = new System.Drawing.Point(135, 173);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(223, 22);
            this.txtTelefon.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 113;
            this.label3.Text = "Telefon";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtemail.Location = new System.Drawing.Point(135, 202);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(223, 22);
            this.txtemail.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 115;
            this.label4.Text = "E-mail";
            // 
            // txtKontaktOsoba
            // 
            this.txtKontaktOsoba.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtKontaktOsoba.Location = new System.Drawing.Point(526, 113);
            this.txtKontaktOsoba.Name = "txtKontaktOsoba";
            this.txtKontaktOsoba.Size = new System.Drawing.Size(223, 22);
            this.txtKontaktOsoba.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(403, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 117;
            this.label5.Text = "Kontakt osoba";
            // 
            // chkPosiljalac
            // 
            this.chkPosiljalac.AutoSize = true;
            this.chkPosiljalac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkPosiljalac.ForeColor = System.Drawing.Color.White;
            this.chkPosiljalac.Location = new System.Drawing.Point(823, 86);
            this.chkPosiljalac.Name = "chkPosiljalac";
            this.chkPosiljalac.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPosiljalac.Size = new System.Drawing.Size(81, 20);
            this.chkPosiljalac.TabIndex = 118;
            this.chkPosiljalac.Text = "Špediter";
            this.chkPosiljalac.UseVisualStyleBackColor = true;
            // 
            // chkPrimalac
            // 
            this.chkPrimalac.AutoSize = true;
            this.chkPrimalac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkPrimalac.ForeColor = System.Drawing.Color.White;
            this.chkPrimalac.Location = new System.Drawing.Point(820, 115);
            this.chkPrimalac.Name = "chkPrimalac";
            this.chkPrimalac.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPrimalac.Size = new System.Drawing.Size(84, 20);
            this.chkPrimalac.TabIndex = 119;
            this.chkPrimalac.Text = "Primalac";
            this.chkPrimalac.UseVisualStyleBackColor = true;
            // 
            // chkPlatilac
            // 
            this.chkPlatilac.AutoSize = true;
            this.chkPlatilac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkPlatilac.ForeColor = System.Drawing.Color.White;
            this.chkPlatilac.Location = new System.Drawing.Point(829, 144);
            this.chkPlatilac.Name = "chkPlatilac";
            this.chkPlatilac.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPlatilac.Size = new System.Drawing.Size(75, 20);
            this.chkPlatilac.TabIndex = 120;
            this.chkPlatilac.Text = "Platilac";
            this.chkPlatilac.UseVisualStyleBackColor = true;
            // 
            // chkOrganizator
            // 
            this.chkOrganizator.AutoSize = true;
            this.chkOrganizator.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkOrganizator.ForeColor = System.Drawing.Color.White;
            this.chkOrganizator.Location = new System.Drawing.Point(802, 173);
            this.chkOrganizator.Name = "chkOrganizator";
            this.chkOrganizator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkOrganizator.Size = new System.Drawing.Size(102, 20);
            this.chkOrganizator.TabIndex = 121;
            this.chkOrganizator.Text = "Organizator";
            this.chkOrganizator.UseVisualStyleBackColor = true;
            // 
            // chkVlasnik
            // 
            this.chkVlasnik.AutoSize = true;
            this.chkVlasnik.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkVlasnik.ForeColor = System.Drawing.Color.White;
            this.chkVlasnik.Location = new System.Drawing.Point(831, 202);
            this.chkVlasnik.Name = "chkVlasnik";
            this.chkVlasnik.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkVlasnik.Size = new System.Drawing.Size(73, 20);
            this.chkVlasnik.TabIndex = 122;
            this.chkVlasnik.Text = "Vlasnik";
            this.chkVlasnik.UseVisualStyleBackColor = true;
            // 
            // chkOperator
            // 
            this.chkOperator.AutoSize = true;
            this.chkOperator.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkOperator.ForeColor = System.Drawing.Color.White;
            this.chkOperator.Location = new System.Drawing.Point(821, 231);
            this.chkOperator.Name = "chkOperator";
            this.chkOperator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkOperator.Size = new System.Drawing.Size(83, 20);
            this.chkOperator.TabIndex = 123;
            this.chkOperator.Text = "Operater";
            this.chkOperator.UseVisualStyleBackColor = true;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNapomena.Location = new System.Drawing.Point(1024, 57);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(323, 132);
            this.txtNapomena.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(941, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 125;
            this.label6.Text = "Napomena";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1315, 259);
            this.dataGridView1.TabIndex = 126;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtSifraERP
            // 
            this.txtSifraERP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSifraERP.Location = new System.Drawing.Point(135, 86);
            this.txtSifraERP.Name = "txtSifraERP";
            this.txtSifraERP.Size = new System.Drawing.Size(88, 22);
            this.txtSifraERP.TabIndex = 127;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 128;
            this.label7.Text = "Šifra ERP:";
            // 
            // txtPIB
            // 
            this.txtPIB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPIB.Location = new System.Drawing.Point(526, 141);
            this.txtPIB.Name = "txtPIB";
            this.txtPIB.Size = new System.Drawing.Size(223, 22);
            this.txtPIB.TabIndex = 129;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(403, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 130;
            this.label8.Text = "PIB:";
            // 
            // txtMaticniBroj
            // 
            this.txtMaticniBroj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMaticniBroj.Location = new System.Drawing.Point(526, 170);
            this.txtMaticniBroj.Name = "txtMaticniBroj";
            this.txtMaticniBroj.Size = new System.Drawing.Size(223, 22);
            this.txtMaticniBroj.TabIndex = 131;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(403, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 132;
            this.label9.Text = "Matični broj:";
            // 
            // txtTR
            // 
            this.txtTR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTR.Location = new System.Drawing.Point(526, 199);
            this.txtTR.Name = "txtTR";
            this.txtTR.Size = new System.Drawing.Size(223, 22);
            this.txtTR.TabIndex = 133;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(403, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 134;
            this.label10.Text = "TR:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1206, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 50);
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            // 
            // frmKomitent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1370, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTR);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaticniBroj);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPIB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSifraERP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkOperator);
            this.Controls.Add(this.chkVlasnik);
            this.Controls.Add(this.chkOrganizator);
            this.Controls.Add(this.chkPlatilac);
            this.Controls.Add(this.chkPrimalac);
            this.Controls.Add(this.chkPosiljalac);
            this.Controls.Add(this.txtKontaktOsoba);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUgovor);
            this.Controls.Add(this.chkBrodar);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmKomitent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Komitent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKomitent_Load);
            this.btnUgovor.ResumeLayout(false);
            this.btnUgovor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBrodar;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip btnUgovor;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsPrvi;
        private System.Windows.Forms.ToolStripButton tsNazad;
        private System.Windows.Forms.ToolStripButton tsNapred;
        private System.Windows.Forms.ToolStripButton tsPoslednja;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKontaktOsoba;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPosiljalac;
        private System.Windows.Forms.CheckBox chkPrimalac;
        private System.Windows.Forms.CheckBox chkPlatilac;
        private System.Windows.Forms.CheckBox chkOrganizator;
        private System.Windows.Forms.CheckBox chkVlasnik;
        private System.Windows.Forms.CheckBox chkOperator;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton tsUgovor;
        private System.Windows.Forms.TextBox txtSifraERP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPIB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaticniBroj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}