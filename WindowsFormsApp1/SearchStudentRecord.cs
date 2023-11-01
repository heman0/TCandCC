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
            this.Resize += UpdateStudentRecord_Resize;
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
            // Check if the clicked cell is in the "Update" button column and not the header
            if (e.RowIndex >= 0 && e.ColumnIndex == gridShowDataForUpdate.Columns["Update"].Index)
            {
                DataGridViewRow selectedRow = gridShowDataForUpdate.Rows[e.RowIndex];

                // Assuming your DataGridView has columns with names "StudentID", "Name", "Grade", etc.
                long EnrollmentID =Convert.ToInt64( selectedRow.Cells["EnrollmentNo"].Value?.ToString() ?? string.Empty);
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
                string studentPicture = selectedRow.Cells["StudentPicture"].Value?.ToString() ?? string.Empty;
                string Remark = selectedRow.Cells["Remark"].Value?.ToString() ?? string.Empty;
                string tcCreated = selectedRow.Cells["TCCreated"].Value?.ToString() ?? string.Empty;
                string ccCreated = selectedRow.Cells["CCCreated"].Value?.ToString() ?? string.Empty;


                // Do something with the data, for example, open a form for updating the selected record
                UpdateStudentRecord updateForm = new UpdateStudentRecord();
                updateForm.fillData(EnrollmentID, RollNo, name, fatherName, motherName, address, dob, admissionDate, duesCleared, dateOfLeaving, classPassed, session, attendance,Remark, studentPicture, tcCreated, ccCreated);
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
           
        }
        private void UpdateStudentRecord_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                // Call the resize function when the form is maximized
                resize();
            }
        }


        private void btnSearchRecordForUpdate_Click(object sender, EventArgs e)
        {
            string userInput = txtSearchRecordForUpdate.Text.Trim();
            clsManageRecords clsUR = new clsManageRecords();
            if (userInput == "")
            {
                DataSet ds = clsUR.fetchAllRecordsForUpdate();
                if (ds.Tables.Count > 0)
                {
                    gridShowDataForUpdate.DataSource = ds.Tables[0];
                }
            }
            else if (long.TryParse(userInput, out long result))
            {

                clsUR.Roll = result;
                clsUR.Enroll = result;
                DataSet ds = clsUR.fetchSpecificStudentRecord();
                {     
                    gridShowDataForUpdate.DataSource = ds.Tables[0];
                }
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
    }
}
