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
        public frmAdministrateur()
        {
            InitializeComponent();
        }

        //Choix de la catégorie d'ajout.
        private void LstCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherCacher(false, grpJeu, grpOS, grpPlateforme, grpEmploye);

            switch (lstCategorie.SelectedIndex)
            {
                case 0:
                    AfficherCacher(true, grpOS);
                    break;
                case 1:
                    AfficherCacher(true, grpPlateforme);
                    break;
                case 2:
                    AfficherCacher(true, grpJeu);
                    break;
                case 3:
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
            
        }
    }
}
