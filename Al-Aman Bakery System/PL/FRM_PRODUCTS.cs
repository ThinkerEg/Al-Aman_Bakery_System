using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Al_Aman_Bakery_System.PL
{
    public partial class FRM_PRODUCTS : Form
    {
        BL.Class_Products prod = new BL.Class_Products();

        public FRM_PRODUCTS()
        {
            InitializeComponent();
        }

        private void FRM_PRODUCTS_Load(object sender, EventArgs e)
        {
            LoadData(); // تحميل البيانات فور فتح الشاشة
        }

        // دالة لجلب وتحديث الجدول
        private void LoadData()
        {
            dgv_Products.DataSource = prod.GetAllProducts(); // تأكد من وجود دالة GetAll في الـ BL
        }

        // زرار إضافة جديد (تنظيف الحقول)
        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_ProdName.Clear();
            num_Weight.Value = 0;
            num_PriceWholesale.Value = 0;
            num_PriceSemi.Value = 0;
            num_PriceRetail.Value = 0;
            txt_ProdName.Focus();
        }

        // زرار الإضافة
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                prod.Add_Product(txt_ProdName.Text, num_Weight.Value, num_PriceWholesale.Value,
                                 num_PriceSemi.Value, num_PriceRetail.Value);

                MessageBox.Show("تم إضافة المنتج بنجاح!", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btn_New_Click(null, null); // تنظيف بعد الإضافة
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء الإضافة: " + ex.Message);
            }
        }

        // زرار البحث
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_Products.DataSource = prod.Search_Products(txt_Search.Text);
        }

        // أحداث الهيدر (إغلاق وتصغير)
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // حدث الضغط على الصف في الجدول
        private void dgv_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Products.Rows[e.RowIndex];
                txt_ProdName.Text = row.Cells[1].Value.ToString();
                num_Weight.Value = Convert.ToDecimal(row.Cells[2].Value);
                // أكمل باقي الحقول بنفس الطريقة...
            }
        }
    }
}