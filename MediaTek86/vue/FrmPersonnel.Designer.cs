
namespace MediaTek86.vue
{
    partial class FrmPersonnel
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
            this.lstPersonnel = new System.Windows.Forms.ListBox();
            this.btnAjouterPerso = new System.Windows.Forms.Button();
            this.btnModifierPerso = new System.Windows.Forms.Button();
            this.btnSupprimerPerso = new System.Windows.Forms.Button();
            this.lstAbsence = new System.Windows.Forms.ListBox();
            this.btnSupprimerAbs = new System.Windows.Forms.Button();
            this.btnModifierAbs = new System.Windows.Forms.Button();
            this.btnAjouterAbs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAbsences = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPersonnel
            // 
            this.lstPersonnel.FormattingEnabled = true;
            this.lstPersonnel.ItemHeight = 16;
            this.lstPersonnel.Location = new System.Drawing.Point(12, 48);
            this.lstPersonnel.Name = "lstPersonnel";
            this.lstPersonnel.Size = new System.Drawing.Size(650, 164);
            this.lstPersonnel.TabIndex = 0;
            // 
            // btnAjouterPerso
            // 
            this.btnAjouterPerso.Location = new System.Drawing.Point(668, 48);
            this.btnAjouterPerso.Name = "btnAjouterPerso";
            this.btnAjouterPerso.Size = new System.Drawing.Size(122, 45);
            this.btnAjouterPerso.TabIndex = 1;
            this.btnAjouterPerso.Text = "Ajouter";
            this.btnAjouterPerso.UseVisualStyleBackColor = true;
            // 
            // btnModifierPerso
            // 
            this.btnModifierPerso.Location = new System.Drawing.Point(668, 99);
            this.btnModifierPerso.Name = "btnModifierPerso";
            this.btnModifierPerso.Size = new System.Drawing.Size(122, 57);
            this.btnModifierPerso.TabIndex = 2;
            this.btnModifierPerso.Text = "Modifier";
            this.btnModifierPerso.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPerso
            // 
            this.btnSupprimerPerso.Location = new System.Drawing.Point(668, 167);
            this.btnSupprimerPerso.Name = "btnSupprimerPerso";
            this.btnSupprimerPerso.Size = new System.Drawing.Size(122, 45);
            this.btnSupprimerPerso.TabIndex = 3;
            this.btnSupprimerPerso.Text = "Supprimer";
            this.btnSupprimerPerso.UseVisualStyleBackColor = true;
            this.btnSupprimerPerso.Click += new System.EventHandler(this.btnSupprimerPerso_Click);
            // 
            // lstAbsence
            // 
            this.lstAbsence.FormattingEnabled = true;
            this.lstAbsence.ItemHeight = 16;
            this.lstAbsence.Location = new System.Drawing.Point(12, 267);
            this.lstAbsence.Name = "lstAbsence";
            this.lstAbsence.Size = new System.Drawing.Size(650, 164);
            this.lstAbsence.TabIndex = 4;
            // 
            // btnSupprimerAbs
            // 
            this.btnSupprimerAbs.Location = new System.Drawing.Point(665, 381);
            this.btnSupprimerAbs.Name = "btnSupprimerAbs";
            this.btnSupprimerAbs.Size = new System.Drawing.Size(122, 50);
            this.btnSupprimerAbs.TabIndex = 5;
            this.btnSupprimerAbs.Text = "Supprimer";
            this.btnSupprimerAbs.UseVisualStyleBackColor = true;
            // 
            // btnModifierAbs
            // 
            this.btnModifierAbs.Location = new System.Drawing.Point(666, 318);
            this.btnModifierAbs.Name = "btnModifierAbs";
            this.btnModifierAbs.Size = new System.Drawing.Size(122, 57);
            this.btnModifierAbs.TabIndex = 6;
            this.btnModifierAbs.Text = "Modifier";
            this.btnModifierAbs.UseVisualStyleBackColor = true;
            // 
            // btnAjouterAbs
            // 
            this.btnAjouterAbs.Location = new System.Drawing.Point(666, 267);
            this.btnAjouterAbs.Name = "btnAjouterAbs";
            this.btnAjouterAbs.Size = new System.Drawing.Size(122, 45);
            this.btnAjouterAbs.TabIndex = 7;
            this.btnAjouterAbs.Text = "Ajouter";
            this.btnAjouterAbs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Personnels :";
            // 
            // lblAbsences
            // 
            this.lblAbsences.AutoSize = true;
            this.lblAbsences.Location = new System.Drawing.Point(12, 237);
            this.lblAbsences.Name = "lblAbsences";
            this.lblAbsences.Size = new System.Drawing.Size(172, 17);
            this.lblAbsences.TabIndex = 9;
            this.lblAbsences.Text = "Absences concernant --- :";
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAbsences);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAjouterAbs);
            this.Controls.Add(this.btnModifierAbs);
            this.Controls.Add(this.btnSupprimerAbs);
            this.Controls.Add(this.lstAbsence);
            this.Controls.Add(this.btnSupprimerPerso);
            this.Controls.Add(this.btnModifierPerso);
            this.Controls.Add(this.btnAjouterPerso);
            this.Controls.Add(this.lstPersonnel);
            this.Name = "FrmPersonnel";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPersonnel;
        private System.Windows.Forms.Button btnAjouterPerso;
        private System.Windows.Forms.Button btnModifierPerso;
        private System.Windows.Forms.Button btnSupprimerPerso;
        private System.Windows.Forms.ListBox lstAbsence;
        private System.Windows.Forms.Button btnSupprimerAbs;
        private System.Windows.Forms.Button btnModifierAbs;
        private System.Windows.Forms.Button btnAjouterAbs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAbsences;
    }
}