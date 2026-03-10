using System.Data;
using System.Data.SqlClient;

namespace Al_Aman_Bakery_System.BL
{
    class CLS_MATERIALS
    {
        // 1. دالة إضافة خامة جديدة
        public void ADD_MATERIAL(string Mat_Name, decimal Mat_Qty, decimal Min_Qty)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 100) { Value = Mat_Name };
            param[1] = new SqlParameter("@Qty", SqlDbType.Decimal) { Value = Mat_Qty };
            param[2] = new SqlParameter("@MinQty", SqlDbType.Decimal) { Value = Min_Qty };

            DAL.Open();
            DAL.ExecuteCommand("SP_ADD_MATERIAL", param);
            DAL.Close();
        }

        // 2. دالة جلب كل الخامات للعرض في الـ DataGridView
        public DataTable GET_ALL_MATERIALS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            DAL.Open();
            dt = DAL.SelectData("SP_GET_ALL_MATERIALS", null);
            DAL.Close();
            return dt;
        }

        // 3. دالة تعديل خامة (هنحتاجها لما نضغط على الجدول)
        public void EDIT_MATERIAL(int ID, string Mat_Name, decimal Mat_Qty, decimal Min_Qty)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.Int) { Value = ID };
            param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 100) { Value = Mat_Name };
            param[2] = new SqlParameter("@Qty", SqlDbType.Decimal) { Value = Mat_Qty };
            param[3] = new SqlParameter("@MinQty", SqlDbType.Decimal) { Value = Min_Qty };

            DAL.Open();
            DAL.ExecuteCommand("SP_EDIT_MATERIAL", param);
            DAL.Close();
        }
    }
}