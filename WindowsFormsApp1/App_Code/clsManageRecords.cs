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
    public class clsManageRecords
    {
        public long Enroll { get; set; }
        public long Roll { get; set; }
        public long sRNo { get; set; }
        public string name { get; set; }
        public string fatherName { get; set; }
        public string motherName { get; set; }
        public string address { get; set; }
        public string dob { get; set; }
        public string admissionDate { get; set; }
        public string duesClearedUpTo { get; set; }
        public string dateOfLeaving { get; set; }
        public string classPassed { get; set; }
        public string session { get; set; }
        public long attendance { get; set; }
        public string remark { get; set; }


        public DataSet fetchAllRecordsForUpdate()
        {
            SqlConnection conn = new SqlConnection(Utility.strconn);
            string sqlQuery = "select [EnrollmentNo],[RollNo],[SRNo],[StudentName],[FatherName],[MotherName],[Address],[DoB],[AdmissionDate],[DuesClearedUpTo],[DateOfLeaving],[ClassPassed],[Session],[Attendance],[Remark],[StudentPicture],[TCCreated],[CCCreated] from tbl_Student_Info";
            SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet fetchSpecificStudentRecord()
        {
            SqlConnection conn = new SqlConnection(Utility.strconn);
            string sqlQuery = "select [EnrollmentNo],[RollNo],[SRNo],[StudentName],[FatherName],[MotherName],[Address],[DoB],[AdmissionDate],[DuesClearedUpTo],[DateOfLeaving],[ClassPassed],[Session],[Attendance],[Remark],[StudentPicture],[TCCreated],[CCCreated] from tbl_Student_Info where RollNo like '" + Roll + "%' or EnrollmentNo like " + Enroll + " or StudentName like '" + name + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public int updateStudentRecord()
        {
            SqlParameter[] pArr =
                     {
                               new SqlParameter("@action", SqlDbType.VarChar) { Value = "updateStudentRecord" },
                             new SqlParameter("EnrollmentNo", SqlDbType.BigInt) { Value = Enroll },
                             new SqlParameter("@studentName", SqlDbType.VarChar) { Value =  name},
                              new SqlParameter("@fatherName", SqlDbType.VarChar) { Value =  fatherName},
                               new SqlParameter("@motherName", SqlDbType.VarChar) { Value =  motherName},
                              new SqlParameter("@address", SqlDbType.VarChar) { Value = address},
                             new SqlParameter("@dob", SqlDbType.Date) { Value = dob},
                            new SqlParameter("@admissionDate", SqlDbType.Date) { Value =  admissionDate},
                             new SqlParameter("@duesClearedUpto", SqlDbType.Date) { Value =  duesClearedUpTo},
                              new SqlParameter("@dateOfLeaving", SqlDbType.Date) { Value =  dateOfLeaving},
                               new SqlParameter("@classPassed", SqlDbType.VarChar) { Value =  classPassed},
                              new SqlParameter("@session", SqlDbType.VarChar) { Value = session},
                             new SqlParameter("@attendance", SqlDbType.BigInt) { Value = attendance},
                            new SqlParameter("@remark", SqlDbType.VarChar) { Value =  remark},

                        };
            int response = SqlHelper.ExecuteNonQuery(Utility.strconn, CommandType.StoredProcedure, SProcedures.manageStudent, pArr);
            return response;
        }
        public int addNewRecord()
        {

            SqlParameter[] pArr =
                     {
                               new SqlParameter("@action", SqlDbType.VarChar) { Value = "addNewStudentRecord" },
                             new SqlParameter("@EnrollmentNo", SqlDbType.BigInt) { Value = Enroll },
                              new SqlParameter("@RollNo", SqlDbType.BigInt) { Value = Roll },
                             new SqlParameter("@studentName", SqlDbType.VarChar) { Value =  name},
                              new SqlParameter("@fatherName", SqlDbType.VarChar) { Value =  fatherName},
                               new SqlParameter("@motherName", SqlDbType.VarChar) { Value =  motherName},
                              new SqlParameter("@address", SqlDbType.VarChar) { Value = address},
                             new SqlParameter("@dob", SqlDbType.Date) { Value = dob},
                            new SqlParameter("@admissionDate", SqlDbType.Date) { Value =  admissionDate},
                             new SqlParameter("@duesClearedUpto", SqlDbType.Date) { Value =  duesClearedUpTo},
                              new SqlParameter("@dateOfLeaving", SqlDbType.Date) { Value =  dateOfLeaving},
                               new SqlParameter("@classPassed", SqlDbType.VarChar) { Value =  classPassed},
                              new SqlParameter("@session", SqlDbType.VarChar) { Value = session},
                             new SqlParameter("@attendance", SqlDbType.BigInt) { Value = attendance},
                            new SqlParameter("@remark", SqlDbType.VarChar) { Value =  remark},

                        };
            int response = SqlHelper.ExecuteNonQuery(Utility.strconn, CommandType.StoredProcedure, SProcedures.manageStudent, pArr);
            return response;
        }
    }
}
