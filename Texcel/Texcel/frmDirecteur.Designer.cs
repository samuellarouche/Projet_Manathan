﻿namespace Texcel
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
            this.lstProjetTest = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstEmploye1 = new System.Windows.Forms.ComboBox();
            this.lstEmploye2 = new System.Windows.Forms.ComboBox();
            this.lstEmploye3 = new System.Windows.Forms.ComboBox();
            this.lstEmploye4 = new System.Windows.Forms.ComboBox();
            this.lstEmploye5 = new System.Windows.Forms.ComboBox();
            this.txtNomEquipe = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
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
            this.tabAjout.Margin = new System.Windows.Forms.Padding(2);
            this.tabAjout.Padding = new System.Windows.Forms.Padding(2);
            // 
            // grpRadioRecherche
            // 
            this.grpRadioRecherche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRadioRecherche.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRadioRecherche.Size = new System.Drawing.Size(162, 48);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEquipe);
            this.tabControl1.Controls.SetChildIndex(this.tabEquipe, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabAjout, 0);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            // 
            // tabEquipe
            // 
            this.tabEquipe.Controls.Add(this.grpEquipe);
            this.tabEquipe.Location = new System.Drawing.Point(4, 22);
            this.tabEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.tabEquipe.Name = "tabEquipe";
            this.tabEquipe.Size = new System.Drawing.Size(540, 396);
            this.tabEquipe.TabIndex = 2;
            this.tabEquipe.Text = "Gestion d\'équipe";
            this.tabEquipe.UseVisualStyleBackColor = true;
            // 
            // grpEquipe
            // 
            this.grpEquipe.Controls.Add(this.label30);
            this.grpEquipe.Controls.Add(this.btnCreerEquipe);
            this.grpEquipe.Controls.Add(this.groupBox2);
            this.grpEquipe.Controls.Add(this.groupBox1);
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
            // btnCreerEquipe
            // 
            this.btnCreerEquipe.Location = new System.Drawing.Point(194, 310);
            this.btnCreerEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreerEquipe.Name = "btnCreerEquipe";
            this.btnCreerEquipe.Size = new System.Drawing.Size(116, 40);
            this.btnCreerEquipe.TabIndex = 14;
            this.btnCreerEquipe.Text = "Créer équipe";
            this.btnCreerEquipe.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstProjetTest);
            this.groupBox2.Location = new System.Drawing.Point(269, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(221, 223);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projet de test";
            // 
            // lstProjetTest
            // 
            this.lstProjetTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstProjetTest.FormattingEnabled = true;
            this.lstProjetTest.Location = new System.Drawing.Point(22, 104);
            this.lstProjetTest.Margin = new System.Windows.Forms.Padding(2);
            this.lstProjetTest.Name = "lstProjetTest";
            this.lstProjetTest.Size = new System.Drawing.Size(179, 21);
            this.lstProjetTest.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstEmploye1);
            this.groupBox1.Controls.Add(this.lstEmploye2);
            this.groupBox1.Controls.Add(this.lstEmploye3);
            this.groupBox1.Controls.Add(this.lstEmploye4);
            this.groupBox1.Controls.Add(this.lstEmploye5);
            this.groupBox1.Location = new System.Drawing.Point(17, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(221, 223);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employé";
            // 
            // lstEmploye1
            // 
            this.lstEmploye1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmploye1.FormattingEnabled = true;
            this.lstEmploye1.Location = new System.Drawing.Point(22, 28);
            this.lstEmploye1.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmploye1.Name = "lstEmploye1";
            this.lstEmploye1.Size = new System.Drawing.Size(179, 21);
            this.lstEmploye1.TabIndex = 2;
            // 
            // lstEmploye2
            // 
            this.lstEmploye2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmploye2.FormattingEnabled = true;
            this.lstEmploye2.Location = new System.Drawing.Point(22, 64);
            this.lstEmploye2.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmploye2.Name = "lstEmploye2";
            this.lstEmploye2.Size = new System.Drawing.Size(179, 21);
            this.lstEmploye2.TabIndex = 4;
            // 
            // lstEmploye3
            // 
            this.lstEmploye3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmploye3.FormattingEnabled = true;
            this.lstEmploye3.Location = new System.Drawing.Point(22, 104);
            this.lstEmploye3.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmploye3.Name = "lstEmploye3";
            this.lstEmploye3.Size = new System.Drawing.Size(179, 21);
            this.lstEmploye3.TabIndex = 5;
            // 
            // lstEmploye4
            // 
            this.lstEmploye4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmploye4.FormattingEnabled = true;
            this.lstEmploye4.Location = new System.Drawing.Point(22, 145);
            this.lstEmploye4.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmploye4.Name = "lstEmploye4";
            this.lstEmploye4.Size = new System.Drawing.Size(179, 21);
            this.lstEmploye4.TabIndex = 6;
            // 
            // lstEmploye5
            // 
            this.lstEmploye5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmploye5.FormattingEnabled = true;
            this.lstEmploye5.Location = new System.Drawing.Point(22, 183);
            this.lstEmploye5.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmploye5.Name = "lstEmploye5";
            this.lstEmploye5.Size = new System.Drawing.Size(179, 21);
            this.lstEmploye5.TabIndex = 7;
            // 
            // txtNomEquipe
            // 
            this.txtNomEquipe.Location = new System.Drawing.Point(150, 41);
            this.txtNomEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomEquipe.Name = "txtNomEquipe";
            this.txtNomEquipe.Size = new System.Drawing.Size(207, 20);
            this.txtNomEquipe.TabIndex = 0;
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
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(212, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 13);
            this.label30.TabIndex = 15;
            this.label30.Text = "Nom de l\'équipe";
            // 
            // frmDirecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 446);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox lstProjetTest;
        private System.Windows.Forms.Button btnCreerEquipe;
        private System.Windows.Forms.Label label30;
    }
}