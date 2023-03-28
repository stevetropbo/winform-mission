
namespace Mission3GSB
{
    partial class FrmModificationRapport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificationRapport));
            this.dataGridViewModification = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboListeVisiteur = new System.Windows.Forms.ComboBox();
            this.dateTimeRapport = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFiltre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewMedcicament = new System.Windows.Forms.DataGridView();
            this.dataGridViewOffrir = new System.Windows.Forms.DataGridView();
            this.idRapportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgOfrrir = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFamilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgRapport = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModification)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedcicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOfrrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewModification
            // 
            this.dataGridViewModification.AutoGenerateColumns = false;
            this.dataGridViewModification.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewModification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.motifDataGridViewTextBoxColumn,
            this.bilanDataGridViewTextBoxColumn,
            this.idVisiteurDataGridViewTextBoxColumn,
            this.idMedecinDataGridViewTextBoxColumn});
            this.dataGridViewModification.DataSource = this.bdgRapport;
            this.dataGridViewModification.Location = new System.Drawing.Point(72, 195);
            this.dataGridViewModification.Name = "dataGridViewModification";
            this.dataGridViewModification.Size = new System.Drawing.Size(643, 151);
            this.dataGridViewModification.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Visiteur :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboListeVisiteur
            // 
            this.comboListeVisiteur.FormattingEnabled = true;
            this.comboListeVisiteur.Location = new System.Drawing.Point(386, 55);
            this.comboListeVisiteur.Name = "comboListeVisiteur";
            this.comboListeVisiteur.Size = new System.Drawing.Size(164, 28);
            this.comboListeVisiteur.TabIndex = 4;
            // 
            // dateTimeRapport
            // 
            this.dateTimeRapport.Location = new System.Drawing.Point(6, 57);
            this.dateTimeRapport.Name = "dateTimeRapport";
            this.dateTimeRapport.Size = new System.Drawing.Size(200, 26);
            this.dateTimeRapport.TabIndex = 5;
            this.dateTimeRapport.Value = new System.DateTime(2021, 10, 2, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonFiltre);
            this.groupBox1.Controls.Add(this.dateTimeRapport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboListeVisiteur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(106, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 177);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtres  Rapport initiale";
            // 
            // buttonFiltre
            // 
            this.buttonFiltre.Location = new System.Drawing.Point(231, 127);
            this.buttonFiltre.Name = "buttonFiltre";
            this.buttonFiltre.Size = new System.Drawing.Size(75, 30);
            this.buttonFiltre.TabIndex = 7;
            this.buttonFiltre.Text = "Filtrer ";
            this.buttonFiltre.UseVisualStyleBackColor = true;
            this.buttonFiltre.Click += new System.EventHandler(this.buttonFiltre_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 691);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewMedcicament
            // 
            this.dataGridViewMedcicament.AutoGenerateColumns = false;
            this.dataGridViewMedcicament.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMedcicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedcicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomCommercialDataGridViewTextBoxColumn,
            this.idFamilleDataGridViewTextBoxColumn,
            this.compositionDataGridViewTextBoxColumn,
            this.effetsDataGridViewTextBoxColumn,
            this.contreIndicationsDataGridViewTextBoxColumn});
            this.dataGridViewMedcicament.DataSource = this.bdgMedicament;
            this.dataGridViewMedcicament.Location = new System.Drawing.Point(72, 352);
            this.dataGridViewMedcicament.Name = "dataGridViewMedcicament";
            this.dataGridViewMedcicament.Size = new System.Drawing.Size(643, 150);
            this.dataGridViewMedcicament.TabIndex = 9;
            // 
            // dataGridViewOffrir
            // 
            this.dataGridViewOffrir.AutoGenerateColumns = false;
            this.dataGridViewOffrir.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOffrir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffrir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRapportDataGridViewTextBoxColumn,
            this.idMedicamentDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn});
            this.dataGridViewOffrir.DataSource = this.bdgOfrrir;
            this.dataGridViewOffrir.Location = new System.Drawing.Point(209, 508);
            this.dataGridViewOffrir.Name = "dataGridViewOffrir";
            this.dataGridViewOffrir.Size = new System.Drawing.Size(347, 150);
            this.dataGridViewOffrir.TabIndex = 10;
            // 
            // idRapportDataGridViewTextBoxColumn
            // 
            this.idRapportDataGridViewTextBoxColumn.DataPropertyName = "idRapport";
            this.idRapportDataGridViewTextBoxColumn.HeaderText = "Numero du Rapport ";
            this.idRapportDataGridViewTextBoxColumn.Name = "idRapportDataGridViewTextBoxColumn";
            // 
            // idMedicamentDataGridViewTextBoxColumn
            // 
            this.idMedicamentDataGridViewTextBoxColumn.DataPropertyName = "idMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.HeaderText = "Numero du Medicament";
            this.idMedicamentDataGridViewTextBoxColumn.Name = "idMedicamentDataGridViewTextBoxColumn";
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            // 
            // bdgOfrrir
            // 
            this.bdgOfrrir.DataSource = typeof(Mission3GSB.offrir);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Numero Medicament";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomCommercialDataGridViewTextBoxColumn
            // 
            this.nomCommercialDataGridViewTextBoxColumn.DataPropertyName = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.HeaderText = "NomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.Name = "nomCommercialDataGridViewTextBoxColumn";
            // 
            // idFamilleDataGridViewTextBoxColumn
            // 
            this.idFamilleDataGridViewTextBoxColumn.DataPropertyName = "idFamille";
            this.idFamilleDataGridViewTextBoxColumn.HeaderText = "Numero Famille du Medicament";
            this.idFamilleDataGridViewTextBoxColumn.Name = "idFamilleDataGridViewTextBoxColumn";
            // 
            // compositionDataGridViewTextBoxColumn
            // 
            this.compositionDataGridViewTextBoxColumn.DataPropertyName = "composition";
            this.compositionDataGridViewTextBoxColumn.HeaderText = "Composition";
            this.compositionDataGridViewTextBoxColumn.Name = "compositionDataGridViewTextBoxColumn";
            // 
            // effetsDataGridViewTextBoxColumn
            // 
            this.effetsDataGridViewTextBoxColumn.DataPropertyName = "effets";
            this.effetsDataGridViewTextBoxColumn.HeaderText = "Effets";
            this.effetsDataGridViewTextBoxColumn.Name = "effetsDataGridViewTextBoxColumn";
            // 
            // contreIndicationsDataGridViewTextBoxColumn
            // 
            this.contreIndicationsDataGridViewTextBoxColumn.DataPropertyName = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.HeaderText = "Contre Indications";
            this.contreIndicationsDataGridViewTextBoxColumn.Name = "contreIndicationsDataGridViewTextBoxColumn";
            // 
            // bdgMedicament
            // 
            this.bdgMedicament.DataSource = typeof(Mission3GSB.medicament);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Numero du Rapport";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date de creation";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // motifDataGridViewTextBoxColumn
            // 
            this.motifDataGridViewTextBoxColumn.DataPropertyName = "motif";
            this.motifDataGridViewTextBoxColumn.HeaderText = "Motif";
            this.motifDataGridViewTextBoxColumn.Name = "motifDataGridViewTextBoxColumn";
            // 
            // bilanDataGridViewTextBoxColumn
            // 
            this.bilanDataGridViewTextBoxColumn.DataPropertyName = "bilan";
            this.bilanDataGridViewTextBoxColumn.HeaderText = "Bilan";
            this.bilanDataGridViewTextBoxColumn.Name = "bilanDataGridViewTextBoxColumn";
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "Numero Visiteur ";
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "Numero Medecin";
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            // 
            // bdgRapport
            // 
            this.bdgRapport.DataSource = typeof(Mission3GSB.rapport);
            // 
            // FrmModificationRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.dataGridViewOffrir);
            this.Controls.Add(this.dataGridViewMedcicament);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewModification);
            this.Name = "FrmModificationRapport";
            this.Text = "FrmModificationRapport";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmModificationRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModification)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedcicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOfrrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewModification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboListeVisiteur;
        private System.Windows.Forms.DateTimePicker dateTimeRapport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bdgRapport;
        private System.Windows.Forms.BindingSource bdgMedicament;
        private System.Windows.Forms.BindingSource bdgOfrrir;
        private System.Windows.Forms.Button buttonFiltre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewMedcicament;
        private System.Windows.Forms.DataGridView dataGridViewOffrir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRapportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
    }
}