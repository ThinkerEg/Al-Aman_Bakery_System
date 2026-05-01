using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Aman_Bakery_System.BL
{
    class Class_Products
    {
        public void Add_Product(string Name, decimal Weight, decimal PriceWholesale, decimal PriceSemi, decimal PriceRetail)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 100) { Value = Name };
            param[1] = new SqlParameter("@Weight", SqlDbType.Decimal) { Value = Weight };
            param[2] = new SqlParameter("@PriceWholesale", SqlDbType.Decimal) { Value = PriceWholesale };
            param[3] = new SqlParameter("@PriceSemi", SqlDbType.Decimal) { Value = PriceSemi };
            param[4] = new SqlParameter("@PriceRetail", SqlDbType.Decimal) { Value = PriceRetail };

            dal.Open();
            dal.ExecuteCommand("SP_ADD_PRODUCT", param);
            dal.Close();
        }
        public DataTable GetAllProducts()
        {
            // بنجهز الـ DAL عشان نتعامل مع قاعدة البيانات
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            // بنفتح الاتصال
            dal.Open();

            // بننفذ استعلام بسيط لجلب كل بيانات جدول المنتجات
            // تأكد أن اسم الجدول في قاعدة البيانات هو "Products"
            DataTable dt = dal.SelectData("SELECT * FROM Products", null);

            // بنقفل الاتصال بعد ما خلصنا
            dal.Close();

            // بنرجع الجدول للفورم (PL) عشان يتعرض
            return dt;
        }
        public DataTable Search_Products(string searchText)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            // بنجهز البراميتر اللي فيه نص البحث
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@SearchText", SqlDbType.NVarChar, 100);
            param[0].Value = searchText;

            // بنستدعي الـ Stored Procedure
            dal.Open();
            DataTable dt = dal.SelectData("SP_SEARCH_PRODUCTS", param);
            dal.Close();

            return dt;
        }
    }
}
