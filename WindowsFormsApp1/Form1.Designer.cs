namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sideBarContainter = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerateTC = new System.Windows.Forms.Button();
            this.generateTC = new System.Windows.Forms.Button();
            this.importRecords = new System.Windows.Forms.Button();
            this.exportRecords = new System.Windows.Forms.Button();
            this.updateRecord = new System.Windows.Forms.Button();
            this.gridShowData = new System.Windows.Forms.DataGridView();
            this.enrollmentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.studentPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTCandCCDataSet5 = new WindowsFormsApp1.studentTCandCCDataSet5();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbl_Student_InfoTableAdapter = new WindowsFormsApp1.studentTCandCCDataSet5TableAdapters.tbl_Student_InfoTableAdapter();
            this.sideBarContainter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTCandCCDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 30;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sideBarContainter
            // 
            this.sideBarContainter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.sideBarContainter.Controls.Add(this.panel1);
            this.sideBarContainter.Controls.Add(this.panel2);
            this.sideBarContainter.Controls.Add(this.generateTC);
            this.sideBarContainter.Controls.Add(this.importRecords);
            this.sideBarContainter.Controls.Add(this.exportRecords);
            this.sideBarContainter.Controls.Add(this.updateRecord);
            this.sideBarContainter.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarContainter.Location = new System.Drawing.Point(0, 0);
            this.sideBarContainter.MaximumSize = new System.Drawing.Size(182, 850);
            this.sideBarContainter.MinimumSize = new System.Drawing.Size(59, 850);
            this.sideBarContainter.Name = "sideBarContainter";
            this.sideBarContainter.Size = new System.Drawing.Size(182, 850);
            this.sideBarContainter.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 70);
            this.panel1.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(76, 28);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(66, 25);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMenu.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(9, 28);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(41, 22);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGenerateTC);
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 69);
            this.panel2.TabIndex = 4;
            // 
            // btnGenerateTC
            // 
            this.btnGenerateTC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnGenerateTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateTC.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTC.ForeColor = System.Drawing.Color.White;
            this.btnGenerateTC.Location = new System.Drawing.Point(3, 3);
            this.btnGenerateTC.Name = "btnGenerateTC";
            this.btnGenerateTC.Size = new System.Drawing.Size(170, 63);
            this.btnGenerateTC.TabIndex = 0;
            this.btnGenerateTC.Text = "Generate CC";
            this.btnGenerateTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerateTC.UseVisualStyleBackColor = true;
            this.btnGenerateTC.Click += new System.EventHandler(this.btnGenerateTC_Click);
            // 
            // generateTC
            // 
            this.generateTC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.generateTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateTC.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateTC.ForeColor = System.Drawing.Color.White;
            this.generateTC.Location = new System.Drawing.Point(3, 154);
            this.generateTC.Name = "generateTC";
            this.generateTC.Size = new System.Drawing.Size(173, 63);
            this.generateTC.TabIndex = 1;
            this.generateTC.Text = "Generate TC";
            this.generateTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generateTC.UseVisualStyleBackColor = true;
            this.generateTC.Click += new System.EventHandler(this.generateTC_Click);
            // 
            // importRecords
            // 
            this.importRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.importRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importRecords.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importRecords.ForeColor = System.Drawing.Color.White;
            this.importRecords.Image = ((System.Drawing.Image)(resources.GetObject("importRecords.Image")));
            this.importRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importRecords.Location = new System.Drawing.Point(3, 223);
            this.importRecords.Name = "importRecords";
            this.importRecords.Size = new System.Drawing.Size(173, 63);
            this.importRecords.TabIndex = 5;
            this.importRecords.Text = "Import";
            this.importRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importRecords.UseVisualStyleBackColor = true;
            this.importRecords.Click += new System.EventHandler(this.importRecords_Click);
            // 
            // exportRecords
            // 
            this.exportRecords.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.exportRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.exportRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportRecords.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportRecords.ForeColor = System.Drawing.Color.White;
            this.exportRecords.Image = ((System.Drawing.Image)(resources.GetObject("exportRecords.Image")));
            this.exportRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportRecords.Location = new System.Drawing.Point(3, 292);
            this.exportRecords.Name = "exportRecords";
            this.exportRecords.Size = new System.Drawing.Size(173, 63);
            this.exportRecords.TabIndex = 6;
            this.exportRecords.Text = "Export";
            this.exportRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportRecords.UseVisualStyleBackColor = true;
            // 
            // updateRecord
            // 
            this.updateRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.updateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateRecord.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRecord.ForeColor = System.Drawing.Color.White;
            this.updateRecord.Image = ((System.Drawing.Image)(resources.GetObject("updateRecord.Image")));
            this.updateRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateRecord.Location = new System.Drawing.Point(3, 361);
            this.updateRecord.Name = "updateRecord";
            this.updateRecord.Size = new System.Drawing.Size(173, 63);
            this.updateRecord.TabIndex = 7;
            this.updateRecord.Text = "Update Record";
            this.updateRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateRecord.UseVisualStyleBackColor = true;
            this.updateRecord.Click += new System.EventHandler(this.updateRecord_Click);
            // 
            // gridShowData
            // 
            this.gridShowData.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridShowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.studentPictureDataGridViewTextBoxColumn,
            this.tCCreatedDataGridViewTextBoxColumn,
            this.cCCreatedDataGridViewTextBoxColumn});
            this.gridShowData.DataSource = this.tblStudentInfoBindingSource;
            this.gridShowData.EnableHeadersVisualStyles = false;
            this.gridShowData.Location = new System.Drawing.Point(0, 0);
            this.gridShowData.Name = "gridShowData";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.gridShowData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridShowData.Size = new System.Drawing.Size(1350, 700);
            this.gridShowData.TabIndex = 1;
            this.gridShowData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridShowData_CellContentClick);
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
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
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
            this.duesClearedUpToDataGridViewTextBoxColumn.Width = 120;
            // 
            // dateOfLeavingDataGridViewTextBoxColumn
            // 
            this.dateOfLeavingDataGridViewTextBoxColumn.DataPropertyName = "DateOfLeaving";
            this.dateOfLeavingDataGridViewTextBoxColumn.HeaderText = "DateOfLeaving";
            this.dateOfLeavingDataGridViewTextBoxColumn.Name = "dateOfLeavingDataGridViewTextBoxColumn";
            this.dateOfLeavingDataGridViewTextBoxColumn.Width = 110;
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
            // studentPictureDataGridViewTextBoxColumn
            // 
            this.studentPictureDataGridViewTextBoxColumn.DataPropertyName = "StudentPicture";
            this.studentPictureDataGridViewTextBoxColumn.HeaderText = "StudentPicture";
            this.studentPictureDataGridViewTextBoxColumn.Name = "studentPictureDataGridViewTextBoxColumn";
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
            // tblStudentInfoBindingSource
            // 
            this.tblStudentInfoBindingSource.DataMember = "tbl_Student_Info";
            this.tblStudentInfoBindingSource.DataSource = this.studentTCandCCDataSet5;
            // 
            // studentTCandCCDataSet5
            // 
            this.studentTCandCCDataSet5.DataSetName = "studentTCandCCDataSet5";
            this.studentTCandCCDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 850);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridShowData);
            this.panel3.Location = new System.Drawing.Point(188, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 850);
            this.panel3.TabIndex = 5;
            // 
            // tbl_Student_InfoTableAdapter
            // 
            this.tbl_Student_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1153, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sideBarContainter);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCandCC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideBarContainter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridShowData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTCandCCDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel sideBarContainter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerateTC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button generateTC;
        private System.Windows.Forms.Button importRecords;
        private System.Windows.Forms.Button exportRecords;
        private System.Windows.Forms.Button updateRecord;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.DataGridView gridShowData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private studentTCandCCDataSet5 studentTCandCCDataSet5;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource;
        private studentTCandCCDataSet5TableAdapters.tbl_Student_InfoTableAdapter tbl_Student_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCreatedDataGridViewTextBoxColumn;
    }
}

