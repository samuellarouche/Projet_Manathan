﻿namespace Texcel
{
    partial class frmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomUtilisateur = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpIdentification = new System.Windows.Forms.GroupBox();
            this.grpIdentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texcel";
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.Location = new System.Drawing.Point(27, 53);
            this.txtNomUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(195, 20);
            this.txtNomUtilisateur.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(27, 121);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(195, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // btnConnecter
            // 
            this.btnConnecter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnecter.Location = new System.Drawing.Point(171, 261);
            this.btnConnecter.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(95, 19);
            this.btnConnecter.TabIndex = 3;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matricule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mot de passe";
            // 
            // grpIdentification
            // 
            this.grpIdentification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpIdentification.Controls.Add(this.txtNomUtilisateur);
            this.grpIdentification.Controls.Add(this.label3);
            this.grpIdentification.Controls.Add(this.txtPassword);
            this.grpIdentification.Controls.Add(this.label2);
            this.grpIdentification.Location = new System.Drawing.Point(92, 60);
            this.grpIdentification.Margin = new System.Windows.Forms.Padding(2);
            this.grpIdentification.Name = "grpIdentification";
            this.grpIdentification.Padding = new System.Windows.Forms.Padding(2);
            this.grpIdentification.Size = new System.Drawing.Size(250, 175);
            this.grpIdentification.TabIndex = 6;
            this.grpIdentification.TabStop = false;
            this.grpIdentification.Text = "Identification";
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.grpIdentification);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConnexion";
            this.Text = "Connexion";
            this.grpIdentification.ResumeLayout(false);
            this.grpIdentification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomUtilisateur;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpIdentification;
    }
}

