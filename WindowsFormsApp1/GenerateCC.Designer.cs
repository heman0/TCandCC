namespace WindowsFormsApp1
{
    partial class GenerateCC
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
            this.btnSearchWithDetailsCC = new System.Windows.Forms.Button();
            this.txtCourseCC = new System.Windows.Forms.TextBox();
            this.lblCourseCC = new System.Windows.Forms.Label();
            this.txtNameCC = new System.Windows.Forms.TextBox();
            this.lblNameCC = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new WindowsFormsApp1.studentTCandCCDataSet1TableAdapters.TableAdapterManager();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.lblRoll = new System.Windows.Forms.Label();
            this.gridShowStudentRecordForCC = new System.Windows.Forms.DataGridView();
            this.groupSearchByName = new System.Windows.Forms.GroupBox();
            this.searchWithRoll = new System.Windows.Forms.GroupBox();
            this.btnSearchWithRollCC = new System.Windows.Forms.Button();
            this.tCandCCDataSet2 = new WindowsFormsApp1.TCandCCDataSet2();
            this.tCandCCDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTCandCCDataSet3 = new WindowsFormsApp1.studentTCandCCDataSet3();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Student_InfoTableAdapter = new WindowsFormsApp1.studentTCandCCDataSet3TableAdapters.tbl_Student_InfoTableAdapter();
            this.enrollmentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.sRNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duesClearedUpToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfLeavingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classPassedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowStudentRecordForCC)).BeginInit();
            this.groupSearchByName.SuspendLayout();
            this.searchWithRoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTCandCCDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchWithDetailsCC
            // 
            this.btnSearchWithDetailsCC.Location = new System.Drawing.Point(374, 37);
            this.btnSearchWithDetailsCC.Name = "btnSearchWithDetailsCC";
            this.btnSearchWithDetailsCC.Size = new System.Drawing.Size(100, 23);
            this.btnSearchWithDetailsCC.TabIndex = 17;
            this.btnSearchWithDetailsCC.Text = "Search";
            this.btnSearchWithDetailsCC.UseVisualStyleBackColor = true;
            this.btnSearchWithDetailsCC.Click += new System.EventHandler(this.btnSearchWithDetailsCC_Click);
            // 
            // txtCourseCC
            // 
            this.txtCourseCC.Location = new System.Drawing.Point(83, 38);
            this.txtCourseCC.Name = "txtCourseCC";
            this.txtCourseCC.Size = new System.Drawing.Size(100, 20);
            this.txtCourseCC.TabIndex = 16;
            // 
            // lblCourseCC
            // 
            this.lblCourseCC.AutoSize = true;
            this.lblCourseCC.Location = new System.Drawing.Point(37, 41);
            this.lblCourseCC.Name = "lblCourseCC";
            this.lblCourseCC.Size = new System.Drawing.Size(40, 13);
            this.lblCourseCC.TabIndex = 15;
            this.lblCourseCC.Text = "Course";
            // 
            // txtNameCC
            // 
            this.txtNameCC.Location = new System.Drawing.Point(268, 39);
            this.txtNameCC.Name = "txtNameCC";
            this.txtNameCC.Size = new System.Drawing.Size(100, 20);
            this.txtNameCC.TabIndex = 10;
            // 
            // lblNameCC
            // 
            this.lblNameCC.AutoSize = true;
            this.lblNameCC.Location = new System.Drawing.Point(227, 41);
            this.lblNameCC.Name = "lblNameCC";
            this.lblNameCC.Size = new System.Drawing.Size(35, 13);
            this.lblNameCC.TabIndex = 9;
            this.lblNameCC.Text = "Name";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tbl_Student_InfoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.studentTCandCCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(72, 36);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(100, 20);
            this.txtRoll.TabIndex = 20;
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Location = new System.Drawing.Point(11, 41);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(45, 13);
            this.lblRoll.TabIndex = 19;
            this.lblRoll.Text = "Roll No.";
            // 
            // gridShowStudentRecordForCC
            // 
            this.gridShowStudentRecordForCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridShowStudentRecordForCC.AutoGenerateColumns = false;
            this.gridShowStudentRecordForCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowStudentRecordForCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enrollmentNoDataGridViewTextBoxColumn,
            this.rollNoDataGridViewTextBoxColumn,
            this.sRNoDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.motherNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.doBDataGridViewTextBoxColumn,
            this.admissionDateDataGridViewTextBoxColumn,
            this.duesClearedUpToDataGridViewTextBoxColumn,
            this.dateOfLeavingDataGridViewTextBoxColumn,
            this.classPassedDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn,
            this.attendanceDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.tCCreatedDataGridViewTextBoxColumn,
            this.cCCreatedDataGridViewTextBoxColumn});
            this.gridShowStudentRecordForCC.DataSource = this.tblStudentInfoBindingSource;
            this.gridShowStudentRecordForCC.Location = new System.Drawing.Point(13, 118);
            this.gridShowStudentRecordForCC.Name = "gridShowStudentRecordForCC";
            this.gridShowStudentRecordForCC.Size = new System.Drawing.Size(1002, 426);
            this.gridShowStudentRecordForCC.TabIndex = 21;
            this.gridShowStudentRecordForCC.VirtualMode = true;
            // 
            // groupSearchByName
            // 
            this.groupSearchByName.Controls.Add(this.btnSearchWithDetailsCC);
            this.groupSearchByName.Controls.Add(this.txtNameCC);
            this.groupSearchByName.Controls.Add(this.lblNameCC);
            this.groupSearchByName.Controls.Add(this.lblCourseCC);
            this.groupSearchByName.Controls.Add(this.txtCourseCC);
            this.groupSearchByName.Location = new System.Drawing.Point(47, 12);
            this.groupSearchByName.Name = "groupSearchByName";
            this.groupSearchByName.Size = new System.Drawing.Size(495, 100);
            this.groupSearchByName.TabIndex = 22;
            this.groupSearchByName.TabStop = false;
            this.groupSearchByName.Text = "Search With Details";
            // 
            // searchWithRoll
            // 
            this.searchWithRoll.Controls.Add(this.btnSearchWithRollCC);
            this.searchWithRoll.Controls.Add(this.lblRoll);
            this.searchWithRoll.Controls.Add(this.txtRoll);
            this.searchWithRoll.Location = new System.Drawing.Point(559, 12);
            this.searchWithRoll.Name = "searchWithRoll";
            this.searchWithRoll.Size = new System.Drawing.Size(302, 100);
            this.searchWithRoll.TabIndex = 23;
            this.searchWithRoll.TabStop = false;
            this.searchWithRoll.Text = "Search With Roll No.";
            // 
            // btnSearchWithRollCC
            // 
            this.btnSearchWithRollCC.Location = new System.Drawing.Point(178, 34);
            this.btnSearchWithRollCC.Name = "btnSearchWithRollCC";
            this.btnSearchWithRollCC.Size = new System.Drawing.Size(100, 23);
            this.btnSearchWithRollCC.TabIndex = 18;
            this.btnSearchWithRollCC.Text = "Search";
            this.btnSearchWithRollCC.UseVisualStyleBackColor = true;
            this.btnSearchWithRollCC.Click += new System.EventHandler(this.btnSearchWithRollCC_Click);
            // 
            // tCandCCDataSet2
            // 
            this.tCandCCDataSet2.DataSetName = "TCandCCDataSet2";
            this.tCandCCDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCandCCDataSet2BindingSource
            // 
            this.tCandCCDataSet2BindingSource.DataSource = this.tCandCCDataSet2;
            this.tCandCCDataSet2BindingSource.Position = 0;
            // 
            // studentTCandCCDataSet3
            // 
            this.studentTCandCCDataSet3.DataSetName = "studentTCandCCDataSet3";
            this.studentTCandCCDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentInfoBindingSource
            // 
            this.tblStudentInfoBindingSource.DataMember = "tbl_Student_Info";
            this.tblStudentInfoBindingSource.DataSource = this.studentTCandCCDataSet3;
            // 
            // tbl_Student_InfoTableAdapter
            // 
            this.tbl_Student_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // enrollmentNoDataGridViewTextBoxColumn
            // 
            this.enrollmentNoDataGridViewTextBoxColumn.DataPropertyName = "EnrollmentNo";
            this.enrollmentNoDataGridViewTextBoxColumn.HeaderText = "EnrollmentNo";
            this.enrollmentNoDataGridViewTextBoxColumn.Name = "enrollmentNoDataGridViewTextBoxColumn";
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "RollNo";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "RollNo";
            this.rollNoDataGridViewTextBoxColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.rollNoDataGridViewTextBoxColumn.LinkColor = System.Drawing.Color.Black;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rollNoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rollNoDataGridViewTextBoxColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // sRNoDataGridViewTextBoxColumn
            // 
            this.sRNoDataGridViewTextBoxColumn.DataPropertyName = "SRNo";
            this.sRNoDataGridViewTextBoxColumn.HeaderText = "SRNo";
            this.sRNoDataGridViewTextBoxColumn.Name = "sRNoDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            // 
            // motherNameDataGridViewTextBoxColumn
            // 
            this.motherNameDataGridViewTextBoxColumn.DataPropertyName = "MotherName";
            this.motherNameDataGridViewTextBoxColumn.HeaderText = "MotherName";
            this.motherNameDataGridViewTextBoxColumn.Name = "motherNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // doBDataGridViewTextBoxColumn
            // 
            this.doBDataGridViewTextBoxColumn.DataPropertyName = "DoB";
            this.doBDataGridViewTextBoxColumn.HeaderText = "DoB";
            this.doBDataGridViewTextBoxColumn.Name = "doBDataGridViewTextBoxColumn";
            // 
            // admissionDateDataGridViewTextBoxColumn
            // 
            this.admissionDateDataGridViewTextBoxColumn.DataPropertyName = "AdmissionDate";
            this.admissionDateDataGridViewTextBoxColumn.HeaderText = "AdmissionDate";
            this.admissionDateDataGridViewTextBoxColumn.Name = "admissionDateDataGridViewTextBoxColumn";
            // 
            // duesClearedUpToDataGridViewTextBoxColumn
            // 
            this.duesClearedUpToDataGridViewTextBoxColumn.DataPropertyName = "DuesClearedUpTo";
            this.duesClearedUpToDataGridViewTextBoxColumn.HeaderText = "DuesClearedUpTo";
            this.duesClearedUpToDataGridViewTextBoxColumn.Name = "duesClearedUpToDataGridViewTextBoxColumn";
            // 
            // dateOfLeavingDataGridViewTextBoxColumn
            // 
            this.dateOfLeavingDataGridViewTextBoxColumn.DataPropertyName = "DateOfLeaving";
            this.dateOfLeavingDataGridViewTextBoxColumn.HeaderText = "DateOfLeaving";
            this.dateOfLeavingDataGridViewTextBoxColumn.Name = "dateOfLeavingDataGridViewTextBoxColumn";
            // 
            // classPassedDataGridViewTextBoxColumn
            // 
            this.classPassedDataGridViewTextBoxColumn.DataPropertyName = "ClassPassed";
            this.classPassedDataGridViewTextBoxColumn.HeaderText = "ClassPassed";
            this.classPassedDataGridViewTextBoxColumn.Name = "classPassedDataGridViewTextBoxColumn";
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "Session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "Session";
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.HeaderText = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // tCCreatedDataGridViewTextBoxColumn
            // 
            this.tCCreatedDataGridViewTextBoxColumn.DataPropertyName = "TCCreated";
            this.tCCreatedDataGridViewTextBoxColumn.HeaderText = "TCCreated";
            this.tCCreatedDataGridViewTextBoxColumn.Name = "tCCreatedDataGridViewTextBoxColumn";
            // 
            // cCCreatedDataGridViewTextBoxColumn
            // 
            this.cCCreatedDataGridViewTextBoxColumn.DataPropertyName = "CCCreated";
            this.cCCreatedDataGridViewTextBoxColumn.HeaderText = "CCCreated";
            this.cCCreatedDataGridViewTextBoxColumn.Name = "cCCreatedDataGridViewTextBoxColumn";
            // 
            // GenerateCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 557);
            this.Controls.Add(this.searchWithRoll);
            this.Controls.Add(this.groupSearchByName);
            this.Controls.Add(this.gridShowStudentRecordForCC);
            this.Name = "GenerateCC";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateCC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GenerateCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridShowStudentRecordForCC)).EndInit();
            this.groupSearchByName.ResumeLayout(false);
            this.groupSearchByName.PerformLayout();
            this.searchWithRoll.ResumeLayout(false);
            this.searchWithRoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTCandCCDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchWithDetailsCC;
        private System.Windows.Forms.TextBox txtCourseCC;
        private System.Windows.Forms.Label lblCourseCC;
        private System.Windows.Forms.TextBox txtNameCC;
        private System.Windows.Forms.Label lblNameCC;
        private studentTCandCCDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.DataGridView gridShowStudentRecordForCC;
        private System.Windows.Forms.GroupBox groupSearchByName;
        private System.Windows.Forms.GroupBox searchWithRoll;
        private System.Windows.Forms.Button btnSearchWithRollCC;
        private System.Windows.Forms.BindingSource tCandCCDataSet2BindingSource;
        private TCandCCDataSet2 tCandCCDataSet2;
        private studentTCandCCDataSet3 studentTCandCCDataSet3;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource;
        private studentTCandCCDataSet3TableAdapters.tbl_Student_InfoTableAdapter tbl_Student_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duesClearedUpToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfLeavingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classPassedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCreatedDataGridViewTextBoxColumn;
    }
}