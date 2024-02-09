using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.App_Code;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class GenerateCC : Form
    {
        private IEnumerable<object> dataTable;

        public GenerateCC()
        {
            InitializeComponent();
            fetchStudentRecordsInGridView();
            gridShowStudentRecordForCC.CellClick += gridShowStudentRecordForCC_CellClick;
        }

        private void btnSearchWithDetailsCC_Click_1(object sender, EventArgs e)
        {
            if (dropCourseCC.SelectedItem.ToString() == "" || txtNameCC.Text == "")
            {
                MessageBox.Show("Enter Name and Course", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fetchStudentRecordsInGridView();
            }
            else if (!IsString(txtNameCC.Text.ToString()))
            {
                MessageBox.Show("Enter a Valid Student Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                clsManageRecords cMR = new clsManageRecords();
                cMR.courseCode = dropCourseCC.SelectedValue.ToString();
                cMR.name = txtNameCC.Text.Trim();
                DataSet ds = cMR.fetchSpecifiRecordForCC();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gridShowStudentRecordForCC.DataSource = ds.Tables[0];
                }
                else
                {
                    gridShowStudentRecordForCC.DataSource = new DataTable();
                }
            }
        }

        private void btnSearchWithRollCC_Click(object sender, EventArgs e)
        {

            if (txtRoll.Text == "")
            {
                MessageBox.Show("Enter Roll No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!long.TryParse(txtRoll.Text, out _))
            {
                MessageBox.Show("Enter a valid Roll No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                clsManageRecords cMR = new clsManageRecords();
                cMR.Roll = Convert.ToInt64(txtRoll.Text.Trim());
                DataSet ds = cMR.fetchSpecifiRecordForCC();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gridShowStudentRecordForCC.DataSource = ds.Tables[0];
                }
                else
                {
                    gridShowStudentRecordForCC.DataSource = new DataTable();
                }
            }
        }

        public void fetchStudentRecordsInGridView()
        {
            clsManageRecords cMR = new clsManageRecords();
            DataSet ds = cMR.fetchAllRecordsForCC();
            if (ds.Tables[0].Rows.Count > 0)
            {
                gridShowStudentRecordForCC.DataSource = ds.Tables[0];

            }

        }

        private bool IsString(string input)
        {
            return input.All(char.IsLetter);
        }

        private void GenerateCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentTCandCCDataSet8.tbl_Courses' table. You can move, or remove it, as needed.
            this.tbl_CoursesTableAdapter1.Fill(this.studentTCandCCDataSet8.tbl_Courses);
            // TODO: This line of code loads data into the 'studentTCandCCDataSet7.tbl_Courses' table. You can move, or remove it, as needed.
            this.tbl_CoursesTableAdapter.Fill(this.studentTCandCCDataSet7.tbl_Courses);
            // TODO: This line of code loads data into the 'studentTCandCCDataSet3.tbl_Student_Info' table. You can move, or remove it, as needed.
            this.tbl_Student_InfoTableAdapter.Fill(this.studentTCandCCDataSet3.tbl_Student_Info);


        }

        private void gridShowStudentRecordForCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gridShowStudentRecordForCC.Columns["RollNo"].Index)
            {
                DataGridViewRow selectedRow = gridShowStudentRecordForCC.Rows[e.RowIndex];

                List<string> emptyFields = new List<string>();
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    if (string.IsNullOrEmpty(cell.Value?.ToString()))
                    {
                        emptyFields.Add(gridShowStudentRecordForCC.Columns[cell.ColumnIndex].Name);
                    }
                }

                if (emptyFields.Count > 0)
                {
                    string errorMessage = "The following fields are empty:\n" + string.Join("\n", emptyFields);
                    MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                long EnrollmentID = Convert.ToInt64(selectedRow.Cells["EnrollmentNo"].Value?.ToString() ?? string.Empty);
                long RollNo = Convert.ToInt64(selectedRow.Cells["RollNo"].Value?.ToString() ?? string.Empty);
                string name = selectedRow.Cells["StudentName"].Value?.ToString() ?? string.Empty;
                string fatherName = selectedRow.Cells["FatherName"].Value?.ToString() ?? string.Empty;
                string motherName = selectedRow.Cells["MotherName"].Value?.ToString() ?? string.Empty;
                string address = selectedRow.Cells["Address"].Value?.ToString() ?? string.Empty;
                string dob = selectedRow.Cells["DoB"].Value?.ToString() ?? string.Empty;
                string admissionDate = selectedRow.Cells["AdmissionDate"].Value?.ToString() ?? string.Empty;
                string duesCleared = selectedRow.Cells["DuesClearedUpto"].Value?.ToString() ?? string.Empty;
                string dateOfLeaving = selectedRow.Cells["DateOfLeaving"].Value?.ToString() ?? string.Empty;
                string classPassed = selectedRow.Cells["ClassPassed"].Value?.ToString() ?? string.Empty;
                string session = selectedRow.Cells["Session"].Value?.ToString() ?? string.Empty;
                long attendance = Convert.ToInt32(selectedRow.Cells["Attendance"].Value?.ToString() ?? string.Empty);
                //string studentPicture = selectedRow.Cells["StudentPicture"].Value?.ToString() ?? string.Empty;
                string Remark = selectedRow.Cells["Remark"].Value?.ToString() ?? string.Empty;
                //if (selectedRow.Cells["StudentName"].Value.ToString() == "")
                //{
                //    MessageBox.Show($"Please fill the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                CCReportView anotherForm = new CCReportView();
                anotherForm.fillData(EnrollmentID, RollNo, name, fatherName, motherName, address, dob, admissionDate, duesCleared, dateOfLeaving, classPassed, session, attendance, Remark);
                anotherForm.Show();
                //}
            }
        }

        private void lblNameCC_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCourseCC_Click(object sender, EventArgs e)
        {

        }


        private void dropCourseCC_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Get the selected item from the ComboBox
            string selectedCourseCode = dropCourseCC.SelectedValue?.ToString();

            if (!string.IsNullOrEmpty(selectedCourseCode))
            {
                // Fetch records for the selected course code
                clsManageRecords cMR = new clsManageRecords();
                cMR.courseCode = selectedCourseCode;
                DataSet ds = cMR.fetchAllRecordsForCC();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gridShowStudentRecordForCC.DataSource = ds.Tables[0];
                    gridShowStudentRecordForCC.Refresh();
                }
                else
                {
                    gridShowStudentRecordForCC.DataSource = null;

                }
            }
        }


    }
}
