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
    public partial class FRM_RAW_PRODUCTION : Form
    {
        BL.Class_RawProduction clp = new BL.Class_RawProduction();

        public FRM_RAW_PRODUCTION()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // فحص سريع قبل الحفظ
            if (txt_ProdName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الصنف"); return;
            }

            try
            {

                // استدعاء الدالة
                clp.Add_Raw_Production(txt_ProdName.Text,
                                       num_TotalWeight.Value,
                                       dtp_ProdDate.Value);

                MessageBox.Show("تم الحفظ بنجاح يا مبرمج!", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // تنظيف الحقول
                txt_ProdName.Clear();
                num_TotalWeight.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في الحفظ: " + ex.Message);
            }
        }
    }
}
