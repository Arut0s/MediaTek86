using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.controleur;
using MediaTek86.modele;

namespace MediaTek86.vue { 

     /// <summary>
     /// Fenêtre d'affichage de l'application
     /// </summary>
public partial class FrmPersonnel : Form
    {
        private FrmPersonnelController controller;
        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>

        public FrmPersonnel()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            controller = new FrmPersonnelController();
            RemplirListPersonnel();
        }

        private void RemplirListPersonnel()
        {
            lstPersonnel.Items.Clear();
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            foreach(Personnel personnel in lesPersonnels)
            {
                lstPersonnel.Items.Add(personnel.ToString());
            }
        }

        private void btnSupprimerPerso_Click(object sender, EventArgs e)
        {
            if (lstPersonnel.SelectedIndex > -1)
            {
                List<Personnel> lesPersonnels = controller.GetLesPersonnels();
                Personnel personnel = lesPersonnels[lstPersonnel.SelectedIndex];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.nom + " " + personnel.prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListPersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnAjouterPerso_Click(object sender, EventArgs e)
        {
            FrmAjoutPersonnel ajout = new FrmAjoutPersonnel();
            ajout.ShowDialog();
        }

        private void FrmPersonnel_Activated(object sender, EventArgs e)
        {
            Init();
        }
    }
}
