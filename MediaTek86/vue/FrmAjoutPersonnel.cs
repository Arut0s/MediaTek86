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
using System.Collections.Generic;

namespace MediaTek86.vue
{
    public partial class FrmAjoutPersonnel : Form
    {
        private FrmPersonnelController controller;

        public FrmAjoutPersonnel()
        {
            InitializeComponent();
            Init();

        }
        private void Init()
        {
            controller = new FrmPersonnelController();
            RemplirComboBox();
        }
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cmbService.SelectedIndex != -1)
            {
                int idpersonnel = 0;
                List<Personnel> lesPersonnels = controller.GetLesPersonnels();
                foreach(Personnel perso in lesPersonnels)
                {
                    if(perso.idpersonnel == idpersonnel)
                    {
                        idpersonnel++;
                    }
                    else
                    {
                        break;
                    }
                }
                Personnel personnel = new Personnel(idpersonnel,cmbService.SelectedIndex+1,txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text);
                controller.AddPersonnel(personnel);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void RemplirComboBox()
        {
            cmbService.Items.Add("administratif");
            cmbService.Items.Add("médiation culturelle");
            cmbService.Items.Add("prêt");
        }
    }
}
