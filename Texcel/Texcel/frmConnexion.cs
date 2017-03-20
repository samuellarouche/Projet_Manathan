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
    public partial class frmConnexion : Form
    {
        EmployeController employeControl = new EmployeController();

        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            frmAdministrateur admin = new frmAdministrateur();
            frmDirecteur directeur = new frmDirecteur();
            employeControl.Select("WHERE matricule = '" + txtNomUtilisateur.Text + "' AND motPasse = '" + txtPassword.Text + "'");

            if (employeControl.ListEmploye.Count > 0)
            {
                this.Hide();

                if (employeControl.ListEmploye[0].CategorieEmploi == "Administrateur")                                  
                    admin.Show();                
                else                
                    directeur.Show();               
            }
            else
            {
                MessageBox.Show("Le matricule ou le mot de passe est incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
