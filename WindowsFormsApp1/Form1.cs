using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

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
                            ExportToSqlServer(distinctDataTable, "tbl_Student_Info");
                            MessageBox.Show("Import successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void ExportToSqlServer(DataTable dataTable, string tableName)
        {
            string connectionString = "Data Source=SDCMSSERVER\\SDCMSSQLSERVER;Initial Catalog=studentTCandCC;User ID=sdcmsm;Password=kingofring@9";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataRow row in dataTable.Rows)
                {
                    // Check if the record already exists in the table based on the primary key
                    long enrollmentNo = Convert.ToInt64(row["EnrollmentNo"]);
                    bool recordExists = RecordExists(connection, tableName, "EnrollmentNo", enrollmentNo);

                    if (!recordExists)
                    {
                        // If the record does not exist, insert it into the table
                        using (SqlCommand insertCommand = new SqlCommand(
                            $"INSERT INTO {tableName} (EnrollmentNo, RollNo, SRNo, StudentName, FatherName, MotherName, [Address], " +
                            "DoB, AdmissionDate, DuesClearedUpto, DateOfLeaving, ClassPassed, [Session], Attendance, Remark, StudentPicture) " +
                            "VALUES (@EnrollmentNo, @RollNo, @SRNo, @StudentName, @FatherName, @MotherName, @Address, " +
                            "@DoB, @AdmissionDate, @DuesClearedUpto, @DateOfLeaving, @ClassPassed, @Session, @Attendance, @Remark, @StudentPicture)", connection))
                        {
                            // Add parameters for each column in your DataTable
                            insertCommand.Parameters.AddWithValue("@EnrollmentNo", row["EnrollmentNo"]);
                            insertCommand.Parameters.AddWithValue("@RollNo", row["RollNo"]);
                            insertCommand.Parameters.AddWithValue("@SRNo", row["SRNo"]);
                            insertCommand.Parameters.AddWithValue("@StudentName", row["StudentName"]);
                            insertCommand.Parameters.AddWithValue("@FatherName", row["FatherName"]);
                            insertCommand.Parameters.AddWithValue("@MotherName", row["MotherName"]);
                            insertCommand.Parameters.AddWithValue("@Address", row["Address"]);
                            insertCommand.Parameters.AddWithValue("@DoB", row["DoB"]);
                            insertCommand.Parameters.AddWithValue("@AdmissionDate", row["AdmissionDate"]);
                            insertCommand.Parameters.AddWithValue("@DuesClearedUpto", row["DuesClearedUpto"]);
                            insertCommand.Parameters.AddWithValue("@DateOfLeaving", row["DateOfLeaving"]);
                            insertCommand.Parameters.AddWithValue("@ClassPassed", row["ClassPassed"]);
                            insertCommand.Parameters.AddWithValue("@Session", row["Session"]);
                            insertCommand.Parameters.AddWithValue("@Attendance", row["Attendance"]);
                            insertCommand.Parameters.AddWithValue("@Remark", row["Remark"]);
                            insertCommand.Parameters.AddWithValue("@StudentPicture", row["StudentPicture"]);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }

            }
        }


        private bool RecordExists(SqlConnection connection, string tableName, string columnName, long columnValue)
        {
            using (SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @ColumnValue", connection))
            {
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
            UpdateStudentRecord updateStudentRecord = new UpdateStudentRecord();
            updateStudentRecord.ShowDialog();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
