using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Al_Aman_Bakery_System.PL
{
    public partial class FRM_MATERIALS : Form
    {
        // استدعاء كلاس الـ BL للتعامل مع البيانات
        BL.CLS_MATERIALS mat = new BL.CLS_MATERIALS();

        public FRM_MATERIALS()
        {
            InitializeComponent();
            // تحميل البيانات عند فتح الفورم
           // LoadData();
        }

        private void LoadData()
        {
            dgv_Materials.DataSource = mat.GET_ALL_MATERIALS();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MatName.Text == "")
                {
                    MessageBox.Show("من فضلك أدخل اسم الخامة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              //  mat.ADD_MATERIAL(txt_MatName.Text, num_Qty.Value, num_MinQty.Value);
                MessageBox.Show("تم حفظ الخامة بنجاح", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData(); // تحديث الجدول بعد الحفظ
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {
            txt_MatName.Clear();
            num_Qty.Value = 0;
            num_MinQty.Value = 0;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}