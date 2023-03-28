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
    public partial class FrmRapport : Form
    {
        private gsbrapports2021Entities mesRapports;
        public FrmRapport()
        {
            InitializeComponent();
            this.mesRapports = new gsbrapports2021Entities();
            
        }

        private void FrmRapport_Load(object sender, EventArgs e)
        {

        }

        private void ajoutRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutRapport f = new FrmAjoutRapport(this.mesRapports);
            f.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void visualiserLesRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisualisation f = new FrmVisualisation(this.mesRapports);
            f.Show();

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificationRapport f = new FrmModificationRapport(this.mesRapports);
            f.Show();
        }
    }
}
