namespace Texcel
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texcel";
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.Location = new System.Drawing.Point(27, 65);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(255, 22);
            this.txtNomUtilisateur.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(27, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(255, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(247, 329);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(122, 23);
            this.btnConnecter.TabIndex = 3;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matricule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mot de passe";
            // 
            // grpIdentification
            // 
            this.grpIdentification.Controls.Add(this.txtNomUtilisateur);
            this.grpIdentification.Controls.Add(this.label3);
            this.grpIdentification.Controls.Add(this.txtPassword);
            this.grpIdentification.Controls.Add(this.label2);
            this.grpIdentification.Location = new System.Drawing.Point(152, 80);
            this.grpIdentification.Name = "grpIdentification";
            this.grpIdentification.Size = new System.Drawing.Size(306, 216);
            this.grpIdentification.TabIndex = 6;
            this.grpIdentification.TabStop = false;
            this.grpIdentification.Text = "Identification";
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(621, 398);
            this.Controls.Add(this.grpIdentification);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.label1);
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

