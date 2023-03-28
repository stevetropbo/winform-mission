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
    public partial class FrmVisualiser : Form
    {
        gsbrapports2021Entities gsbrapports;

        public FrmVisualiser(gsbrapports2021Entities gsbrapports)
        {
            InitializeComponent();
            this.gsbrapports = new gsbrapports2021Entities();
            this.gsbrapports = gsbrapports;
            this.dataGridViewRapport.AutoGenerateColumns = false;

            //creation nouvellee source de donnees a l'aide d'une requete 

            DateTime a = Convert.ToDateTime(this.comboBoxVisiteur.SelectedValue);
            var requetesup = from de in this.gsbrapports.rapport
                       where de.idVisiteur == this.comboBoxVisiteur.SelectedValue.ToString() 
                       select de;

            List<rapport> rapListe = new List<rapport>();

            foreach(var emp1 in requetesup)
            {
                rapListe.Add(emp1);
            }
           
            //Chargement du composant de binding des tables en relation avec la table rapport 
            //table offrir 

            this.bdgOffrir.DataSource = this.gsbrapports.offrir.ToList();

            //table medicament

            this.bdgMedicament.DataSource = this.gsbrapports.medicament.ToList();

            // création d'une colonne de type text pour la quantite de la table offrir
            DataGridViewTextBoxColumn txtColonneQuantite = new DataGridViewTextBoxColumn();
            txtColonneQuantite.HeaderText = "Quantite";
            txtColonneQuantite.Name = "quantite";
            txtColonneQuantite.DataPropertyName = "quantite";
            this.dataGridViewRapport.Columns.Add(txtColonneQuantite);

            // création d'une colonne de type text pour la id famille de la table medicament
            DataGridViewTextBoxColumn txtColonneidFamille = new DataGridViewTextBoxColumn();
            txtColonneidFamille.HeaderText = "ID Famille";
            txtColonneidFamille.Name = "idFamille";
            txtColonneidFamille.DataPropertyName = "idFamille";
            this.dataGridViewRapport.Columns.Add(txtColonneidFamille);


            // création d'une colonne de type text pour le nom commercial de la table medicament
            DataGridViewTextBoxColumn txtColonneNomCommercial = new DataGridViewTextBoxColumn();
            txtColonneNomCommercial.HeaderText = "Nom Commercial";
            txtColonneNomCommercial.Name = "nomCommercial";
            txtColonneNomCommercial.DataPropertyName = "nomCommercial";
            this.dataGridViewRapport.Columns.Add(txtColonneNomCommercial);

            // création d'une colonne de type text pour l'effet de la table medicament
            DataGridViewTextBoxColumn txtColonneEffet = new DataGridViewTextBoxColumn();
            txtColonneEffet.HeaderText = "Effet";
            txtColonneEffet.Name = "effet";
            txtColonneEffet.DataPropertyName = "effets";
            this.dataGridViewRapport.Columns.Add(txtColonneEffet);

            // création d'une colonne de type text pour contre indication de la table medicament
            DataGridViewTextBoxColumn txtColonneContreIndication = new DataGridViewTextBoxColumn();
            txtColonneContreIndication.HeaderText = "Contre indication";
            txtColonneContreIndication.Name = "contreIndication";
            txtColonneContreIndication.DataPropertyName = "contreIndications";
            this.dataGridViewRapport.Columns.Add(txtColonneContreIndication);



            // création d'une colonne de type text pour id de la table rapport
            DataGridViewTextBoxColumn txtColonneid = new DataGridViewTextBoxColumn();
            txtColonneid.HeaderText = "ID Rapport";
            txtColonneid.Name = "id";
            txtColonneid.DataPropertyName = "id";
            this.dataGridViewRapport.Columns.Add(txtColonneid);


            // création d'une colonne de type text pour date de la table rapport
            DataGridViewTextBoxColumn txtColonneDate = new DataGridViewTextBoxColumn();
            txtColonneDate.HeaderText = "date";
            txtColonneDate.Name = "date";
            txtColonneDate.DataPropertyName = "date";
            this.dataGridViewRapport.Columns.Add(txtColonneDate);

            // création d'une colonne de type text pour le bilan de la table rapport
            DataGridViewTextBoxColumn txtColonneBilan = new DataGridViewTextBoxColumn();
            txtColonneBilan.HeaderText = "Bilan";
            txtColonneBilan.Name = "bilan";
            txtColonneBilan.DataPropertyName = "bilan";
            this.dataGridViewRapport.Columns.Add(txtColonneBilan);

            // création d'une colonne de type text pour le motif de la table rapport

            DataGridViewTextBoxColumn txtColonnemotif = new DataGridViewTextBoxColumn();
            txtColonneBilan.HeaderText = "Motif";
            txtColonneBilan.Name = "motif";
            txtColonneBilan.DataPropertyName = "motif";
            this.dataGridViewRapport.Columns.Add(txtColonneBilan);











            this.bdgRapport.DataSource = rapListe.ToList();



        }

        private void FrmVisualiser_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Filtrer_Click(object sender, EventArgs e)
        {
            DateTime a = Convert.ToDateTime(this.comboBoxVisiteur.SelectedValue);
            var requ = from de in this.gsbrapports.rapport
                       where de.idVisiteur == this.comboBoxVisiteur.SelectedValue.ToString() && de.date == a
                       select de;


            this.bdgRapport.DataSource = requ.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bdgRapport.EndEdit();
            this.bdgMedicament.EndEdit();
            this.bdgOffrir.EndEdit();
            this.gsbrapports.SaveChanges();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
