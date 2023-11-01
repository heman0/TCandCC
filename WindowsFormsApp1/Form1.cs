using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Collections.Generic;
using WindowsFormsApp1.App_Code;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        DataTableCollection tableCollection;

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });

                            tableCollection = ds.Tables;
                            DataTable dt = tableCollection[0];

                            // Get distinct records based on the EnrollmentNo
                            DataTable distinctDataTable = RemoveDuplicates(dt, "EnrollmentNo");

                            // Set the DataGridView.DataSource to the distinct view
                            gridShowData.DataSource = distinctDataTable;

                            // Export to SQL Server
                            try
                            {
                                int i = ExportToSqlServer(distinctDataTable, "tbl_Student_Info");
                                MessageBox.Show("Imported "+i+" records", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            


                        }
                    }
                }
            }
        }
        private DataTable RemoveDuplicates(DataTable dataTable, string primaryKeyColumnName)
        {
            var uniqueKeys = new HashSet<string>();
            var distinctDataTable = dataTable.Clone();

            foreach (DataRow row in dataTable.Rows)
            {
                string keyValue = row[primaryKeyColumnName].ToString();

                // Check if the key is already in the HashSet
                if (uniqueKeys.Add(keyValue))
                {
                    // If not, add the row to the distinctDataTable
                    distinctDataTable.ImportRow(row);
                }
            }

            return distinctDataTable;
        }


        private int ExportToSqlServer(DataTable dataTable, string tableName)
        {
            int var =0;
            foreach (DataRow row in dataTable.Rows)
            {
                // Check if the record already exists in the table based on the primary key
                long enrollmentNo = Convert.ToInt64(row["EnrollmentNo"]);
                bool recordExists = RecordExists(Utility.strconn, tableName, "EnrollmentNo", enrollmentNo);

                if (!recordExists)
                {
                    SqlParameter[] pArr =
                    {
                               new SqlParameter("@action", SqlDbType.VarChar) { Value = "insertAllRecordsFromExcelFile" },
                              new SqlParameter("@EnrollmentNo", SqlDbType.BigInt) { Value = row["EnrollmentNo"] },
                             new SqlParameter("@rollNo", SqlDbType.BigInt) { Value = row["RollNo"] },
                            new SqlParameter("@sRNo", SqlDbType.BigInt) { Value = row["SRNo"] },
                             new SqlParameter("@studentName", SqlDbType.VarChar) { Value = row["StudentName"] },
                              new SqlParameter("@fatherName", SqlDbType.VarChar) { Value = row["FatherName"] },
                               new SqlParameter("@motherName", SqlDbType.VarChar) { Value = row["MotherName"] },
                              new SqlParameter("@address", SqlDbType.VarChar) { Value = row["Address"] },
                             new SqlParameter("@dob", SqlDbType.Date) { Value = row["DoB"] },
                            new SqlParameter("@admissionDate", SqlDbType.Date) { Value = row["AdmissionDate"] },
                             new SqlParameter("@duesClearedUpto", SqlDbType.Date) { Value = row["DuesClearedUpto"] },
                              new SqlParameter("@dateOfLeaving", SqlDbType.Date) { Value = row["DateOfLeaving"] },
                               new SqlParameter("@classPassed", SqlDbType.VarChar) { Value = row["ClassPassed"] },
                              new SqlParameter("@session", SqlDbType.VarChar) { Value = row["Session"] },
                             new SqlParameter("@attendance", SqlDbType.BigInt) { Value = row["Attendance"] },
                            new SqlParameter("@remark", SqlDbType.VarChar) { Value = row["Remark"] },
                             new SqlParameter("@studentPicture", SqlDbType.VarChar) { Value = row["StudentPicture"] },
                              new SqlParameter("@tCCreated", SqlDbType.Date) { Value = row["TCCreated"] },
                               new SqlParameter("@cCCreated", SqlDbType.Date) { Value = row["CCCreated"] },
                        };
                   
                    int i = SqlHelper.ExecuteNonQuery(Utility.strconn, CommandType.StoredProcedure, SProcedures.manageStudent, pArr);
                    var += i;
                }

            }
            return var;


        }


        private bool RecordExists(string connection, string tableName, string columnName, long columnValue)
        {
            SqlConnection con = new SqlConnection(connection);
            using (SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @ColumnValue", con))
            {
                con.Open();
                command.Parameters.AddWithValue("@ColumnValue", columnValue);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            gridShowData.Visible = false;
        }

        private void pnlDeleteStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudentRecord updateStudentRecord = new SearchStudentRecord();
            updateStudentRecord.ShowDialog();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
