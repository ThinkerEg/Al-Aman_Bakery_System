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
    public partial class FRM_SUPPLIERS : Form
    {
        public FRM_SUPPLIERS()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // سنترك دوال الإضافة والتعديل فارغة الآن حتى نصل لمرحلة الربط بقاعدة البيانات
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Code to add supplier
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            // Code to clear fields
            txt_SuppName.Clear();
            txt_SuppPhone.Clear();
            txt_SuppAddress.Clear();
            num_SuppBalance.Value = 0;
        }

        private void FRM_SUPPLIERS_Load(object sender, EventArgs e)
        {
            // فرض إعدادات يدوية للأداة للتأكد من عملها
            num_SuppBalance.Minimum = 0;
            num_SuppBalance.Maximum = 1000000;
            num_SuppBalance.Value = 0;
           // num_SuppBalance.ReadOnly = false;
        }
    }
}