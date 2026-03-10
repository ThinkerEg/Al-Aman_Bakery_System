using Al_Aman_Bakery_System.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Aman_Bakery_System.PL
{
    public partial class FRM_Main : Form
    {
        public FRM_Main()
        {
            InitializeComponent();
        }

        private void itemMaterials_Click(object sender, EventArgs e)
        {
            HelperMethods.OpenChildForm(new FRM_MATERIALS());
        }

        private void تعريفالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperMethods.OpenChildForm(new FRM_SUPPLIERS());
        }
    }
}
