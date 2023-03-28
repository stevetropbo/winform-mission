using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3GSB
{
    public partial class FrmModificationRapport : Form
    {
        gsbrapports2021Entities gsbrapports;
        public FrmModificationRapport(gsbrapports2021Entities gsbrapports2021Entities)
        {
            InitializeComponent();
            this.gsbrapports = gsbrapports2021Entities;
            this.bdgRapport.DataSource = this.gsbrapports.rapport.ToList();
            this.bdgMedicament.DataSource = this.gsbrapports.medicament.ToList();
            this.bdgOfrrir.DataSource = this.gsbrapports.offrir.ToList();
           

        }

        public void getVisiteurs()
        {
            List<visiteur> lesVisiteur = this.gsbrapports.visiteur.ToList();

            var req = (from em in lesVisiteur
                       select em.id).Distinct();

            foreach (var em in req)
            {
                comboListeVisiteur.Items.Add(em);
                comboListeVisiteur.SelectedIndex = 0;
            }
        }








        private void FrmModificationRapport_Load(object sender, EventArgs e)
        {
            this.getVisiteurs();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFiltre_Click(object sender, EventArgs e)
        {



            //recuperation des valeurs du filtre pour le rpport 
            string idVisiteur = Convert.ToString(this.comboListeVisiteur.Text);
            DateTime dateRapport = this.dateTimeRapport.Value;


            var req2 = (from me in this.gsbrapports.rapport
                        where me.idVisiteur == idVisiteur && me.date == dateRapport
                        select me
                      );

            //chargement composant 
            this.bdgRapport.DataSource = req2.ToList();
            //fitre table rapport 
            this.dataGridViewModification.DataSource = this.bdgRapport.DataSource;


            //recuperation des valeurs du filtre pour offir
            int idRapport = 0;

            foreach (var v in req2)
            {
                idRapport = v.id;
            }


            var req3  = (from me in this.gsbrapports.offrir
                        where me.idRapport == idRapport 
                        select me
                      );

            this.bdgOfrrir.DataSource = req3.ToList();

            string idMedicament = " ";

            foreach (var v in req3)
            {
                idMedicament = v.idMedicament;
            }

            //recuperation des valeurs du filtre pour medicament

            var req4 = (from me in this.gsbrapports.medicament
                        where me.id == idMedicament
                        select me
                     );

            this.bdgMedicament.DataSource = req4.ToList();




        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                this.bdgRapport.EndEdit();
                this.bdgOfrrir.EndEdit();
                this.bdgMedicament.EndEdit();
                this.gsbrapports.SaveChanges();
                MessageBox.Show($"Rapport Mise a jour !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probleme lors de la mise a jour verifier les champs de numero(numero visiteur,numuro famille)");
            }

        }
    }
}
