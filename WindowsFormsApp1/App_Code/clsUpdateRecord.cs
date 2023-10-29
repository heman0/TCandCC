using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.App_Code
{
    public class clsUpdateRecord
    {
        public long Roll { get; set; }
        public long Enroll { get; set; }
        public string name { get; set; }
        string connectionString = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.TCandCCConnectionString"].ConnectionString;

        public DataSet fetchAllRecordsForUpdate()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string sqlQuery = "select * from tbl_Student_Info";
            SqlDataAdapter adp = new SqlDataAdapter(sqlQuery,conn);
            DataSet ds=new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet fetchSpecificStudentRecord()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string sqlQuery = "select * from tbl_Student_Info where RollNo like '"+Roll+"%' or EnrollmentNo like '"+Enroll+"%' or StudentName like '"+name+"%' ";
            SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
    }
}
