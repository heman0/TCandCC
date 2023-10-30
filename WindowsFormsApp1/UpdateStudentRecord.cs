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
    public partial class UpdateStudentRecord : Form
    {
        public UpdateStudentRecord()
        {
            InitializeComponent();
            fetchRecordsForUpdate();
            // Add Resize event handler
            this.Resize += UpdateStudentRecord_Resize;
        }

        public void fetchRecordsForUpdate()
        {
            clsUpdateRecord upr = new clsUpdateRecord();
            DataSet ds = upr.fetchAllRecordsForUpdate();
            if (ds.Tables[0].Rows.Count > 0)
            {
                gridShowDataForUpdate.DataSource = ds.Tables[0];
            }
        }

        private void gridShowDataForUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            

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
            clsUpdateRecord clsUR = new clsUpdateRecord();
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
