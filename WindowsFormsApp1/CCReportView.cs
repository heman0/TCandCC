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
using WindowsFormsApp1.App_Code;

namespace WindowsFormsApp1
{
    public partial class CCReportView : Form
    {
        public CCReportView()
        {
            InitializeComponent();
            //this.Load += CCReportView_Load;
           
        }


        private void CCReportView_Load(object sender, EventArgs e)
        {

            reportView();
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
            reportViewer1.LocalReport.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportView();
            this.reportViewer1.RefreshReport();
        }
    }
}
