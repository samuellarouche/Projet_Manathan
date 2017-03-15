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

        public frmAdministrateur()
        {
            InitializeComponent();

            lstOS.Items.AddRange(OSControl.ListOS.ToArray());
            lstPlateforme.Items.AddRange(plateformeControl.ListPlateforme.ToArray());      
        }

        //Choix de la catégorie d'ajout. (Jeu, OS, plateforme...)
        private void LstCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherCacher(false, grpJeu, grpOS, grpPlateforme, grpEmploye);

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

        //Ajoute un élément selon la catégorie d'ajout sélectionnée.
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            switch ((string)lstCategorie.SelectedItem)
            {
                case "OS":
                    OSControl.Insert(txtNomOs.Text, txtVersionOS.Text, txtCodeOS.Text, txtEditionOS.Text);
                    break;
                case "Plateforme":
                    plateformeControl.Insert(txtNomPlateforme.Text, txtConfigPlateforme.Text, txtTypePlateforme.Text, lstOS.SelectedItem);
                    break;
                case "Jeu":
                    jeuControl.Insert(txtNomJeu.Text, txtDeveloppeur.Text, txtDescJeu.Text, txtConfigMin.Text);//Pas encore de plateforme dans la bd.
                    break;
                case "Employé":
                    employeControl.Insert(txtNomEmploye.Text, txtPrenomEmploye.Text, dtpNaissance.Text, txtAdresse.Text, txtTelResidentiel.Text, 
                    txtPosteTel.Text, txtMatricule.Text, (string)lstCatEmploi.SelectedItem);
                    break;
            }
        }

        //Recherche les éléments dans la BD et les affiche dans la ListView.
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (radOS.Checked)
            {
                listView1.Columns.AddRange(new ColumnHeader[] { colCodeOS, colNom, colVersion, colEdition });
                OSControl.Select("WHERE nom = '" + txtRecherche.Text +
                    "' OR versionOS = '" + txtRecherche.Text +
                    "' OR codeOS = '" + txtRecherche.Text +
                    "' OR edition = '" + txtRecherche.Text + "'");

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
                listView1.Columns.AddRange(new ColumnHeader[] { colCodePlateforme, colNom, colConfiguration, colTypeConfig, colCodeOS });
                plateformeControl.Select("");
            }
        }

        private void AjoutItemList()
        {
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

        //Change les colonnes du ListView selon le RadioButton coché.
        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
   
            listView1.Clear();
            
            switch (radio.Name)
            {
                case "radOS":
                    
                    break;
                case "radPlateforme":
                    break;
                case "radJeu":
                    listView1.Columns.AddRange(new ColumnHeader[] { colCodeJeu, colNom, colDeveloppeur, colDescription, colConfigMin, colClassification, colGenre, colTheme });
                    break;
                case "radEmploye":
                    break;
            }
        }
    }
}
