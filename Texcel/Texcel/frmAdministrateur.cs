using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texcel
{
    public partial class frmAdministrateur : Form
    {
        OSController OSControl = new OSController();
        PlateformeController plateformeControl = new PlateformeController();
        JeuController jeuControl = new JeuController();
        EmployeController employeControl = new EmployeController();
        ThemeController themeControl = new ThemeController();
        GenreController genreControl = new GenreController();
        ClassificationController classificationControl = new ClassificationController();

        Validation validation = new Validation();

        public frmAdministrateur()
        {
            InitializeComponent();

            //Ajout des éléments dans les listes déroulantes.
            lstOS.Items.AddRange(OSControl.ListOS.ToArray());
            lstPlateforme.Items.AddRange(plateformeControl.ListPlateforme.ToArray());
            lstTheme.Items.AddRange(themeControl.ListTheme.ToArray());
            lstGenre.Items.AddRange(genreControl.ListGenre.ToArray());
            lstClassification.Items.AddRange(classificationControl.ListClassification.ToArray());
            lstJeux.Items.AddRange(jeuControl.ListJeu.ToArray());
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            if (listView1.SelectedItems.Count > 0)
            {
                dialogResult = MessageBox.Show("Attention! Si vous supprimer un élément, tous les éléments qui y sont liés seront également supprimés." +
                " Êtes-vous sûr de vouloir supprimer cet article?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string primaryKey = listView1.SelectedItems[0].Text;

                    if (radOS.Checked)
                        OSControl.Delete(primaryKey);
                    else if (radPlateforme.Checked)
                        plateformeControl.Delete(primaryKey);
                    else if (radJeu.Checked)                   
                        jeuControl.Delete(primaryKey);                                                                                  
                    else
                        employeControl.Delete(primaryKey);

                    listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                    
                    MessageBox.Show("L'élément '" + primaryKey + "' a bien été supprimer.", "Élément supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }        
            }
            else
                MessageBox.Show("Veuillez sélectionner un élément à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }       

        //Ajoute un élément selon la catégorie d'ajout sélectionnée.
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Plateforme plateforme = (Plateforme)lstPlateforme.SelectedItem;

            switch ((string)lstCategorie.SelectedItem)
            {
                case "OS":
                    if(ValiderTout(grpOS))
                    {
                        try
                        {
                            Insert(OSControl, lstOS, grpOS, new OS(txtNomOs.Text, txtVersionOS.Text, txtCodeOS.Text, txtEditionOS.Text));
                        }
                        catch
                        {
                            MessageBox.Show("Un OS avec le même code existe déjà dans le système.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "Plateforme":
                    if(ValiderTout(grpPlateforme))
                    {
                        try
                        {
                            Insert(plateformeControl, lstPlateforme, grpPlateforme, new Plateforme(txtNomPlateforme.Text, txtConfigPlateforme.Text, txtTypePlateforme.Text, (lstOS.SelectedItem as OS).Code));
                        }
                        catch
                        {
                            MessageBox.Show("Une plateforme avec le même nom existe déjà dans le système.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                   
                    break;
                case "Jeu":
                    if(ValiderTout(grpJeu))
                        try
                        {
                            Jeu jeu = (Jeu)lstJeux.SelectedItem;
                            string nomJeu = "";

                            if (jeu != null)
                                nomJeu = jeu.Nom;

                            Insert(jeuControl, lstJeux, grpJeu, new Jeu(txtNomJeu.Text, txtDeveloppeur.Text, txtDescJeu.Text, txtConfigMin.Text, (lstPlateforme.SelectedItem as Plateforme).Nom, 
                                (lstClassification.SelectedItem as Classification).Nom, (lstGenre.SelectedItem as Genre).Nom, (lstTheme.SelectedItem as Theme).Nom, nomJeu));//Bug null exception
                        }
                        catch
                        {
                            MessageBox.Show("Un jeu avec le même nom existe déjà dans le système.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    break;
                case "Employé":
                    if(ValiderTout(grpEmploye))
                        try
                        {
                            Insert(employeControl, null, grpEmploye, new Employe(txtNomEmploye.Text, txtPrenomEmploye.Text, dtpNaissance.Value.Date.ToString(), txtAdresse.Text, txtTelResidentiel.Text,
                                txtPosteTel.Text, txtMatricule.Text, (string)lstCatEmploi.SelectedItem, txtMotPasse.Text));
                        }
                        catch
                        {
                            MessageBox.Show("Un employé avec le même matricule existe déjà dans le système.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    break;
                case "Thème":
                    if(ValiderTout(grpThemeGenreClass))                   
                        Insert(themeControl, lstTheme, grpThemeGenreClass, new Theme(txtNomThemeGenreClass.Text, txtDescThemeGenreClass.Text));                                      
                    break;
                case "Genre":
                    if (ValiderTout(grpThemeGenreClass))                    
                        Insert(genreControl, lstGenre, grpThemeGenreClass, new Genre(txtNomThemeGenreClass.Text, txtDescThemeGenreClass.Text));                                     
                    break;
                case "Classification":
                    if (ValiderTout(grpThemeGenreClass))                    
                        Insert(classificationControl, lstClassification, grpThemeGenreClass, new Classification(txtNomThemeGenreClass.Text, txtDescThemeGenreClass.Text));
                    break;
            }        
        }

        //Recherche les éléments dans la BD et les affiche dans la ListView.
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            #region Condition 'WHERE'
            string conditionOS, conditionPlateforme, conditionJeu, conditionEmploye;
            conditionOS = "WHERE nom LIKE '%" + txtRecherche.Text + "%' " +
                          "OR versionOS LIKE '%" + txtRecherche.Text + "%' " +
                          "OR codeOS LIKE '%" + txtRecherche.Text + "%' " +
                          "OR edition LIKE '%" + txtRecherche.Text + "%' ";

            conditionPlateforme = "WHERE nom LIKE '%" + txtRecherche.Text + "%' " +
                                  "OR configuration LIKE '%" + txtRecherche.Text + "%' " +
                                  "OR typeConfiguration LIKE '%" + txtRecherche.Text + "%' " +
                                  "OR codeOS LIKE '%" + txtRecherche.Text + "%' ";

            conditionJeu = "WHERE nom LIKE '%" + txtRecherche.Text + "%' " +
                           "OR developpeur LIKE '%" + txtRecherche.Text + "%' " +
                           "OR descriptionJeu LIKE '%" + txtRecherche.Text + "%' " +
                           "OR configMin LIKE '%" + txtRecherche.Text + "%' " +
                           "OR nomGenre LIKE '%" + txtRecherche.Text + "%' " +
                           "OR nomClassification LIKE '%" + txtRecherche.Text + "%' " +
                           "OR nomTheme LIKE '%" + txtRecherche.Text + "%' ";

            conditionEmploye = "WHERE matricule LIKE '%" + txtRecherche.Text + "%' " +
                               "OR nom LIKE '%" + txtRecherche.Text + "%' " +
                               "OR prenom LIKE '%" + txtRecherche.Text + "%' " +
                               "OR dateNaissance LIKE '%" + txtRecherche.Text + "%' " +
                               "OR adresse LIKE '%" + txtRecherche.Text + "%' " +
                               "OR telResidentiel LIKE '%" + txtRecherche.Text + "%' " +
                               "OR posteTelephonique LIKE '%" + txtRecherche.Text + "%' " +
                               "OR titreEmploye LIKE '%" + txtRecherche.Text + "%' ";
            #endregion

            listView1.Items.Clear();

            if (radOS.Checked)
            {             
                OSControl.Select(conditionOS);

                foreach (OS os in OSControl.ListOS)
                {
                    listView1.Items.Add(new ListViewItem(new string[]
                    {
                        os.Code,
                        os.Nom,
                        os.Version,
                        os.Edition
                    }));
                }
            }             
            else if (radPlateforme.Checked)
            {
                plateformeControl.Select(conditionPlateforme);

                foreach(Plateforme plateforme in plateformeControl.ListPlateforme)
                {
                    listView1.Items.Add(new ListViewItem(new string[]
                    {
                        plateforme.Nom,
                        plateforme.Configuration,
                        plateforme.Type,
                        plateforme.CodeOS
                    }));
                }
            }
            else if (radJeu.Checked)
            {
                jeuControl.Select(conditionJeu);

                foreach(Jeu jeu in jeuControl.ListJeu)
                {
                    listView1.Items.Add(new ListViewItem(new string[]
                    {
                        jeu.Nom,
                        jeu.Developpeur,
                        jeu.Description,
                        jeu.ConfigMin,
                        jeu.NomPlateforme,
                        jeu.CodeClassification,
                        jeu.CodeGenre,
                        jeu.CodeTheme,
                        jeu.NomJeuAssocie
                    }
                    ));
                }
            }
            else
            {
                employeControl.Select(conditionEmploye);

                foreach(Employe employe in employeControl.ListEmploye)
                {
                    listView1.Items.Add(new ListViewItem(new string[]
                    {
                        employe.Matricule,
                        employe.Prenom,
                        employe.Nom,
                        employe.DateNaissance,
                        employe.Adresse,
                        employe.TelResidentiel,
                        employe.PosteTelephonique,
                        employe.CategorieEmploi
                    }));
                }
            }
        }



        //Ajoute un élément dans la BD ainsi que dans une liste d'éléments. Les champs sont ensuite vidés.
        private void Insert(Controller controller, ComboBox list, GroupBox grpBox, object champs)
        {
            controller.Insert(champs);

            if(list != null)
                list.Items.Add(champs);

            ViderChamp(grpBox);

            MessageBox.Show("L'élément a bien été ajouté.", "Ajout d'élément", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Change les colonnes du ListView selon le RadioButton coché.
        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
   
            listView1.Clear();
            
            switch (radio.Name)
            {
                case "radOS":
                    listView1.Columns.AddRange(new ColumnHeader[] { colCodeOS, colNom, colVersion, colEdition });
                    break;
                case "radPlateforme":
                    listView1.Columns.AddRange(new ColumnHeader[] { colNom, colConfiguration, colTypeConfig, colCodeOS });
                    break;
                case "radJeu":
                    listView1.Columns.AddRange(new ColumnHeader[] { colNom, colDeveloppeur, colDescription, colConfigMin, colPlateforme, colGenre, colClassification, colTheme, colNomJeuAssocie});
                    break;
                case "radEmploye":
                    listView1.Columns.AddRange(new ColumnHeader[] { colMatricule, colPrenom, colNom, colDdn, colAdresse, colTelResidentiel, colPosteTel, colTitreEmploi });
                    break;
            }
        }

        //Choix de la catégorie d'ajout. (Jeu, OS, plateforme...)
        private void LstCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherCacher(false, grpJeu, grpOS, grpPlateforme, grpEmploye, grpThemeGenreClass);

            switch ((string)lstCategorie.SelectedItem)
            {
                case "OS":
                    AfficherCacher(true, grpOS);
                    break;
                case "Plateforme":
                    AfficherCacher(true, grpPlateforme);
                    break;
                case "Jeu":
                    AfficherCacher(true, grpJeu);
                    break;
                case "Employé":
                    AfficherCacher(true, grpEmploye);
                    break;
                case "Thème":
                    AfficherCacher(true, grpThemeGenreClass);
                    grpThemeGenreClass.Text = "Thème";
                    break;
                case "Genre":
                    AfficherCacher(true, grpThemeGenreClass);
                    grpThemeGenreClass.Text = "Genre";
                    break;
                case "Classification":
                    AfficherCacher(true, grpThemeGenreClass);
                    grpThemeGenreClass.Text = "Classification";
                    break;
            }
        }

        //Affiche-Cache et Active-Désactive un ou plusieurs GroupBox.
        private void AfficherCacher(bool actif, params GroupBox[] grp)
        {
            for (int i = 0; i < grp.Length; i++)
            {
                grp[i].Enabled = actif;
                grp[i].Visible = actif;
            }
        }

        //Génère une erreur sur les champs selon leur vérification lorsqu'ils perdent le focus.
        private void txtBoxFocusChanged(object sender, EventArgs e)
        {
            Control champ = (Control)sender;

            switch(champ.Name)
            {
                case "txtMotPasse":
                    if (validation.VerifierMotPasse(champ.Text))
                        errorProvider1.SetError(champ, "");
                    else
                    {
                        errorProvider1.SetError(champ, "Champ invalide");
                        MessageBox.Show("Le mot de passe doit contenir :\nUn minimum de 8 caractères;\nUn maximum de 18 caractères;\nAu moins une majuscule;\nAu moins une minuscule;\nAu moins un chiffre.",
                            "Mot de passe incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                       
                    break;
                case "txtConfirmPasse":
                    if(validation.ConfirmationMotPasse(txtMotPasse.Text, txtConfirmPasse.Text))
                        errorProvider1.SetError(champ, "");
                    else
                    {
                        errorProvider1.SetError(champ, "Champ invalide");
                        MessageBox.Show("Ce champ doit être identique au mot de passe.", "Confirmation du mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "txtTelResidentiel":
                    if (validation.VerifierNoTel(txtTelResidentiel.Text))
                        errorProvider1.SetError(champ, "");
                    else                    
                        errorProvider1.SetError(champ, "Format : (XXX) XXX-XXXX");                  
                    break;
                case "txtPosteTel":
                    if(validation.VerifierPosteTel(txtPosteTel.Text))
                        errorProvider1.SetError(champ, "");
                    else
                        errorProvider1.SetError(champ, "5 chiffres maximum");
                    break;
                default:
                    if (validation.VerifierChampsCommun(champ.Text))
                        errorProvider1.SetError(champ, "");
                    else
                        errorProvider1.SetError(champ, "Champ invalide");
                    break;
            }                     
        }

        //Valide la totalité des champs.
        private bool ValiderTout(Control groupBox)
        {
            bool valide = true;

            foreach(Control champ in groupBox.Controls)
            {
                switch (champ.Name)
                {
                    case "txtMotPasse":
                        if (!validation.VerifierMotPasse(champ.Text))
                            valide = false;
                        break;
                    case "txtConfirmPasse":
                        if (!validation.ConfirmationMotPasse(txtMotPasse.Text, txtConfirmPasse.Text))
                            valide = false;
                        break;
                    case "txtTelResidentiel":
                        if (!validation.VerifierNoTel(txtTelResidentiel.Text))
                            valide = false;
                        break;
                    case "txtPosteTel":
                        if (!validation.VerifierPosteTel(txtPosteTel.Text))
                            valide = false;
                        break;
                    case "lstJeux": valide = true;
                        break;
                    default:
                        if (!validation.VerifierChampsCommun(champ.Text))
                            valide = false;
                        break;
                }
            }

            if (!valide)
                MessageBox.Show("Veuillez remplir tous les champs correctement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return valide;
        }

        //Vide les champs.
        private void ViderChamp(Control groupBox)
        {
            foreach(Control champ in groupBox.Controls)
            {
                if ((champ is TextBox) || (champ is RichTextBox))         
                    champ.Text = "";                
                else if (champ is ComboBox)
                    (champ as ComboBox).SelectedIndex = -1;
            }
        }

        //Ferme l'application.
        private void frmAdministrateur_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        //Retourne au menu de connexion.
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            frmConnexion connexion = new frmConnexion();

            this.Hide();
            connexion.Show();
        }
    }
}
