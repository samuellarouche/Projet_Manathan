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
            employeControl.Select("WHERE matricule = '" + txtNomUtilisateur.Text + "' AND motPasse = '" + txtPassword.Text + "'");

            if (employeControl.ListEmploye.Count > 0)//Reste a checker le type de compte.
            {
                if (employeControl.ListEmploye[0].CategorieEmploi == "Administrateur")
                {
                    this.Hide();
                    admin.Show();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Fuck you");
            }
        }
    }
}
