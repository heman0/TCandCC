using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp1.App_Code;

namespace WindowsFormsApp1
{
    public partial class CCReportView : Form
    {

        private long enrollmentID;
        private long rollNo;
        private string name;
        private string fatherName;
        private string motherName;
        private string address;
        private string dob;
        private string admissionDate;
        private string duesCleared;
        private string dateOfLeave;
        private string classPassed;
        private string session;
        private long attendance;
        private string remark;
        private string studentPicture;
        
        public CCReportView()
        {
            InitializeComponent();

            //this.Load += CCReportView_Load;
            this.Resize += reportviewer1_Resize;
        }


        private void CCReportView_Load(object sender, EventArgs e)
        {
            reportView();
            this.reportViewer1.RefreshReport();

        }
        public void reportView()
        {

            SqlParameter[] paramss = {
                new SqlParameter("action",SqlDbType.VarChar){Value="fetchStudentRecordForCC"}
            };
            DataSet ds = SqlHelper.ExecuteDataset(Utility.strconn, CommandType.StoredProcedure, SProcedures.manageStudent, paramss);
            DataTable dt = ds.Tables[0];
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string reportPath = "CCreport.rdlc"; // Assuming the report file is in the project root
            reportViewer1.LocalReport.ReportPath = Path.Combine("D:\\Microsoft Visual Studio\\Projects\\TCandCC\\WindowsFormsApp1\\", reportPath);

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter("RollNo", rollNo.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("EnrollmentNo", enrollmentID.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("RollNo", rollNo.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("StudentName", name.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("FatherName", fatherName.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("MotherName", motherName.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Address", address.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DOB", dob  .ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DateOfAdmission", admissionDate.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DuesClearedUpto", duesCleared.ToString()   ));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DateOfLeaving", dateOfLeave.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ClassPassed", classPassed.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Session", session.ToString()));
            //reportViewer1.LocalReport.SetParameters(new ReportParameter("Attendance", attendance.ToString()));
            //reportViewer1.LocalReport.SetParameters(new ReportParameter("Remark", remark.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("SRNo", "28"));
            //reportViewer1.LocalReport.SetParameters(new ReportParameter("TCCreated", tcCreated.ToString()));
            //reportViewer1.LocalReport.SetParameters(new ReportParameter("CCCreated", ccCreated.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Date", DateTime.Now.Date.ToString()));
            reportViewer1.LocalReport.Refresh();

        }

      

        public void fillData(long EnrollmentID, long RollNo, string name, string fatherName, string motherName, string address, string dob, string admissionDate, string duesCleared, string dateOfLeave, string classPassed, string session, long attendance, string Remark)
        {
            this.enrollmentID = EnrollmentID;
            this.rollNo = RollNo;
            this.name = name;
            this.fatherName = fatherName;
            this.motherName = motherName;
            this.address = address;
            this.dob = dob;
            this.admissionDate = admissionDate;
            this.duesCleared = duesCleared;
            this.dateOfLeave = dateOfLeave;
            this.classPassed = classPassed;
            this.session = session;
            this.attendance = attendance;
            this.remark = Remark;
            
            
        }
        private void reportviewer1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                // Call the resize function when the form is maximized
                resize();
            }
        }
        public void resize()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                // Set the width to 1500 when the form is maximized
                reportViewer1.Width = 600;
                reportViewer1.Height = 800;
            }
            else
            {
                reportViewer1.Width = 600;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reportView();
            this.reportViewer1.RefreshReport();
        }
    }
}
