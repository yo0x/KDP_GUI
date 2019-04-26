using System;
using Microsoft.ML;
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
    public partial class FormCrtNewModel : Form
    {
        public FormCrtNewModel()
        {
            InitializeComponent();

        }

        private void BtnBrowseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Title = "Select a CSV file for testing the model" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lbStatusCsvFile.Text = "File Loaded";

                    txtBoxFilePathModelTest.Text = ofd.FileName;
                }
            }

        }

        private void BtnCloseNewMdl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBrowseFileTrain(object sender, EventArgs e)
        {
            using (OpenFileDialog ofdTrain = new OpenFileDialog() { Title = "Select a CSV file for trining the model" })
            {
                if (ofdTrain.ShowDialog() == DialogResult.OK)
                {
                    lbStatusCsvFile.Text = "File Loaded";

                    txtBoxFilePathModelTrain.Text = ofdTrain.FileName;
                }
            }
        }

        private void BtnBuildMdl_Click(object sender, EventArgs e)
        {
            MLContext mlContext = new MLContext(seed: 0);
            ModelDs myMlModel = new ModelDs(txtBoxFilePathModelTrain.Text, txtBoxFilePathModelTest.Text,mlContext);
            myMlModel.BuildModel();
            MessageBox.Show("OK Finished");

        }

        private void FormCrtNewModel_Load(object sender, EventArgs e)
        {

        }
    }
}
