using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDP_GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExistingModel exmdlf = new FormExistingModel();
            exmdlf.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newModelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCrtNewModel nmdl = new FormCrtNewModel();
            nmdl.ShowDialog();
        }

        private void newPredictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewPrediction npf = new FormNewPrediction();
            npf.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void predictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExistingPredictions extpredf = new FormExistingPredictions();
            extpredf.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
