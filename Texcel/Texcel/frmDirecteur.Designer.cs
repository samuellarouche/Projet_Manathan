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
            this.label29 = new System.Windows.Forms.Label();
            this.txtNomEquipe = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.grpRadioRecherche.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabEquipe.SuspendLayout();
            this.grpEquipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRadioRecherche
            // 
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
            this.tabEquipe.Name = "tabEquipe";
            this.tabEquipe.Size = new System.Drawing.Size(723, 492);
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
            this.grpEquipe.Location = new System.Drawing.Point(26, 23);
            this.grpEquipe.Name = "grpEquipe";
            this.grpEquipe.Size = new System.Drawing.Size(675, 450);
            this.grpEquipe.TabIndex = 0;
            this.grpEquipe.TabStop = false;
            this.grpEquipe.Text = "Équipe";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(282, 30);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(110, 17);
            this.label29.TabIndex = 1;
            this.label29.Text = "Nom de l\'équipe";
            // 
            // txtNomEquipe
            // 
            this.txtNomEquipe.Location = new System.Drawing.Point(200, 50);
            this.txtNomEquipe.Name = "txtNomEquipe";
            this.txtNomEquipe.Size = new System.Drawing.Size(275, 22);
            this.txtNomEquipe.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(352, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // frmDirecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 521);
            this.Name = "frmDirecteur";
            this.Text = "frmDirecteur";
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