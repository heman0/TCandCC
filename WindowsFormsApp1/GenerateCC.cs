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
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class GenerateCC : Form
    {
        public GenerateCC()
        {
            InitializeComponent();
            fetchStudentRecordsInGridView();
        }

        private void btnSearchWithDetailsCC_Click(object sender, EventArgs e)
        {
            if (txtCourseCC.Text == "" || txtNameCC.Text == "")
            {
               MessageBox.Show("Enter Name and Course","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
            else if (!IsString(txtCourseCC.Text.ToString()))
            {
                MessageBox.Show("Enter a Valid Course Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!IsString(txtNameCC.Text.ToString()))
            {
                MessageBox.Show("Enter a Valid Student Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            {
                clsManageRecords cMR = new clsManageRecords();
                cMR.classPassed = txtCourseCC.Text.Trim();
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
            // TODO: This line of code loads data into the 'studentTCandCCDataSet3.tbl_Student_Info' table. You can move, or remove it, as needed.
            this.tbl_Student_InfoTableAdapter.Fill(this.studentTCandCCDataSet3.tbl_Student_Info);

        }
    }
}
