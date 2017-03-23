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

        public frmDirecteur()
        {
            InitializeComponent();
            tabAjout.Dispose();
            radEmploye.Dispose();
            btnSupprimer.Dispose();
            InsertionListEmploye();
        }

        //Insère les employés dans les listes.
        private void InsertionListEmploye()
        {
            for (int i = 1; i < 6; i++)
            {
                (Controls.Find("lstEmploye" + i, true)[0] as ComboBox).Items.AddRange(employeControl.ListEmploye.ToArray());
            }
        }
    }
}
