using ExcelDataReader.Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.App_Code;
using static System.Collections.Specialized.BitVector32;

namespace WindowsFormsApp1
{
    public partial class UpdateStudentRecord : Form
    {
        long Enrollment;
        public UpdateStudentRecord()
        {
            InitializeComponent();
            
        }
        public void fillData(long EnrollmentID, long RollNo, string name, string fatherName, string motherName, string address, string dob, string admissionDate, string duesCleared, string dateOfLeave, string classPassed, string session, string attendance,string Remark)
        {
            Enrollment = Convert.ToInt64( EnrollmentID.ToString());
            lblEnrollmentValue.Text = Enrollment.ToString();
            lblRollValue.Text = RollNo.ToString();
            txtName.Text = name;
            txtFatherName.Text = fatherName;
            txtMotherName.Text = motherName;
            txtAddress.Text= address;
            dateDOB.Text = dob;
            dateDuesCleared.Text= duesCleared;
            dateAdmissionDate.Text = admissionDate;
            dateLeaving.Text = dateOfLeave;
            txtClassPassed.Text = classPassed;
            txtSession.Text= session;
            txtAttendance.Text = attendance.ToString();
            txtRemark.Text = Remark;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRoll_Click(object sender, EventArgs e)
        {

        }

        private void UpdateStudentRecord_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsManageRecords cls=new clsManageRecords();
            cls.Enroll = Enrollment;
            cls.name = txtName.Text;
            cls.fatherName = txtFatherName.Text;
            cls.motherName = txtMotherName.Text;
            cls.address = txtAddress.Text;
            cls.classPassed=txtClassPassed.Text;
            cls.session = txtSession.Text;
            cls.admissionDate=dateAdmissionDate.Text;
            cls.dateOfLeaving=dateLeaving.Text;
            cls.duesClearedUpTo=dateDuesCleared.Text;
            cls.dob=dateDOB.Text;
            cls.attendance= Convert.ToInt64( txtAttendance.Text);
            cls.remark=txtRemark.Text;
            int res=cls.updateStudentRecord();
            if (res!=null)
            {
                MessageBox.Show("Updated successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
