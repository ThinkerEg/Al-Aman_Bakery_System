using System.Data;
using System.Data.SqlClient;

namespace Al_Aman_Bakery_System.BL
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    namespace Al_Aman_Bakery_System.BL
    {
        class Class_Suppliers
        {
            // دالة جلب كل الموردين
            public DataTable GetAllSuppliers()
            {
                DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                dal.Open();
                DataTable dt = dal.SelectData("SELECT * FROM Suppliers", null);
                dal.Close();
                return dt;
            }

            // دالة إضافة مورد جديد
            public void Add_Supplier(string name, string phone, string address, decimal balance, string type)
            {
                DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 100) { Value = name };
                param[1] = new SqlParameter("@Phone", SqlDbType.NVarChar, 20) { Value = phone };
                param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, 200) { Value = address };
                param[3] = new SqlParameter("@Balance", SqlDbType.Decimal) { Value = balance };
                param[4] = new SqlParameter("@Type", SqlDbType.NVarChar, 20) { Value = type };

                dal.Open();
                dal.ExecuteCommand("SP_ADD_SUPPLIER", param); // تأكد إن الـ SP موجود في قاعدة البيانات
                dal.Close();
            }

            // دالة البحث (استخدام الـ SP اللي عملناه سوا)
            public DataTable Search_Suppliers(string searchText)
            {
                DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@SearchText", SqlDbType.NVarChar, 100) { Value = searchText };

                DataTable dt = dal.SelectData("SP_SEARCH_SUPPLIERS", param);
                return dt;
            }
        }
    }
}