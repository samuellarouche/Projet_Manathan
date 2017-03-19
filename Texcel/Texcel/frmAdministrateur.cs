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

        //Checker si je les mets tous dans le même controller.
        ThemeController themeControl = new ThemeController();
        GenreController genreControl = new GenreController();
        ClassificationController classificationControl = new ClassificationController();

        public frmAdministrateur()
        {
            InitializeComponent();

            //Ajout des éléments dans les listes déroulantes.
            lstOS.Items.AddRange(OSControl.ListOS.ToArray());
            lstPlateforme.Items.AddRange(plateformeControl.ListPlateforme.ToArray());
            lstTheme.Items.AddRange(themeControl.ListTheme.ToArray());
            lstGenre.Items.AddRange(genreControl.ListGenre.ToArray());
            lstClassification.Items.AddRange(classificationControl.ListClassification.ToArray());
        }             

        //Ajoute un élément selon la catégorie d'ajout sélectionnée.
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            switch ((string)lstCategorie.SelectedItem)
            {
                case "OS":
                    OSControl.Insert(txtNomOs.Text, txtVersionOS.Text, txtCodeOS.Text, txtEditionOS.Text);
                    lstOS.Items.Add(OSControl.ListOS.Last());
                    break;
                case "Plateforme":
                    plateformeControl.Insert(txtNomPlateforme.Text, txtConfigPlateforme.Text, txtTypePlateforme.Text, lstOS.SelectedItem);
                    lstPlateforme.Items.Add(plateformeControl.ListPlateforme.Last());
                    break;
                case "Jeu":
                    jeuControl.Insert(txtNomJeu.Text, txtDeveloppeur.Text, txtDescJeu.Text, txtConfigMin.Text, lstClassification.SelectedItem, lstGenre.SelectedItem, lstTheme.SelectedItem);//Pas encore de plateforme dans la bd.
                    break;
                case "Employé":
                    employeControl.Insert(txtMatricule.Text, txtNomEmploye.Text, txtPrenomEmploye.Text, dtpNaissance.Value.Date, txtAdresse.Text, txtTelResidentiel.Text, 
                    txtPosteTel.Text, (string)lstCatEmploi.SelectedItem, txtMotPasse.Text);
                    break;
                case "Thème":
                    themeControl.Insert(txtNomThemeGenreClass.Text, txtDescThemeGenreClass.Text);
                    lstTheme.Items.Add(themeControl.ListTheme.Last());
                    break;
                case "Genre":
                    genreControl.Insert(txtNomThemeGenreClass.Text, txtDescThemeGenreClass.Text);
                    lstGenre.Items.Add(genreControl.ListGenre.Last());
                    break;
                case "Classification":
                    classificationControl.Insert(txtNomThemeGenreClass.Text, txtDescThemeGenreClass.Text);
                    lstClassification.Items.Add(classificationControl.ListClassification.Last());
                    break;
            }
        }

        //Recherche les éléments dans la BD et les affiche dans la ListView.
        private void btnRechercher_Click(object sender, EventArgs e)
        {
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
                        //jeu.CodePlateforme Trouver un moyen pour mettre le code de plateforme.
                        jeu.CodeClassification,
                        jeu.CodeGenre,
                        jeu.CodeTheme
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
                    listView1.Columns.AddRange(new ColumnHeader[] { colNom, colDeveloppeur, colDescription, colConfigMin, colGenre, colClassification, colTheme });
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

        //Modifie la couleur des textboxes.
        private void txtBoxFocusChanged(object sender, EventArgs e)
        {
            Control champ = (Control)sender;

            if (OSControl.VerifierChampsOS(champ.Text))
                errorProvider1.SetError(champ, "Champ invalide");
            else
                errorProvider1.Clear();
        }

        //Ferme l'application.
        private void frmAdministrateur_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
