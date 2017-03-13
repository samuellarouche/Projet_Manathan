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
        ConnectController connect = new ConnectController();
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {          
            frmAdministrateur admin = new frmAdministrateur();
            if (connect.Connexion(txtNomUtilisateur.Text))//Reste a checker le type de compte.
            {
                this.Hide();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Fuck you");
            }
        }
    }
}
