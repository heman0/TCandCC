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
using static System.Collections.Specialized.BitVector32;

namespace WindowsFormsApp1
{
    public partial class UpdateStudentRecord : Form
    {
        public UpdateStudentRecord()
        {
            InitializeComponent();
        }
        public void fillData(long EnrollmentID,long RollNo,string name, string fatherName, string motherName, string address, string dob, string admissionDate, string duesCleared, string dateOfLeaving, string classPassed, string session,long attendance, string studentPicture, string tcCreated, string ccCreated)
        {
           lblEnroll.Text=EnrollmentID.ToString();
            lblRollValue.Text = RollNo.ToString();
            txtName.Text = name;
            
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
    }
}
