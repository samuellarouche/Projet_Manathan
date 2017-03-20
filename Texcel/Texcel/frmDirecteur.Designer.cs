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
            this.btnCreerEquipe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstTache1 = new System.Windows.Forms.ComboBox();
            this.lstTache2 = new System.Windows.Forms.ComboBox();
            this.lstTache3 = new System.Windows.Forms.ComboBox();
            this.lstTache4 = new System.Windows.Forms.ComboBox();
            this.lstTache5 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstEmploye1 = new System.Windows.Forms.ComboBox();
            this.lstEmploye2 = new System.Windows.Forms.ComboBox();
            this.lstEmploye3 = new System.Windows.Forms.ComboBox();
            this.lstEmploye4 = new System.Windows.Forms.ComboBox();
            this.lstEmploye5 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtNomEquipe = new System.Windows.Forms.TextBox();
            this.grpRadioRecherche.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabEquipe.SuspendLayout();
            this.grpEquipe.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAjout
            // 
            this.tabAjout.Location = new System.Drawing.Point(4, 25);
            this.tabAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAjout.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAjout.Size = new System.Drawing.Size(723, 492);
            // 
            // grpRadioRecherche
            // 
            this.grpRadioRecherche.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpRadioRecherche.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpRadioRecherche.Size = new System.Drawing.Size(216, 59);
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
            this.tabEquipe.Location = new System.Drawing.Point(4, 25);
            this.tabEquipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEquipe.Name = "tabEquipe";
            this.tabEquipe.Size = new System.Drawing.Size(723, 492);
            this.tabEquipe.TabIndex = 2;
            this.tabEquipe.Text = "Gestion d\'équipe";
            this.tabEquipe.UseVisualStyleBackColor = true;
            // 
            // grpEquipe
            // 
            this.grpEquipe.Controls.Add(this.btnCreerEquipe);
            this.grpEquipe.Controls.Add(this.groupBox2);
            this.grpEquipe.Controls.Add(this.groupBox1);
            this.grpEquipe.Controls.Add(this.label29);
            this.grpEquipe.Controls.Add(this.txtNomEquipe);
            this.grpEquipe.Location = new System.Drawing.Point(23, 23);
            this.grpEquipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEquipe.Name = "grpEquipe";
            this.grpEquipe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEquipe.Size = new System.Drawing.Size(675, 450);
            this.grpEquipe.TabIndex = 0;
            this.grpEquipe.TabStop = false;
            this.grpEquipe.Text = "Équipe";
            // 
            // btnCreerEquipe
            // 
            this.btnCreerEquipe.Location = new System.Drawing.Point(258, 381);
            this.btnCreerEquipe.Name = "btnCreerEquipe";
            this.btnCreerEquipe.Size = new System.Drawing.Size(154, 49);
            this.btnCreerEquipe.TabIndex = 14;
            this.btnCreerEquipe.Text = "Créer équipe";
            this.btnCreerEquipe.UseVisualStyleBackColor = true;
            this.btnCreerEquipe.Click += new System.EventHandler(this.btnCreerEquipe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstTache1);
            this.groupBox2.Controls.Add(this.lstTache2);
            this.groupBox2.Controls.Add(this.lstTache3);
            this.groupBox2.Controls.Add(this.lstTache4);
            this.groupBox2.Controls.Add(this.lstTache5);
            this.groupBox2.Location = new System.Drawing.Point(359, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 275);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tâche";
            // 
            // lstTache1
            // 
            this.lstTache1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTache1.FormattingEnabled = true;
            this.lstTache1.Location = new System.Drawing.Point(29, 34);
            this.lstTache1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstTache1.Name = "lstTache1";
            this.lstTache1.Size = new System.Drawing.Size(237, 24);
            this.lstTache1.TabIndex = 2;
            // 
            // lstTache2
            // 
            this.lstTache2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTache2.FormattingEnabled = true;
            this.lstTache2.Location = new System.Drawing.Point(29, 79);
            this.lstTache2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstTache2.Name = "lstTache2";
            this.lstTache2.Size = new System.Drawing.Size(237, 24);
            this.lstTache2.TabIndex = 4;
            // 
            // lstTache3
            // 
            this.lstTache3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTache3.FormattingEnabled = true;
            this.lstTache3.Location = new System.Drawing.Point(29, 128);
            this.lstTache3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstTache3.Name = "lstTache3";
            this.lstTache3.Size = new System.Drawing.Size(237, 24);
            this.lstTache3.TabIndex = 5;
            // 
            // lstTache4
            // 
            this.lstTache4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTache4.FormattingEnabled = true;
            this.lstTache4.Location = new System.Drawing.Point(29, 178);
            this.lstTache4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstTache4.Name = "lstTache4";
            this.lstTache4.Size = new System.Drawing.Size(237, 24);
            this.lstTache4.TabIndex = 6;
            // 
            // lstTache5
            // 
            this.lstTache5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTache5.FormattingEnabled = true;
            this.lstTache5.Location = new System.Drawing.Point(29, 225);
            this.lstTache5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstTache5.Name = "lstTache5";
            this.lstTache5.Size = new System.Drawing.Size(237, 24);
            this.lstTache5.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstEmploye1);
            this.groupBox1.Controls.Add(this.lstEmploye2);
            this.groupBox1.Controls.Add(this.lstEmploye3);
            this.groupBox1.Controls.Add(this.lstEmploye4);
            this.groupBox1.Controls.Add(this.lstEmploye5);
            this.groupBox1.Location = new System.Drawing.Point(23, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 275);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employé";
            // 
            // lstEmploye1
            // 
            this.lstEmploye1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmploye1.FormattingEnabled = true;
            this.lstEmploye1.Location = new System.Drawing.Point(29, 34);
            this.lstEmploye1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstEmploye1.Name = "lstEmploye1";
            this.lstEmploye1.Size = new System.Drawing.Size(237, 24);
            this.lstEmploye1.TabIndex = 2;
            // 
            // lstEmploye2
            // 
            this.lstEmploye2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmploye2.FormattingEnabled = true;
            this.lstEmploye2.Location = new System.Drawing.Point(29, 79);
            this.lstEmploye2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstEmploye2.Name = "lstEmploye2";
            this.lstEmploye2.Size = new System.Drawing.Size(237, 24);
            this.lstEmploye2.TabIndex = 4;
            // 
            // lstEmploye3
            // 
            this.lstEmploye3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmploye3.FormattingEnabled = true;
            this.lstEmploye3.Location = new System.Drawing.Point(29, 128);
            this.lstEmploye3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstEmploye3.Name = "lstEmploye3";
            this.lstEmploye3.Size = new System.Drawing.Size(237, 24);
            this.lstEmploye3.TabIndex = 5;
            // 
            // lstEmploye4
            // 
            this.lstEmploye4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmploye4.FormattingEnabled = true;
            this.lstEmploye4.Location = new System.Drawing.Point(29, 178);
            this.lstEmploye4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstEmploye4.Name = "lstEmploye4";
            this.lstEmploye4.Size = new System.Drawing.Size(237, 24);
            this.lstEmploye4.TabIndex = 6;
            // 
            // lstEmploye5
            // 
            this.lstEmploye5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmploye5.FormattingEnabled = true;
            this.lstEmploye5.Location = new System.Drawing.Point(29, 225);
            this.lstEmploye5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstEmploye5.Name = "lstEmploye5";
            this.lstEmploye5.Size = new System.Drawing.Size(237, 24);
            this.lstEmploye5.TabIndex = 7;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(283, 30);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(110, 17);
            this.label29.TabIndex = 1;
            this.label29.Text = "Nom de l\'équipe";
            // 
            // txtNomEquipe
            // 
            this.txtNomEquipe.Location = new System.Drawing.Point(200, 50);
            this.txtNomEquipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomEquipe.Name = "txtNomEquipe";
            this.txtNomEquipe.Size = new System.Drawing.Size(275, 22);
            this.txtNomEquipe.TabIndex = 0;
            // 
            // frmDirecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 521);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDirecteur";
            this.Text = "Texcel - Directeur";
            this.grpRadioRecherche.ResumeLayout(false);
            this.grpRadioRecherche.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabEquipe.ResumeLayout(false);
            this.grpEquipe.ResumeLayout(false);
            this.grpEquipe.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabEquipe;
        private System.Windows.Forms.GroupBox grpEquipe;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtNomEquipe;
        private System.Windows.Forms.ComboBox lstEmploye1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox lstEmploye2;
        private System.Windows.Forms.ComboBox lstEmploye3;
        private System.Windows.Forms.ComboBox lstEmploye4;
        private System.Windows.Forms.ComboBox lstEmploye5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox lstTache1;
        private System.Windows.Forms.ComboBox lstTache2;
        private System.Windows.Forms.ComboBox lstTache3;
        private System.Windows.Forms.ComboBox lstTache4;
        private System.Windows.Forms.ComboBox lstTache5;
        private System.Windows.Forms.Button btnCreerEquipe;
    }
}