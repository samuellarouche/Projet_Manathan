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

        dbProvider asd = new dbProvider();

        public frmAdministrateur()
        {
            InitializeComponent();
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
                    OSControl.CreerOS(txtNomOs.Text, txtVersionOS.Text, txtCodeOS.Text, txtEditionOS.Text);
                    
                    lstOS.Items.Add(OSControl.ListOS.Last());
                    break;
                case "Plateforme":
                    plateformeControl.CreerPlateforme(txtNomPlateforme.Text, txtConfigPlateforme.Text, txtTypePlateforme.Text, (OS)lstOS.SelectedItem);
                    lstPlateforme.Items.Add(plateformeControl.ListPlateforme.Last());
                    break;
                case "Jeu":
                    jeuControl.CreerJeu(txtNomJeu.Text, txtDeveloppeur.Text, txtDescJeu.Text, txtConfigMin.Text, (Plateforme)lstPlateforme.SelectedItem);
                    break;
                case "Employé":
                    employeControl.CreerEmploye(txtNomEmploye.Text, txtPrenomEmploye.Text, dtpNaissance.Text, txtAdresse.Text, txtTelResidentiel.Text, 
                    Convert.ToInt32(txtPosteTel.Text), txtMatricule.Text, (string)lstCatEmploi.SelectedItem);
                    break;
            }
        }
    }
}
