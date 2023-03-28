using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;


namespace Mission3GSB
{
    public partial class FrmAjoutRapport : Form
    {
        public FrmAjoutRapport()
        {
            InitializeComponent();
        }

        private gsbrapports2021Entities mesRapports;


        public FrmAjoutRapport(gsbrapports2021Entities mesRapports)
        {
            InitializeComponent();
            this.mesRapports = new gsbrapports2021Entities();
            this.mesRapports = mesRapports;
            
        }

        //* liste des visiteurs
        public void getVisiteurs()
        {
            List<visiteur>lesVisiteur = this.mesRapports.visiteur.ToList();

            var req = (from em in  lesVisiteur
                      select em.id).Distinct();

            foreach (var em in req)
            {
                comboListeVisiteur.Items.Add(em);
                comboListeVisiteur.SelectedIndex = 0;
            }
        }
        public void getMedecin()
        {
            List<medecin> lesMedecin = this.mesRapports.medecin.ToList();

            var req = (from me in lesMedecin
                      select me.id).Distinct();

            foreach (var me in req)
            {
                ComboListeMedecin.Items.Add(me);
                ComboListeMedecin.SelectedIndex = 0;
            }

        }

        private void recupFamillePourMedicament()
        {

            var req =(from me in this.mesRapports.medicament
                      select me.idFamille).Distinct();


            foreach (var me in req)
            {
                comboBoxIdFamille.Items.Add(me);
                comboBoxIdFamille.SelectedIndex = 0;

            }



        }

        private void getNomCommercial()
        {
            var req = (from me in this.mesRapports.medicament
                       select me.nomCommercial).Distinct();


            foreach (var me in req)
            {
                this.comboBoxNomCommercial.Items.Add(me);
                comboBoxNomCommercial.SelectedIndex = 0;

            }
        }




        private void comboListeVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAjoutRapport_Load(object sender, EventArgs e)
        {
            this.getVisiteurs();
            this.getMedecin();
            this.getQuantite();
            this.recupFamillePourMedicament();
            this.getNomCommercial();
            this.textBoxIdRapport.Text = this.getIdRapportCree().ToString();
            this.textBoxIdMedicament.Text = this.CreateIdMedicament();


        }

        //fontion pour inserer automatiquement un id lors de la creation d'un rapport
        private int getIdRapportCree()
        {
            var reqDernier = (from rap in this.mesRapports.rapport
                              orderby rap.id descending
                              select rap);
            rapport dernierEleve = reqDernier.First();
            int n = dernierEleve.id + 1;
            return n;
        }

        // genere une cle primaire Medicament aleatoirement 
        private string  CreateIdMedicament()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[4];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            string resultString = new string(Charsarr);

            return resultString.ToString();
        }


        //remplis le combobox quantite jusqu'a 100

        private void getQuantite()
        {
            for(int i = 1; i <= 100; i++)
            {
                this.comboBoxQuantite.Items.Add(i);

            }
        }

        //permet d'ajouter les infos d'un medicament d'un rapport 

        private void InsertRapportExtemsion()
        {

            // preparation des variables table medecament et offrir 


            string idMedicament = this.textBoxIdMedicament.Text;
            string nomCommercial = Convert.ToString(this.comboBoxNomCommercial.Text);
            string idFamilleMedicament = Convert.ToString(this.comboBoxIdFamille.Text);
            string compostionMdicament = Convert.ToString(this.textBoxComposition.Text);
            string effetMedicament = Convert.ToString(this.textBoxEffet.Text);
            string contreIndication = Convert.ToString(this.textBoxContreIndication.Text);
            int quantite = Convert.ToInt32(this.comboBoxQuantite.Text);
            int idRapport = Convert.ToInt32(this.textBoxIdRapport.Text);

            //instatention des instances (medicament et offrir) 

            offrir occurenceceOffrir = new offrir();
            medicament occurenceMedicament = new medicament();

            //insertion des valeurs de l'occurence offrir 

            occurenceceOffrir.idMedicament = idMedicament;
            occurenceceOffrir.idRapport = idRapport;
            occurenceceOffrir.quantite = quantite;

            // insertion des valeurs de l'occurence medicament 

            occurenceMedicament.id = idMedicament;
            occurenceMedicament.idFamille = idFamilleMedicament;
            occurenceMedicament.nomCommercial = nomCommercial;
            occurenceMedicament.composition = compostionMdicament;
            occurenceMedicament.effets = effetMedicament;
            occurenceMedicament.contreIndications =contreIndication;

            //Ajout dns la table medicament
            this.mesRapports.offrir.Add(occurenceceOffrir);
            this.mesRapports.medicament.Add(occurenceMedicament);
        }

        // permet d'ajouter un rapport
        private void InsertRapport()
        {

            //preparation des variables table Rapport initiale 

            int idRapport = Convert.ToInt32(this.textBoxIdRapport.Text);
            DateTime dateRapport = this.dateTimeRapport.Value;
            string rapportMotif = Convert.ToString(this.textboxMotif.Text);
            string rapportBilan = Convert.ToString(this.textBilan.Text);
            int  idMedecin =    Convert.ToInt32(this.ComboListeMedecin.Text);
            string  idVisiteur = Convert.ToString(this.comboListeVisiteur.Text);

            //creation d'une occurence de type rapport */

            rapport occurenceRapport = new rapport();



            // insertion des valeurs de l'occurence rapport

            occurenceRapport.id = idRapport;
            occurenceRapport.date = dateRapport;
            occurenceRapport.motif = rapportMotif;
            occurenceRapport.bilan = rapportBilan;
            occurenceRapport.idMedecin= idMedecin;
            occurenceRapport.idVisiteur = idVisiteur;

            //Enregistrement Formulaire Ajout rapport 

            this.mesRapports.rapport.Add(occurenceRapport);



        }


        private void buttonEnregistrementRapport_Click(object sender, EventArgs e)
        {


            this.InsertRapport();
            this.InsertRapportExtemsion();
            this.mesRapports.SaveChanges();
            MessageBox.Show($"Rapport N{this.getIdRapportCree()-1} ajouter !");
            this.Close();

        }

        private void textBoxIdRapport_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBilan_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
