using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Al_Aman_Bakery_System.BL
{
    class Class_RawProduction
    {
        // دالة إضافة إنتاج جديد
        public void Add_Raw_Production(string RawName, decimal TotalWeight, DateTime ProdDate)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@RawName", SqlDbType.NVarChar, 100);
            param[0].Value = RawName;

            param[1] = new SqlParameter("@TotalWeight", SqlDbType.Decimal);
            param[1].Value = TotalWeight;

            param[2] = new SqlParameter("@ProdDate", SqlDbType.DateTime);
            param[2].Value = ProdDate;

            dal.Open();
            dal.ExecuteCommand("SP_ADD_RAW_PRODUCTION", param);
            dal.Close();
        }
        // داخل كلاس BL.Class_RawProduction
        public DataTable GetProductsFiltered(string companies, string categories)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@CompanyList", SqlDbType.NVarChar) { Value = companies };
            param[1] = new SqlParameter("@CategoryList", SqlDbType.NVarChar) { Value = categories };

            DataTable dt = dal.SelectData("SP_SEARCH_PRODUCTS_DYNAMIC", param);
            return dt; // بنرجع البيانات للفورم وهي تتصرف
        }
    }
}