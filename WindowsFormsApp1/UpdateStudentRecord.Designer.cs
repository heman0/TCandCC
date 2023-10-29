namespace WindowsFormsApp1
{
    partial class UpdateStudentRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tCandCCDataSet = new WindowsFormsApp1.TCandCCDataSet();
            this.tCandCCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridShowDataForUpdate = new System.Windows.Forms.DataGridView();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCandCCDataSet1 = new WindowsFormsApp1.TCandCCDataSet1();
            this.tbl_Student_InfoTableAdapter = new WindowsFormsApp1.TCandCCDataSet1TableAdapters.tbl_Student_InfoTableAdapter();
            this.tCandCCDataSet2 = new WindowsFormsApp1.TCandCCDataSet2();
            this.tblStudentInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Student_InfoTableAdapter1 = new WindowsFormsApp1.TCandCCDataSet2TableAdapters.tbl_Student_InfoTableAdapter();
            this.Update = new System.Windows.Forms.DataGridViewLinkColumn();
            this.EnrollmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuesClearedUpto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfLeaving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassPassed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchRecordForUpdate = new System.Windows.Forms.TextBox();
            this.btnSearchRecordForUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowDataForUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tCandCCDataSet
            // 
            this.tCandCCDataSet.DataSetName = "TCandCCDataSet";
            this.tCandCCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCandCCDataSetBindingSource
            // 
            this.tCandCCDataSetBindingSource.DataSource = this.tCandCCDataSet;
            this.tCandCCDataSetBindingSource.Position = 0;
            // 
            // gridShowDataForUpdate
            // 
            this.gridShowDataForUpdate.AllowUserToAddRows = false;
            this.gridShowDataForUpdate.AllowUserToDeleteRows = false;
            this.gridShowDataForUpdate.AutoGenerateColumns = false;
            this.gridShowDataForUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridShowDataForUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowDataForUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.EnrollmentNo,
            this.RollNo,
            this.SRNo,
            this.StudentName,
            this.FatherName,
            this.MotherName,
            this.Address,
            this.DoB,
            this.AdmissionDate,
            this.DuesClearedUpto,
            this.DateOfLeaving,
            this.ClassPassed,
            this.Session,
            this.Attendance,
            this.Remark,
            this.StudentPic,
            this.TcCreated,
            this.CCCreated});
            this.gridShowDataForUpdate.DataSource = this.tblStudentInfoBindingSource1;
            this.gridShowDataForUpdate.Location = new System.Drawing.Point(21, 54);
            this.gridShowDataForUpdate.Name = "gridShowDataForUpdate";
            this.gridShowDataForUpdate.ReadOnly = true;
            this.gridShowDataForUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridShowDataForUpdate.Size = new System.Drawing.Size(774, 461);
            this.gridShowDataForUpdate.TabIndex = 0;
            this.gridShowDataForUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridShowDataForUpdate_CellContentClick);
            // 
            // tblStudentInfoBindingSource
            // 
            this.tblStudentInfoBindingSource.DataMember = "tbl_Student_Info";
            this.tblStudentInfoBindingSource.DataSource = this.tCandCCDataSet1;
            // 
            // tCandCCDataSet1
            // 
            this.tCandCCDataSet1.DataSetName = "TCandCCDataSet1";
            this.tCandCCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Student_InfoTableAdapter
            // 
            this.tbl_Student_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // tCandCCDataSet2
            // 
            this.tCandCCDataSet2.DataSetName = "TCandCCDataSet2";
            this.tCandCCDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentInfoBindingSource1
            // 
            this.tblStudentInfoBindingSource1.DataMember = "tbl_Student_Info";
            this.tblStudentInfoBindingSource1.DataSource = this.tCandCCDataSet2;
            // 
            // tbl_Student_InfoTableAdapter1
            // 
            this.tbl_Student_InfoTableAdapter1.ClearBeforeFill = true;
            // 
            // Update
            // 
            this.Update.FillWeight = 50F;
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForLinkValue = true;
            this.Update.Width = 50;
            // 
            // EnrollmentNo
            // 
            this.EnrollmentNo.DataPropertyName = "EnrollmentNo";
            this.EnrollmentNo.HeaderText = "EnrollmentNo";
            this.EnrollmentNo.Name = "EnrollmentNo";
            this.EnrollmentNo.ReadOnly = true;
            // 
            // RollNo
            // 
            this.RollNo.DataPropertyName = "RollNo";
            this.RollNo.HeaderText = "RollNo";
            this.RollNo.Name = "RollNo";
            this.RollNo.ReadOnly = true;
            // 
            // SRNo
            // 
            this.SRNo.DataPropertyName = "SRNo";
            this.SRNo.HeaderText = "SRNo";
            this.SRNo.Name = "SRNo";
            this.SRNo.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // FatherName
            // 
            this.FatherName.DataPropertyName = "FatherName";
            this.FatherName.HeaderText = "FatherName";
            this.FatherName.Name = "FatherName";
            this.FatherName.ReadOnly = true;
            // 
            // MotherName
            // 
            this.MotherName.DataPropertyName = "MotherName";
            this.MotherName.HeaderText = "MotherName";
            this.MotherName.Name = "MotherName";
            this.MotherName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // DoB
            // 
            this.DoB.DataPropertyName = "DoB";
            this.DoB.HeaderText = "DoB";
            this.DoB.Name = "DoB";
            this.DoB.ReadOnly = true;
            // 
            // AdmissionDate
            // 
            this.AdmissionDate.DataPropertyName = "AdmissionDate";
            this.AdmissionDate.HeaderText = "AdmissionDate";
            this.AdmissionDate.Name = "AdmissionDate";
            this.AdmissionDate.ReadOnly = true;
            // 
            // DuesClearedUpto
            // 
            this.DuesClearedUpto.DataPropertyName = "DuesClearedUpto";
            this.DuesClearedUpto.HeaderText = "DuesClearedUpto";
            this.DuesClearedUpto.Name = "DuesClearedUpto";
            this.DuesClearedUpto.ReadOnly = true;
            // 
            // DateOfLeaving
            // 
            this.DateOfLeaving.DataPropertyName = "DateOfLeaving";
            this.DateOfLeaving.HeaderText = "DateOfLeaving";
            this.DateOfLeaving.Name = "DateOfLeaving";
            this.DateOfLeaving.ReadOnly = true;
            // 
            // ClassPassed
            // 
            this.ClassPassed.DataPropertyName = "ClassPassed";
            this.ClassPassed.HeaderText = "ClassPassed";
            this.ClassPassed.Name = "ClassPassed";
            this.ClassPassed.ReadOnly = true;
            // 
            // Session
            // 
            this.Session.DataPropertyName = "Session";
            this.Session.HeaderText = "Session";
            this.Session.Name = "Session";
            this.Session.ReadOnly = true;
            // 
            // Attendance
            // 
            this.Attendance.DataPropertyName = "Attendance";
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // StudentPic
            // 
            this.StudentPic.DataPropertyName = "StudentPic";
            this.StudentPic.HeaderText = "StudentPic";
            this.StudentPic.Name = "StudentPic";
            this.StudentPic.ReadOnly = true;
            // 
            // TcCreated
            // 
            this.TcCreated.DataPropertyName = "TcCreated";
            this.TcCreated.HeaderText = "TcCreated";
            this.TcCreated.Name = "TcCreated";
            this.TcCreated.ReadOnly = true;
            // 
            // CCCreated
            // 
            this.CCCreated.DataPropertyName = "CCCreated";
            this.CCCreated.HeaderText = "CCCreated";
            this.CCCreated.Name = "CCCreated";
            this.CCCreated.ReadOnly = true;
            // 
            // txtSearchRecordForUpdate
            // 
            this.txtSearchRecordForUpdate.Location = new System.Drawing.Point(21, 28);
            this.txtSearchRecordForUpdate.Name = "txtSearchRecordForUpdate";
            this.txtSearchRecordForUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtSearchRecordForUpdate.TabIndex = 1;
            // 
            // btnSearchRecordForUpdate
            // 
            this.btnSearchRecordForUpdate.Location = new System.Drawing.Point(127, 26);
            this.btnSearchRecordForUpdate.Name = "btnSearchRecordForUpdate";
            this.btnSearchRecordForUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRecordForUpdate.TabIndex = 2;
            this.btnSearchRecordForUpdate.Text = "Search";
            this.btnSearchRecordForUpdate.UseVisualStyleBackColor = true;
            this.btnSearchRecordForUpdate.Click += new System.EventHandler(this.btnSearchRecordForUpdate_Click);
            // 
            // UpdateStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 538);
            this.Controls.Add(this.btnSearchRecordForUpdate);
            this.Controls.Add(this.txtSearchRecordForUpdate);
            this.Controls.Add(this.gridShowDataForUpdate);
            this.Name = "UpdateStudentRecord";
            this.Text = "UpdateStudentRecord";
            this.Load += new System.EventHandler(this.UpdateStudentRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowDataForUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tCandCCDataSetBindingSource;
        private TCandCCDataSet tCandCCDataSet;
        private System.Windows.Forms.DataGridView gridShowDataForUpdate;
        private TCandCCDataSet1 tCandCCDataSet1;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource;
        private TCandCCDataSet1TableAdapters.tbl_Student_InfoTableAdapter tbl_Student_InfoTableAdapter;
        private TCandCCDataSet2 tCandCCDataSet2;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource1;
        private TCandCCDataSet2TableAdapters.tbl_Student_InfoTableAdapter tbl_Student_InfoTableAdapter1;
        private System.Windows.Forms.DataGridViewLinkColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuesClearedUpto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfLeaving;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassPassed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCreated;
        private System.Windows.Forms.TextBox txtSearchRecordForUpdate;
        private System.Windows.Forms.Button btnSearchRecordForUpdate;
    }
}