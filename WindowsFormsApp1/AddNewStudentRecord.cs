using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.App_Code;

namespace TCandCC
{
    public partial class AddNewStudentRecord : Form
    {
        public AddNewStudentRecord()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Assuming cmr is an instance of your class (let's call it ClassName for illustration)
            clsManageRecords cmr = new clsManageRecords();

            // Setting properties using the provided format
            cmr.Enroll = Convert.ToInt64(txtNewEnrollment.Text);
            cmr.Roll = Convert.ToInt64(txtNewRollNo.Text);
            cmr.name = txtNewName.Text;
            cmr.fatherName = txtNewFatherName.Text;
            cmr.motherName = txtNewMotherName.Text;
            cmr.address = txtNewAddress.Text;
            cmr.dob = dateNewDOB.Text;
            cmr.admissionDate = dateNewAdmissionDate.Text;
            cmr.duesClearedUpTo = dateNewDuesCleared.Text;
            cmr.dateOfLeaving = dateNewLeaving.Text;
            cmr.classPassed = txtNewClassPassed.Text;
            cmr.session = txtNewSession.Text;
            cmr.attendance = Convert.ToInt64(txtNewAttendance.Text);
            cmr.remark = txtNewRemark.Text;
            int res=cmr.addNewRecord();
            if (res > 0)
            {
                MessageBox.Show("Record added..","Information",MessageBoxButtons.OK);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblClassPassed_Click(object sender, EventArgs e)
        {

        }

        private void btnImageUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All files(*.*)|*.*";

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    string imageLocation = fd.FileName;

                    // Check the file size before assigning it to ImageLocation
                    FileInfo fileInfo = new FileInfo(imageLocation);
                    long fileSizeInBytes = fileInfo.Length;
                    long fileSizeInKB = fileSizeInBytes / 1024; // Convert to KB

                    if (fileSizeInKB > 200)
                    {
                        MessageBox.Show("The selected image exceeds the maximum allowed size (200 KB). Please choose a smaller image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        imgProfilePic.ImageLocation = imageLocation;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
