﻿using System;
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
            fetchRecordsForUpdate(); ;
            
        }
        public void fetchRecordsForUpdate()
        {
            clsUpdateRecord upr = new clsUpdateRecord();
            DataSet ds=upr.fetchAllRecordsForUpdate();
            if (ds.Tables[0].Rows.Count > 0)
            {
                gridShowDataForUpdate.DataSource = ds.Tables[0];
            }
        }

        private void gridShowDataForUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateStudentRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tCandCCDataSet2.tbl_Student_Info' table. You can move, or remove it, as needed.
            this.tbl_Student_InfoTableAdapter1.Fill(this.tCandCCDataSet2.tbl_Student_Info);
            // TODO: This line of code loads data into the 'tCandCCDataSet1.tbl_Student_Info' table. You can move, or remove it, as needed.
            this.tbl_Student_InfoTableAdapter.Fill(this.tCandCCDataSet1.tbl_Student_Info);

        }

        private void btnSearchRecordForUpdate_Click(object sender, EventArgs e)
        {
            string userInput = txtSearchRecordForUpdate.Text.Trim();
            clsUpdateRecord clsUR = new clsUpdateRecord();
            if (long.TryParse(userInput, out long result))
            {

                clsUR.Roll= result;
                clsUR.Enroll = result;
                DataSet ds=clsUR.fetchSpecificStudentRecord();
                if (ds.Tables.Count > 0)
                {
                    gridShowDataForUpdate.DataSource= ds.Tables[0];
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