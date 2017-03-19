namespace Texcel
{
    partial class frmDirecteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabEquipe = new System.Windows.Forms.TabPage();
            this.grpEquipe = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtNomEquipe = new System.Windows.Forms.TextBox();
            this.grpRadioRecherche.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabEquipe.SuspendLayout();
            this.grpEquipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAjout
            // 
            this.tabAjout.Margin = new System.Windows.Forms.Padding(2);
            this.tabAjout.Padding = new System.Windows.Forms.Padding(2);
            // 
            // grpRadioRecherche
            // 
            this.grpRadioRecherche.Size = new System.Drawing.Size(162, 48);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEquipe);
            this.tabControl1.Controls.SetChildIndex(this.tabEquipe, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabAjout, 0);
            // 
            // tabEquipe
            // 
            this.tabEquipe.Controls.Add(this.grpEquipe);
            this.tabEquipe.Location = new System.Drawing.Point(4, 22);
            this.tabEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.tabEquipe.Name = "tabEquipe";
            this.tabEquipe.Size = new System.Drawing.Size(540, 397);
            this.tabEquipe.TabIndex = 2;
            this.tabEquipe.Text = "Gestion d\'équipe";
            this.tabEquipe.UseVisualStyleBackColor = true;
            // 
            // grpEquipe
            // 
            this.grpEquipe.Controls.Add(this.comboBox2);
            this.grpEquipe.Controls.Add(this.comboBox1);
            this.grpEquipe.Controls.Add(this.label29);
            this.grpEquipe.Controls.Add(this.txtNomEquipe);
            this.grpEquipe.Location = new System.Drawing.Point(17, 19);
            this.grpEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.grpEquipe.Name = "grpEquipe";
            this.grpEquipe.Padding = new System.Windows.Forms.Padding(2);
            this.grpEquipe.Size = new System.Drawing.Size(506, 366);
            this.grpEquipe.TabIndex = 0;
            this.grpEquipe.TabStop = false;
            this.grpEquipe.Text = "Équipe";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(264, 84);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 84);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(212, 24);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 13);
            this.label29.TabIndex = 1;
            this.label29.Text = "Nom de l\'équipe";
            // 
            // txtNomEquipe
            // 
            this.txtNomEquipe.Location = new System.Drawing.Point(150, 41);
            this.txtNomEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomEquipe.Name = "txtNomEquipe";
            this.txtNomEquipe.Size = new System.Drawing.Size(207, 20);
            this.txtNomEquipe.TabIndex = 0;
            // 
            // frmDirecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 423);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDirecteur";
            this.Text = "Texcel - Directeur";
            this.grpRadioRecherche.ResumeLayout(false);
            this.grpRadioRecherche.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabEquipe.ResumeLayout(false);
            this.grpEquipe.ResumeLayout(false);
            this.grpEquipe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabEquipe;
        private System.Windows.Forms.GroupBox grpEquipe;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtNomEquipe;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}