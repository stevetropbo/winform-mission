using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Mission3GSB
{
    [System.Serializable]
    public partial class FrmVisualisation : Form
    {
        gsbrapports2021Entities gsbrapports;
        public FrmVisualisation( gsbrapports2021Entities gsbrapports)
        {
            InitializeComponent();
            this.gsbrapports = new gsbrapports2021Entities();
            this.gsbrapports = gsbrapports;
            this.bdgRapports.DataSource = this.gsbrapports.rapport.ToList();

        }


        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
        public void getMedecin()
        {
            List<medecin> lesMedecin = this.gsbrapports.medecin.ToList();

            var req = (from me in lesMedecin
                      select me.id).Distinct();

            foreach (var me in req)
            {
                this.comboBoxMedecin.Items.Add(me);
                this.comboBoxMedecin.SelectedIndex = 0;
            }

        }
        public void getVisiteur()
        {
            List<visiteur> lesVisituer = this.gsbrapports.visiteur.ToList();

            var req = (from me in lesVisituer
                       select me.id).Distinct();

            foreach (var me in req)
            {
                this.comboBoxVisteur.Items.Add(me);
                this.comboBoxVisteur.SelectedIndex = 0;
            }

        }
        private void FrmVisualisation_Load(object sender, EventArgs e)
        {
            this.getMedecin();
            this.getVisiteur();
        }
        private void buttonEnregistrerXml_Click(object sender, EventArgs e)
        {
            //Recuperation des valeurs pour l'objet cree
            int idRapport = Convert.ToInt32(this.textBoxIdRapport.Text);
            string rapportMotif = Convert.ToString(this.textBoxMotif.Text);
            string rapportBilan = Convert.ToString(this.textBoxBilan.Text);
            DateTime dat = this.dateTimePicker1.Value;
            int idLeMedecin = Convert.ToInt32(this.comboBoxMedecin.Text);
            string idLeVisiteur = Convert.ToString(this.comboBoxVisteur.Text);
            int quantite = Convert.ToInt32(this.textBoxQuantite.Text);
            string idMedicament = this.textBoxIdMedicament.Text;
            string nomCommercial = this.textBoxNomCommercial.Text;
            string idFamille = this.textBoxIdFamille.Text;
            string composition = this.textBoxComposition.Text;
            string contreIndications = this.textBoxContreIndication.Text;

            //Nous allons transferer les valeurs recuperer vers une instance de rapportXML
            rapportXml r = new rapportXml(idRapport, dat, rapportBilan, rapportMotif, idLeMedecin, idLeVisiteur, quantite, idMedicament, nomCommercial, idFamille, composition, composition, contreIndications);


            //generer fichier XML
            xml.Daowland("chrisitan.xml", r);

            MessageBox.Show($"Fichier Generer !");




        }
        //Generer fichier xml
        public class xml
        {
            /// <summary>
            /// Methode qui nous permet de serealiser notre systeme
            /// </summary>
            /// <param name="nomSauvegarde">nom du fichier a sauvegarder </param>
            /// <param name="instanceClasseConteneur">instance de la classe conteneur</param>
            /// <returns>Ne retourne aucune valeur </returns>

            public static void sauvegarde(string nomSauvegarde, rapportXml g)
            {
                FileStream fichier = new FileStream(nomSauvegarde, FileMode.Create);
                XmlSerializer bf = new XmlSerializer(g.GetType());
                bf.Serialize(fichier, g);
                fichier.Close();

            }


            public static void Daowland(string nomSauvegarde,rapportXml g)
            {
                using (StreamWriter streamWriter = new StreamWriter(nomSauvegarde, false))
                {
                    XmlSerializer bf = new XmlSerializer(g.GetType());
                    bf.Serialize(streamWriter, g);

                }

            }
            
        }
        public class rapportXml
        {

            //table rapport 
            public int id;
            public DateTime date;
            public string bilan;
            public string motif;
            public int idMedecin;
            public string idVisiteur;

            //table offir
            public int quantite;

            //table medicament
            public string idMedicament;
            public string nomCommercial;
            public string idFamille;
            public string composition;
            public string effets;
            public string contreIndication;




            public rapportXml(int i, DateTime d, string b, string m, int idM, string idV, int q, string idMe, string nomC, string idF, string com, string eff, string conteI)
            {
                this.id = i;
                this.date = d;
                this.bilan = b;
                this.motif = m;
                this.idMedecin = idM;
                this.idVisiteur = idV;
                this.quantite = q;
                this.idMedicament = idMe;
                this.nomCommercial = nomC;
                this.composition = com;
                this.idFamille = idF;
                this.effets = eff;
                this.contreIndication = conteI;
            }
            public rapportXml(int i, DateTime d, string b, string m, int idM, string idV)
            { 
                this.id = i;
                this.date = d;
                this.bilan = b;
                this.motif = m;
                this.idMedecin = idM;
                this.idVisiteur = idV;
                
            }
            //constructeur sans paramettre pour eviter l'erreur de serealisation
            public rapportXml()
            {

            }
            //setteur 
            public void setContreIndication(string i)
            {
                this.contreIndication = i;
            }
            public void setIdEffet(string i)
            {
                this.effets = i;
            }
            public void setIdFamille(string i)
            {
                this.idFamille = i;
            }
            public void setIdComposition(string i)
            {
                this.composition = i;
            }
            public void setIdNomCommercial(string i)
            {
                this.nomCommercial = i;
            }
            public void setIdMedicament(string i)
            {
                this.idMedicament = i;
            }
            public void setQuantite(int i)
            {
                this.quantite = i;
            }
            public void setIdVisiteur(string i)
            {
                this.idVisiteur = i;
            }
            public void setIMedecin(int i)
            {
                this.idMedecin = i;
            }
            public void setMotif(string i)
            {
                this.motif = i;
            }
            public void setBilan(string i)
            {
                this.bilan = i;
            }

            public void setId(int i)
            {
                this.id = i;
            }
            public void setDate(DateTime i)
            {
                this.date = i;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dat = this.dateTimePicker1.Value;
            int idLeMedecin = Convert.ToInt32(this.comboBoxMedecin.Text);
            string idLeVisiteur = Convert.ToString(this.comboBoxVisteur.Text);

            var req = (from me in this.gsbrapports.rapport
                      where me.idVisiteur == idLeVisiteur  && me.idMedecin == idLeMedecin && me.date == dat
                      select me
                      ).Distinct();


            int idRapport = 0;

            foreach (var me in req)
            {
                this.textBoxBilan.Text = Convert.ToString(me.bilan);
                this.textBoxMotif.Text = me.motif;
                this.textBoxIdRapport.Text = Convert.ToString(me.id);
                idRapport = me.id;
            }



            var req2 = (from me in this.gsbrapports.offrir
                        where me.idRapport == idRapport
                        select me
                      ).Distinct();

            string idMedicamnet = " ";

            foreach (var me in req2)
            {
                this.textBoxQuantite.Text = Convert.ToString(me.quantite);
                idMedicamnet = me.idMedicament;

            }

            
            var req3 = (from me in this.gsbrapports.medicament
                        where me.id == idMedicamnet
                        select me
                      ).Distinct();


            foreach (var me in req3)
            {
                this.textBoxIdMedicament.Text = me.id;
                this.textBoxNomCommercial.Text = me.nomCommercial;
                this.textBoxIdFamille.Text = me.idFamille;
                this.textBoxEffets.Text = me.effets;
                this.textBoxComposition.Text = me.composition;
                this.textBoxContreIndication.Text = me.contreIndications;

            }






        }

        private void textBoxBilan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

   



