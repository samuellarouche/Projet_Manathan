namespace Texcel
{
    partial class frmAdministrateur
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRecherche = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chkTout = new System.Windows.Forms.CheckBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.chkEmploye = new System.Windows.Forms.CheckBox();
            this.chkOS = new System.Windows.Forms.CheckBox();
            this.chkPlateforme = new System.Windows.Forms.CheckBox();
            this.chkJeu = new System.Windows.Forms.CheckBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.tabAjout = new System.Windows.Forms.TabPage();
            this.grpEmploye = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lstCatEmploi = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtPosteTel = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTelResidentiel = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNomEmploye = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPrenomEmploye = new System.Windows.Forms.TextBox();
            this.grpPlateforme = new System.Windows.Forms.GroupBox();
            this.lstOS = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTypePlateforme = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtConfigPlateforme = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNomPlateforme = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.grpOS = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEditionOS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodeOS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVersionOS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNomOs = new System.Windows.Forms.TextBox();
            this.lstCategorie = new System.Windows.Forms.ComboBox();
            this.grpJeu = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstClassification = new System.Windows.Forms.ComboBox();
            this.lstGenre = new System.Windows.Forms.ComboBox();
            this.lstTheme = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstPlateforme = new System.Windows.Forms.ComboBox();
            this.txtConfigMin = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescJeu = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeveloppeur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomJeu = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabRecherche.SuspendLayout();
            this.tabAjout.SuspendLayout();
            this.grpEmploye.SuspendLayout();
            this.grpPlateforme.SuspendLayout();
            this.grpOS.SuspendLayout();
            this.grpJeu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRecherche);
            this.tabControl1.Controls.Add(this.tabAjout);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRecherche
            // 
            this.tabRecherche.Controls.Add(this.listView1);
            this.tabRecherche.Controls.Add(this.chkTout);
            this.tabRecherche.Controls.Add(this.btnRechercher);
            this.tabRecherche.Controls.Add(this.chkEmploye);
            this.tabRecherche.Controls.Add(this.chkOS);
            this.tabRecherche.Controls.Add(this.chkPlateforme);
            this.tabRecherche.Controls.Add(this.chkJeu);
            this.tabRecherche.Controls.Add(this.txtRecherche);
            this.tabRecherche.Location = new System.Drawing.Point(4, 22);
            this.tabRecherche.Name = "tabRecherche";
            this.tabRecherche.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecherche.Size = new System.Drawing.Size(540, 367);
            this.tabRecherche.TabIndex = 0;
            this.tabRecherche.Text = "Recherche";
            this.tabRecherche.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(8, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(524, 303);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // chkTout
            // 
            this.chkTout.AutoSize = true;
            this.chkTout.Checked = true;
            this.chkTout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTout.Location = new System.Drawing.Point(8, 32);
            this.chkTout.Name = "chkTout";
            this.chkTout.Size = new System.Drawing.Size(48, 17);
            this.chkTout.TabIndex = 7;
            this.chkTout.Text = "Tout";
            this.chkTout.UseVisualStyleBackColor = true;
            this.chkTout.CheckedChanged += new System.EventHandler(this.chkTout_CheckedChanged);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(408, 6);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(124, 20);
            this.btnRechercher.TabIndex = 6;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // chkEmploye
            // 
            this.chkEmploye.AutoSize = true;
            this.chkEmploye.Checked = true;
            this.chkEmploye.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmploye.Location = new System.Drawing.Point(240, 32);
            this.chkEmploye.Name = "chkEmploye";
            this.chkEmploye.Size = new System.Drawing.Size(66, 17);
            this.chkEmploye.TabIndex = 4;
            this.chkEmploye.Text = "Employé";
            this.chkEmploye.UseVisualStyleBackColor = true;
            // 
            // chkOS
            // 
            this.chkOS.AutoSize = true;
            this.chkOS.Checked = true;
            this.chkOS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOS.Location = new System.Drawing.Point(62, 32);
            this.chkOS.Name = "chkOS";
            this.chkOS.Size = new System.Drawing.Size(41, 17);
            this.chkOS.TabIndex = 3;
            this.chkOS.Text = "OS";
            this.chkOS.UseVisualStyleBackColor = true;
            // 
            // chkPlateforme
            // 
            this.chkPlateforme.AutoSize = true;
            this.chkPlateforme.Checked = true;
            this.chkPlateforme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlateforme.Location = new System.Drawing.Point(109, 32);
            this.chkPlateforme.Name = "chkPlateforme";
            this.chkPlateforme.Size = new System.Drawing.Size(76, 17);
            this.chkPlateforme.TabIndex = 2;
            this.chkPlateforme.Text = "Plateforme";
            this.chkPlateforme.UseVisualStyleBackColor = true;
            // 
            // chkJeu
            // 
            this.chkJeu.AutoSize = true;
            this.chkJeu.Checked = true;
            this.chkJeu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJeu.Location = new System.Drawing.Point(191, 32);
            this.chkJeu.Name = "chkJeu";
            this.chkJeu.Size = new System.Drawing.Size(43, 17);
            this.chkJeu.TabIndex = 1;
            this.chkJeu.Text = "Jeu";
            this.chkJeu.UseVisualStyleBackColor = true;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(8, 6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(394, 20);
            this.txtRecherche.TabIndex = 0;
            // 
            // tabAjout
            // 
            this.tabAjout.Controls.Add(this.btnAjouter);
            this.tabAjout.Controls.Add(this.label10);
            this.tabAjout.Controls.Add(this.lstCategorie);
            this.tabAjout.Controls.Add(this.grpEmploye);
            this.tabAjout.Controls.Add(this.grpPlateforme);
            this.tabAjout.Controls.Add(this.grpOS);
            this.tabAjout.Controls.Add(this.grpJeu);
            this.tabAjout.Location = new System.Drawing.Point(4, 22);
            this.tabAjout.Name = "tabAjout";
            this.tabAjout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjout.Size = new System.Drawing.Size(540, 367);
            this.tabAjout.TabIndex = 1;
            this.tabAjout.Text = "Ajout";
            this.tabAjout.UseVisualStyleBackColor = true;
            // 
            // grpEmploye
            // 
            this.grpEmploye.Controls.Add(this.label26);
            this.grpEmploye.Controls.Add(this.lstCatEmploi);
            this.grpEmploye.Controls.Add(this.label25);
            this.grpEmploye.Controls.Add(this.txtMatricule);
            this.grpEmploye.Controls.Add(this.label24);
            this.grpEmploye.Controls.Add(this.txtPosteTel);
            this.grpEmploye.Controls.Add(this.label23);
            this.grpEmploye.Controls.Add(this.txtTelResidentiel);
            this.grpEmploye.Controls.Add(this.label21);
            this.grpEmploye.Controls.Add(this.txtAdresse);
            this.grpEmploye.Controls.Add(this.dtpNaissance);
            this.grpEmploye.Controls.Add(this.label20);
            this.grpEmploye.Controls.Add(this.label19);
            this.grpEmploye.Controls.Add(this.txtNomEmploye);
            this.grpEmploye.Controls.Add(this.label22);
            this.grpEmploye.Controls.Add(this.txtPrenomEmploye);
            this.grpEmploye.Enabled = false;
            this.grpEmploye.Location = new System.Drawing.Point(51, 52);
            this.grpEmploye.Name = "grpEmploye";
            this.grpEmploye.Size = new System.Drawing.Size(434, 261);
            this.grpEmploye.TabIndex = 25;
            this.grpEmploye.TabStop = false;
            this.grpEmploye.Text = "Employé";
            this.grpEmploye.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(284, 190);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 13);
            this.label26.TabIndex = 15;
            this.label26.Text = "Catégorie d\'emploi";
            // 
            // lstCatEmploi
            // 
            this.lstCatEmploi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCatEmploi.FormattingEnabled = true;
            this.lstCatEmploi.Items.AddRange(new object[] {
            "Testeur",
            "Chef",
            "Directeur",
            "Administrateur"});
            this.lstCatEmploi.Location = new System.Drawing.Point(229, 206);
            this.lstCatEmploi.Name = "lstCatEmploi";
            this.lstCatEmploi.Size = new System.Drawing.Size(199, 21);
            this.lstCatEmploi.TabIndex = 14;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(80, 192);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 13);
            this.label25.TabIndex = 13;
            this.label25.Text = "Matricule";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(7, 208);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(199, 20);
            this.txtMatricule.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(281, 140);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "Poste téléphonique";
            // 
            // txtPosteTel
            // 
            this.txtPosteTel.Location = new System.Drawing.Point(229, 156);
            this.txtPosteTel.Name = "txtPosteTel";
            this.txtPosteTel.Size = new System.Drawing.Size(199, 20);
            this.txtPosteTel.TabIndex = 10;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(52, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Téléphone résidentiel";
            // 
            // txtTelResidentiel
            // 
            this.txtTelResidentiel.Location = new System.Drawing.Point(7, 156);
            this.txtTelResidentiel.Name = "txtTelResidentiel";
            this.txtTelResidentiel.Size = new System.Drawing.Size(199, 20);
            this.txtTelResidentiel.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(305, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "Adresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(229, 99);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(199, 20);
            this.txtAdresse.TabIndex = 6;
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Location = new System.Drawing.Point(6, 100);
            this.dtpNaissance.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(199, 20);
            this.dtpNaissance.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(57, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Date de naissance";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(313, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Nom";
            // 
            // txtNomEmploye
            // 
            this.txtNomEmploye.Location = new System.Drawing.Point(229, 42);
            this.txtNomEmploye.Name = "txtNomEmploye";
            this.txtNomEmploye.Size = new System.Drawing.Size(199, 20);
            this.txtNomEmploye.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(82, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Prenom";
            // 
            // txtPrenomEmploye
            // 
            this.txtPrenomEmploye.Location = new System.Drawing.Point(6, 42);
            this.txtPrenomEmploye.Name = "txtPrenomEmploye";
            this.txtPrenomEmploye.Size = new System.Drawing.Size(199, 20);
            this.txtPrenomEmploye.TabIndex = 0;
            // 
            // grpPlateforme
            // 
            this.grpPlateforme.Controls.Add(this.lstOS);
            this.grpPlateforme.Controls.Add(this.label15);
            this.grpPlateforme.Controls.Add(this.label16);
            this.grpPlateforme.Controls.Add(this.txtTypePlateforme);
            this.grpPlateforme.Controls.Add(this.label17);
            this.grpPlateforme.Controls.Add(this.txtConfigPlateforme);
            this.grpPlateforme.Controls.Add(this.label18);
            this.grpPlateforme.Controls.Add(this.txtNomPlateforme);
            this.grpPlateforme.Enabled = false;
            this.grpPlateforme.Location = new System.Drawing.Point(51, 52);
            this.grpPlateforme.Name = "grpPlateforme";
            this.grpPlateforme.Size = new System.Drawing.Size(434, 261);
            this.grpPlateforme.TabIndex = 24;
            this.grpPlateforme.TabStop = false;
            this.grpPlateforme.Text = "Plateforme";
            this.grpPlateforme.Visible = false;
            // 
            // lstOS
            // 
            this.lstOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstOS.FormattingEnabled = true;
            this.lstOS.Location = new System.Drawing.Point(116, 207);
            this.lstOS.Name = "lstOS";
            this.lstOS.Size = new System.Drawing.Size(199, 21);
            this.lstOS.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(203, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "OS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(198, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Type";
            // 
            // txtTypePlateforme
            // 
            this.txtTypePlateforme.Location = new System.Drawing.Point(116, 155);
            this.txtTypePlateforme.Name = "txtTypePlateforme";
            this.txtTypePlateforme.Size = new System.Drawing.Size(199, 20);
            this.txtTypePlateforme.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(181, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Configuration";
            // 
            // txtConfigPlateforme
            // 
            this.txtConfigPlateforme.Location = new System.Drawing.Point(116, 100);
            this.txtConfigPlateforme.Name = "txtConfigPlateforme";
            this.txtConfigPlateforme.Size = new System.Drawing.Size(199, 20);
            this.txtConfigPlateforme.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(199, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Nom";
            // 
            // txtNomPlateforme
            // 
            this.txtNomPlateforme.Location = new System.Drawing.Point(116, 48);
            this.txtNomPlateforme.Name = "txtNomPlateforme";
            this.txtNomPlateforme.Size = new System.Drawing.Size(199, 20);
            this.txtNomPlateforme.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(167, 319);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(199, 40);
            this.btnAjouter.TabIndex = 23;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Catégorie";
            // 
            // grpOS
            // 
            this.grpOS.Controls.Add(this.label14);
            this.grpOS.Controls.Add(this.txtEditionOS);
            this.grpOS.Controls.Add(this.label13);
            this.grpOS.Controls.Add(this.txtCodeOS);
            this.grpOS.Controls.Add(this.label12);
            this.grpOS.Controls.Add(this.txtVersionOS);
            this.grpOS.Controls.Add(this.label11);
            this.grpOS.Controls.Add(this.txtNomOs);
            this.grpOS.Enabled = false;
            this.grpOS.Location = new System.Drawing.Point(51, 52);
            this.grpOS.Name = "grpOS";
            this.grpOS.Size = new System.Drawing.Size(434, 261);
            this.grpOS.TabIndex = 22;
            this.grpOS.TabStop = false;
            this.grpOS.Text = "OS";
            this.grpOS.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(195, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Édition";
            // 
            // txtEditionOS
            // 
            this.txtEditionOS.Location = new System.Drawing.Point(116, 208);
            this.txtEditionOS.Name = "txtEditionOS";
            this.txtEditionOS.Size = new System.Drawing.Size(199, 20);
            this.txtEditionOS.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Code";
            // 
            // txtCodeOS
            // 
            this.txtCodeOS.Location = new System.Drawing.Point(116, 155);
            this.txtCodeOS.Name = "txtCodeOS";
            this.txtCodeOS.Size = new System.Drawing.Size(199, 20);
            this.txtCodeOS.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(193, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Version";
            // 
            // txtVersionOS
            // 
            this.txtVersionOS.Location = new System.Drawing.Point(116, 100);
            this.txtVersionOS.Name = "txtVersionOS";
            this.txtVersionOS.Size = new System.Drawing.Size(199, 20);
            this.txtVersionOS.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nom";
            // 
            // txtNomOs
            // 
            this.txtNomOs.Location = new System.Drawing.Point(116, 48);
            this.txtNomOs.Name = "txtNomOs";
            this.txtNomOs.Size = new System.Drawing.Size(199, 20);
            this.txtNomOs.TabIndex = 0;
            // 
            // lstCategorie
            // 
            this.lstCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCategorie.FormattingEnabled = true;
            this.lstCategorie.Items.AddRange(new object[] {
            "OS",
            "Plateforme",
            "Jeu",
            "Employé"});
            this.lstCategorie.Location = new System.Drawing.Point(167, 24);
            this.lstCategorie.Name = "lstCategorie";
            this.lstCategorie.Size = new System.Drawing.Size(199, 21);
            this.lstCategorie.TabIndex = 0;
            this.lstCategorie.SelectedIndexChanged += new System.EventHandler(this.LstCategorie_SelectedIndexChanged);
            // 
            // grpJeu
            // 
            this.grpJeu.Controls.Add(this.label9);
            this.grpJeu.Controls.Add(this.label8);
            this.grpJeu.Controls.Add(this.label7);
            this.grpJeu.Controls.Add(this.lstClassification);
            this.grpJeu.Controls.Add(this.lstGenre);
            this.grpJeu.Controls.Add(this.lstTheme);
            this.grpJeu.Controls.Add(this.label6);
            this.grpJeu.Controls.Add(this.lstPlateforme);
            this.grpJeu.Controls.Add(this.txtConfigMin);
            this.grpJeu.Controls.Add(this.label4);
            this.grpJeu.Controls.Add(this.txtDescJeu);
            this.grpJeu.Controls.Add(this.label3);
            this.grpJeu.Controls.Add(this.label2);
            this.grpJeu.Controls.Add(this.txtDeveloppeur);
            this.grpJeu.Controls.Add(this.label1);
            this.grpJeu.Controls.Add(this.txtNomJeu);
            this.grpJeu.Enabled = false;
            this.grpJeu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grpJeu.Location = new System.Drawing.Point(51, 52);
            this.grpJeu.Name = "grpJeu";
            this.grpJeu.Size = new System.Drawing.Size(434, 261);
            this.grpJeu.TabIndex = 1;
            this.grpJeu.TabStop = false;
            this.grpJeu.Text = "Jeu";
            this.grpJeu.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Genre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Classification";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Thème";
            // 
            // lstClassification
            // 
            this.lstClassification.FormattingEnabled = true;
            this.lstClassification.Location = new System.Drawing.Point(307, 224);
            this.lstClassification.Name = "lstClassification";
            this.lstClassification.Size = new System.Drawing.Size(121, 21);
            this.lstClassification.TabIndex = 18;
            // 
            // lstGenre
            // 
            this.lstGenre.FormattingEnabled = true;
            this.lstGenre.Location = new System.Drawing.Point(157, 224);
            this.lstGenre.Name = "lstGenre";
            this.lstGenre.Size = new System.Drawing.Size(121, 21);
            this.lstGenre.TabIndex = 17;
            // 
            // lstTheme
            // 
            this.lstTheme.FormattingEnabled = true;
            this.lstTheme.Location = new System.Drawing.Point(7, 224);
            this.lstTheme.Name = "lstTheme";
            this.lstTheme.Size = new System.Drawing.Size(121, 21);
            this.lstTheme.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Plateforme";
            // 
            // lstPlateforme
            // 
            this.lstPlateforme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPlateforme.FormattingEnabled = true;
            this.lstPlateforme.Location = new System.Drawing.Point(124, 171);
            this.lstPlateforme.Name = "lstPlateforme";
            this.lstPlateforme.Size = new System.Drawing.Size(186, 21);
            this.lstPlateforme.TabIndex = 13;
            // 
            // txtConfigMin
            // 
            this.txtConfigMin.Location = new System.Drawing.Point(242, 81);
            this.txtConfigMin.Name = "txtConfigMin";
            this.txtConfigMin.Size = new System.Drawing.Size(186, 62);
            this.txtConfigMin.TabIndex = 11;
            this.txtConfigMin.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Configuration Minimal";
            // 
            // txtDescJeu
            // 
            this.txtDescJeu.Location = new System.Drawing.Point(7, 81);
            this.txtDescJeu.Name = "txtDescJeu";
            this.txtDescJeu.Size = new System.Drawing.Size(186, 62);
            this.txtDescJeu.TabIndex = 9;
            this.txtDescJeu.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Développeur";
            // 
            // txtDeveloppeur
            // 
            this.txtDeveloppeur.Location = new System.Drawing.Point(242, 32);
            this.txtDeveloppeur.Name = "txtDeveloppeur";
            this.txtDeveloppeur.Size = new System.Drawing.Size(186, 20);
            this.txtDeveloppeur.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // txtNomJeu
            // 
            this.txtNomJeu.Location = new System.Drawing.Point(7, 32);
            this.txtNomJeu.Name = "txtNomJeu";
            this.txtNomJeu.Size = new System.Drawing.Size(186, 20);
            this.txtNomJeu.TabIndex = 0;
            // 
            // frmAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 393);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdministrateur";
            this.Text = "Texcel - Administrateur";
            this.tabControl1.ResumeLayout(false);
            this.tabRecherche.ResumeLayout(false);
            this.tabRecherche.PerformLayout();
            this.tabAjout.ResumeLayout(false);
            this.tabAjout.PerformLayout();
            this.grpEmploye.ResumeLayout(false);
            this.grpEmploye.PerformLayout();
            this.grpPlateforme.ResumeLayout(false);
            this.grpPlateforme.PerformLayout();
            this.grpOS.ResumeLayout(false);
            this.grpOS.PerformLayout();
            this.grpJeu.ResumeLayout(false);
            this.grpJeu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.CheckBox chkEmploye;
        private System.Windows.Forms.CheckBox chkOS;
        private System.Windows.Forms.CheckBox chkPlateforme;
        private System.Windows.Forms.CheckBox chkJeu;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.TabPage tabAjout;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox chkTout;
        private System.Windows.Forms.ComboBox lstCategorie;
        private System.Windows.Forms.GroupBox grpJeu;
        private System.Windows.Forms.TextBox txtNomJeu;
        private System.Windows.Forms.ComboBox lstPlateforme;
        private System.Windows.Forms.RichTextBox txtConfigMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtDescJeu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeveloppeur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox lstClassification;
        private System.Windows.Forms.ComboBox lstGenre;
        private System.Windows.Forms.ComboBox lstTheme;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpOS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEditionOS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodeOS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVersionOS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNomOs;
        private System.Windows.Forms.GroupBox grpPlateforme;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTypePlateforme;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtConfigPlateforme;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNomPlateforme;
        private System.Windows.Forms.ComboBox lstOS;
        private System.Windows.Forms.GroupBox grpEmploye;
        private System.Windows.Forms.TextBox txtNomEmploye;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPrenomEmploye;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtPosteTel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtTelResidentiel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox lstCatEmploi;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtMatricule;
    }
}