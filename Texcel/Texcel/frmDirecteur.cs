﻿using System;
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
        public frmDirecteur()
        {
            InitializeComponent();
            tabAjout.Dispose();
            radEmploye.Dispose();
        }

        //Insère les employés dans les listes.
        private void InsertionListEmploye()
        {

        }
    }
}
