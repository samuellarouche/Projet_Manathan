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

        private void chkTout_CheckedChanged(object sender, EventArgs e)
        {
            //OSControl.Insert();
            OSControl.Select();
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
                    plateformeControl.Insert(txtNomPlateforme.Text, txtConfigPlateforme.Text, txtTypePlateforme.Text);//Manque OS pas fait dans la BD encore.
                    //lstPlateforme.Items.Add(plateformeControl.ListPlateforme.Last());
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
    }
}
