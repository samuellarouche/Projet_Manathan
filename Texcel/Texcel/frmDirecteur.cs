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
    public partial class frmDirecteur : frmAdministrateur
    {
        EmployeController employeControl = new EmployeController();
		EquipeController equipeControl = new EquipeController();
        TestController testControl = new TestController();

        public frmDirecteur()
        {
            InitializeComponent();
            tabAjout.Dispose();
            radEmploye.Dispose();
            btnSupprimer.Dispose();

            InsertionListEmploye();
            lstTest.Items.AddRange(testControl.ListTest.ToArray());
        }

        //Insère les employés dans toutes les listes d'employés.
        private void InsertionListEmploye()
        {
            for (int i = 1; i < 6; i++)
            {
                (Controls.Find("lstEmploye" + i, true)[0] as ComboBox).Items.AddRange(employeControl.ListEmploye.ToArray());
            }
        }

		private void btnCreerEquipe_Click(object sender, EventArgs e)
		{
			equipeControl.Insert(new Equipe(txtNomEquipe.Text, (lstTest.SelectedItem as Test).Nom, (lstEmploye1.SelectedItem as Employe).Matricule, 
			(lstEmploye2.SelectedItem as Employe).Matricule, (lstEmploye3.SelectedItem as Employe).Matricule, (lstEmploye4.SelectedItem as Employe).Matricule, 
			(lstEmploye5.SelectedItem as Employe).Matricule));
		}
	}
}
