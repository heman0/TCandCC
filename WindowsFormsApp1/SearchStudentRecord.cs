using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using WindowsFormsApp1.App_Code;

namespace WindowsFormsApp1
{
    public partial class SearchStudentRecord : Form
    {
        public SearchStudentRecord()
        {
            InitializeComponent();
            fetchRecordsForUpdate();
            // Add Resize event handler
            gridShowDataForUpdate.CellClick += gridShowDataForUpdate_CellContentClick;
        }

        public void fetchRecordsForUpdate()
        {
            clsManageRecords upr = new clsManageRecords();
            DataSet ds = upr.fetchAllRecordsForUpdate();
            if (ds.Tables[0].Rows.Count > 0)
            {
                gridShowDataForUpdate.DataSource = ds.Tables[0];
            }
        }

        private void gridShowDataForUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gridShowDataForUpdate.Columns["RollNo"].Index)
            {
                DataGridViewRow selectedRow = gridShowDataForUpdate.Rows[e.RowIndex];
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
                string attendance = selectedRow.Cells["Attendance"].Value?.ToString() ?? string.Empty;
                //string studentPicture = selectedRow.Cells["StudentPicture"].Value?.ToString() ?? string.Empty;
                string Remark = selectedRow.Cells["Remark"].Value?.ToString() ?? string.Empty;
                //if (selectedRow.Cells["StudentName"].Value.ToString() == "")
                //{
                //    MessageBox.Show($"Please fill the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
              

                // Do something with the data, for example, open a form for updating the selected record
                UpdateStudentRecord updateForm = new UpdateStudentRecord();
                updateForm.fillData(EnrollmentID, RollNo, name, fatherName, motherName, address, dob, admissionDate, duesCleared, dateOfLeaving, classPassed, session, attendance,Remark);
                updateForm.ShowDialog();
            }

        }
        public void resize()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                // Set the width to 1500 when the form is maximized
                gridShowDataForUpdate.Width = 1530;
                gridShowDataForUpdate.Height = 700;
            }
            else
            {
                gridShowDataForUpdate.Width = 1000;
            }
        }

        private void UpdateStudentRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentTCandCCDataSet8.tbl_Courses' table. You can move, or remove it, as needed.
            this.tbl_CoursesTableAdapter.Fill(this.studentTCandCCDataSet8.tbl_Courses);
            // TODO: This line of code loads data into the 'studentTCandCCDataSet6.tbl_Student_Info' table. You can move, or remove it, as needed.
            this.tbl_Student_InfoTableAdapter4.Fill(this.studentTCandCCDataSet6.tbl_Student_Info);

        }
        private void UpdateStudentRecord_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                // Call the resize function when the form is maximized
                resize();
            }
        }

        private void btnSearchRecordForUpdate_Click_1(object sender, EventArgs e)
        {
            string userInput = txtSearchRecordForUpdate.Text.Trim();
            clsManageRecords clsUR = new clsManageRecords();
            if (userInput == "")
            {
                MessageBox.Show("Enter Roll No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataSet ds = clsUR.fetchAllRecordsForUpdate();
                if (ds.Tables.Count > 0)
                {
                    gridShowDataForUpdate.DataSource = ds.Tables[0];
                }
            }
            else if (!long.TryParse(txtSearchRecordForUpdate.Text, out _))
            {
                MessageBox.Show("Enter a valid Roll No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                clsUR.name = userInput;
                DataSet ds = clsUR.fetchSpecificStudentRecord();
                if (ds.Tables.Count > 0)
                {
                    gridShowDataForUpdate.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnSearchWithDetailsCC_Click(object sender, EventArgs e)
        {
            if (dropCourseSS.SelectedItem.ToString() == "" || txtNameCC.Text == "")
            {
                MessageBox.Show("Enter Name and Course", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }

          
            else if (!IsString(txtNameCC.Text.ToString()))
            {
                MessageBox.Show("Enter a Valid Student Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                clsManageRecords cMR = new clsManageRecords();
                cMR.courseCode = dropCourseSS.SelectedValue.ToString();
                cMR.name = txtNameCC.Text.Trim();
                DataSet ds = cMR.fetchSpecifiRecordForCC();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gridShowDataForUpdate.DataSource = ds.Tables[0];
                }
                else
                {
                    gridShowDataForUpdate.DataSource = new DataTable();
                }
            }
        }
        private bool IsString(string input)
        {
            return input.All(char.IsLetter);
        }

        private void dropCourseSS_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Get the selected item from the ComboBox
            string selectedCourseCode = dropCourseSS.SelectedValue?.ToString();

            if (!string.IsNullOrEmpty(selectedCourseCode))
            {
                // Fetch records for the selected course code
                clsManageRecords cMR = new clsManageRecords();
                cMR.courseCode = selectedCourseCode;
                DataSet ds = cMR.fetchAllRecordsForCC();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gridShowDataForUpdate.DataSource = ds.Tables[0];
                    gridShowDataForUpdate.Refresh();
                }
                else
                {
                    gridShowDataForUpdate.DataSource = null;

                }
            }
        }
    }
}
