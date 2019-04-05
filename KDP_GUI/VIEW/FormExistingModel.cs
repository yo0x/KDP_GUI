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
    public partial class FormExistingModel : Form
    {
        public FormExistingModel()
        {
            InitializeComponent();
        }

        private void BtnCloseMdl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
