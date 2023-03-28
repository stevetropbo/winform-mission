
namespace Mission3GSB
{
    partial class FrmVisualiser
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
            this.components = new System.ComponentModel.Container();
            this.bdgRapport = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewRapport = new System.Windows.Forms.DataGridView();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.comboBoxVisiteur = new System.Windows.Forms.ComboBox();
            this.labelIdVisiteur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.labelIdMedecin = new System.Windows.Forms.Label();
            this.comboIdMedecin = new System.Windows.Forms.ComboBox();
            this.bdgOffrir = new System.Windows.Forms.BindingSource(this.components);
            this.bdgMedicament = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOffrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // bdgRapport
            // 
            this.bdgRapport.DataSource = typeof(Mission3GSB.rapport);
            // 
            // dataGridViewRapport
            // 
            this.dataGridViewRapport.AllowUserToOrderColumns = true;
            this.dataGridViewRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRapport.Location = new System.Drawing.Point(104, 135);
            this.dataGridViewRapport.Name = "dataGridViewRapport";
            this.dataGridViewRapport.Size = new System.Drawing.Size(643, 150);
            this.dataGridViewRapport.TabIndex = 6;
            this.dataGridViewRapport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(370, 333);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.Enregistrer.TabIndex = 7;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxVisiteur
            // 
            this.comboBoxVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgRapport, "id", true));
            this.comboBoxVisiteur.DataSource = this.bdgRapport;
            this.comboBoxVisiteur.DisplayMember = "idVisiteur";
            this.comboBoxVisiteur.FormattingEnabled = true;
            this.comboBoxVisiteur.Location = new System.Drawing.Point(383, 71);
            this.comboBoxVisiteur.Name = "comboBoxVisiteur";
            this.comboBoxVisiteur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisiteur.TabIndex = 4;
            // 
            // labelIdVisiteur
            // 
            this.labelIdVisiteur.AutoSize = true;
            this.labelIdVisiteur.Location = new System.Drawing.Point(314, 79);
            this.labelIdVisiteur.Name = "labelIdVisiteur";
            this.labelIdVisiteur.Size = new System.Drawing.Size(63, 13);
            this.labelIdVisiteur.TabIndex = 2;
            this.labelIdVisiteur.Text = "ID visiteur  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgRapport, "date", true));
            this.comboBoxDate.DataSource = this.bdgRapport;
            this.comboBoxDate.DisplayMember = "date";
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(160, 71);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDate.TabIndex = 3;
            // 
            // labelIdMedecin
            // 
            this.labelIdMedecin.AutoSize = true;
            this.labelIdMedecin.Location = new System.Drawing.Point(542, 79);
            this.labelIdMedecin.Name = "labelIdMedecin";
            this.labelIdMedecin.Size = new System.Drawing.Size(68, 13);
            this.labelIdMedecin.TabIndex = 8;
            this.labelIdMedecin.Text = "ID Medecin :";
            // 
            // comboIdMedecin
            // 
            this.comboIdMedecin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgRapport, "idMedecin", true));
            this.comboIdMedecin.DataSource = this.bdgRapport;
            this.comboIdMedecin.DisplayMember = "idMedecin";
            this.comboIdMedecin.FormattingEnabled = true;
            this.comboIdMedecin.Location = new System.Drawing.Point(616, 71);
            this.comboIdMedecin.Name = "comboIdMedecin";
            this.comboIdMedecin.Size = new System.Drawing.Size(121, 21);
            this.comboIdMedecin.TabIndex = 15;
            // 
            // bdgOffrir
            // 
            this.bdgOffrir.DataSource = typeof(Mission3GSB.offrir);
            // 
            // bdgMedicament
            // 
            this.bdgMedicament.DataSource = typeof(Mission3GSB.medicament);
            // 
            // FrmVisualiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.comboIdMedecin);
            this.Controls.Add(this.labelIdMedecin);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.dataGridViewRapport);
            this.Controls.Add(this.comboBoxVisiteur);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.labelIdVisiteur);
            this.Controls.Add(this.label1);
            this.Name = "FrmVisualiser";
            this.Text = "FrmVisualiser";
            this.Load += new System.EventHandler(this.FrmVisualiser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOffrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bdgRapport;
        private System.Windows.Forms.DataGridView dataGridViewRapport;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.ComboBox comboBoxVisiteur;
        private System.Windows.Forms.Label labelIdVisiteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.Label labelIdMedecin;
        private System.Windows.Forms.ComboBox comboIdMedecin;
        private System.Windows.Forms.BindingSource bdgOffrir;
        private System.Windows.Forms.BindingSource bdgMedicament;
    }
}