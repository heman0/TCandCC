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
            this.lblEnroll = new System.Windows.Forms.Label();
            this.lblEnrollmentValue = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblRollValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblMotherName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblAdmissionDate = new System.Windows.Forms.Label();
            this.lblDuesClearedUpto = new System.Windows.Forms.Label();
            this.lblDateOfLeaving = new System.Windows.Forms.Label();
            this.lblClassPassed = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.dateDOB = new System.Windows.Forms.DateTimePicker();
            this.dateAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.dateDuesCleared = new System.Windows.Forms.DateTimePicker();
            this.dateLeaving = new System.Windows.Forms.DateTimePicker();
            this.txtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtFatherName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMotherName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSession = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtClassPassed = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAttendance = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtRemark = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tableAdapterManager1 = new WindowsFormsApp1.studentTCandCCDataSet1TableAdapters.TableAdapterManager();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // lblEnroll
            // 
            this.lblEnroll.AutoSize = true;
            this.lblEnroll.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnroll.Location = new System.Drawing.Point(60, 45);
            this.lblEnroll.Name = "lblEnroll";
            this.lblEnroll.Size = new System.Drawing.Size(64, 15);
            this.lblEnroll.TabIndex = 0;
            this.lblEnroll.Text = "Enrollment";
            this.lblEnroll.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEnrollmentValue
            // 
            this.lblEnrollmentValue.AutoSize = true;
            this.lblEnrollmentValue.Location = new System.Drawing.Point(255, 45);
            this.lblEnrollmentValue.Name = "lblEnrollmentValue";
            this.lblEnrollmentValue.Size = new System.Drawing.Size(33, 13);
            this.lblEnrollmentValue.TabIndex = 1;
            this.lblEnrollmentValue.Text = "value";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.Location = new System.Drawing.Point(60, 88);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(50, 15);
            this.lblRoll.TabIndex = 2;
            this.lblRoll.Text = "Roll No.";
            this.lblRoll.Click += new System.EventHandler(this.lblRoll_Click);
            // 
            // lblRollValue
            // 
            this.lblRollValue.AutoSize = true;
            this.lblRollValue.Location = new System.Drawing.Point(255, 88);
            this.lblRollValue.Name = "lblRollValue";
            this.lblRollValue.Size = new System.Drawing.Size(39, 13);
            this.lblRollValue.TabIndex = 3;
            this.lblRollValue.Text = "value2";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(60, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AllowDrop = true;
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatherName.Location = new System.Drawing.Point(60, 179);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(71, 15);
            this.lblFatherName.TabIndex = 6;
            this.lblFatherName.Text = "FatherName";
            // 
            // lblMotherName
            // 
            this.lblMotherName.AutoSize = true;
            this.lblMotherName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotherName.Location = new System.Drawing.Point(60, 229);
            this.lblMotherName.Name = "lblMotherName";
            this.lblMotherName.Size = new System.Drawing.Size(77, 15);
            this.lblMotherName.TabIndex = 8;
            this.lblMotherName.Text = "MotherName";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(60, 282);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(53, 15);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.Location = new System.Drawing.Point(60, 342);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(33, 15);
            this.lblDoB.TabIndex = 12;
            this.lblDoB.Text = "DOB";
            // 
            // lblAdmissionDate
            // 
            this.lblAdmissionDate.AutoSize = true;
            this.lblAdmissionDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionDate.Location = new System.Drawing.Point(60, 398);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Size = new System.Drawing.Size(93, 15);
            this.lblAdmissionDate.TabIndex = 14;
            this.lblAdmissionDate.Text = "Admission Date";
            // 
            // lblDuesClearedUpto
            // 
            this.lblDuesClearedUpto.AutoSize = true;
            this.lblDuesClearedUpto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuesClearedUpto.Location = new System.Drawing.Point(60, 456);
            this.lblDuesClearedUpto.Name = "lblDuesClearedUpto";
            this.lblDuesClearedUpto.Size = new System.Drawing.Size(78, 15);
            this.lblDuesClearedUpto.TabIndex = 16;
            this.lblDuesClearedUpto.Text = "Dues Cleared";
            // 
            // lblDateOfLeaving
            // 
            this.lblDateOfLeaving.AutoSize = true;
            this.lblDateOfLeaving.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfLeaving.Location = new System.Drawing.Point(60, 513);
            this.lblDateOfLeaving.Name = "lblDateOfLeaving";
            this.lblDateOfLeaving.Size = new System.Drawing.Size(94, 15);
            this.lblDateOfLeaving.TabIndex = 18;
            this.lblDateOfLeaving.Text = "Date Of Leaving";
            // 
            // lblClassPassed
            // 
            this.lblClassPassed.AutoSize = true;
            this.lblClassPassed.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassPassed.Location = new System.Drawing.Point(542, 233);
            this.lblClassPassed.Name = "lblClassPassed";
            this.lblClassPassed.Size = new System.Drawing.Size(77, 15);
            this.lblClassPassed.TabIndex = 20;
            this.lblClassPassed.Text = "Class Passed";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(542, 54);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(49, 15);
            this.lblSession.TabIndex = 22;
            this.lblSession.Text = "Session";
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.Location = new System.Drawing.Point(542, 111);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(70, 15);
            this.lblAttendance.TabIndex = 24;
            this.lblAttendance.Text = "Attendance";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.Location = new System.Drawing.Point(542, 167);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(46, 15);
            this.lblRemark.TabIndex = 26;
            this.lblRemark.Text = "Remark";
            // 
            // dateDOB
            // 
            this.dateDOB.Location = new System.Drawing.Point(258, 335);
            this.dateDOB.Name = "dateDOB";
            this.dateDOB.Size = new System.Drawing.Size(140, 20);
            this.dateDOB.TabIndex = 32;
            // 
            // dateAdmissionDate
            // 
            this.dateAdmissionDate.Location = new System.Drawing.Point(258, 398);
            this.dateAdmissionDate.Name = "dateAdmissionDate";
            this.dateAdmissionDate.Size = new System.Drawing.Size(140, 20);
            this.dateAdmissionDate.TabIndex = 33;
            // 
            // dateDuesCleared
            // 
            this.dateDuesCleared.Location = new System.Drawing.Point(258, 449);
            this.dateDuesCleared.Name = "dateDuesCleared";
            this.dateDuesCleared.Size = new System.Drawing.Size(140, 20);
            this.dateDuesCleared.TabIndex = 34;
            // 
            // dateLeaving
            // 
            this.dateLeaving.Location = new System.Drawing.Point(258, 506);
            this.dateLeaving.Name = "dateLeaving";
            this.dateLeaving.Size = new System.Drawing.Size(140, 20);
            this.dateLeaving.TabIndex = 36;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(258, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 27);
            this.txtName.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtName.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateCommon.Border.Rounding = 5;
            this.txtName.TabIndex = 37;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(258, 172);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(140, 27);
            this.txtFatherName.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtFatherName.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtFatherName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFatherName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFatherName.StateCommon.Border.Rounding = 5;
            this.txtFatherName.TabIndex = 38;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(258, 223);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(140, 27);
            this.txtMotherName.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtMotherName.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtMotherName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMotherName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMotherName.StateCommon.Border.Rounding = 5;
            this.txtMotherName.TabIndex = 39;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(258, 274);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(140, 27);
            this.txtAddress.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtAddress.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtAddress.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddress.StateCommon.Border.Rounding = 5;
            this.txtAddress.TabIndex = 40;
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(740, 46);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(140, 27);
            this.txtSession.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtSession.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtSession.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSession.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSession.StateCommon.Border.Rounding = 5;
            this.txtSession.TabIndex = 42;
            // 
            // txtClassPassed
            // 
            this.txtClassPassed.Location = new System.Drawing.Point(740, 223);
            this.txtClassPassed.Name = "txtClassPassed";
            this.txtClassPassed.Size = new System.Drawing.Size(140, 27);
            this.txtClassPassed.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtClassPassed.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtClassPassed.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClassPassed.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClassPassed.StateCommon.Border.Rounding = 5;
            this.txtClassPassed.TabIndex = 43;
            // 
            // txtAttendance
            // 
            this.txtAttendance.Location = new System.Drawing.Point(740, 101);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.Size = new System.Drawing.Size(140, 27);
            this.txtAttendance.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtAttendance.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtAttendance.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAttendance.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAttendance.StateCommon.Border.Rounding = 5;
            this.txtAttendance.TabIndex = 44;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(740, 155);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(140, 27);
            this.txtRemark.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtRemark.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.txtRemark.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRemark.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRemark.StateCommon.Border.Rounding = 5;
            this.txtRemark.TabIndex = 45;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tbl_Student_InfoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.studentTCandCCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(545, 292);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUpdate.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUpdate.OverrideDefault.Back.ColorAngle = 45F;
            this.btnUpdate.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUpdate.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUpdate.OverrideDefault.Border.ColorAngle = 45F;
            this.btnUpdate.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.Size = new System.Drawing.Size(96, 29);
            this.btnUpdate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUpdate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUpdate.StateCommon.Back.ColorAngle = 45F;
            this.btnUpdate.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUpdate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUpdate.StateCommon.Border.ColorAngle = 45F;
            this.btnUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.StateCommon.Border.Rounding = 5;
            this.btnUpdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUpdate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUpdate.StatePressed.Back.ColorAngle = 45F;
            this.btnUpdate.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUpdate.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnUpdate.StatePressed.Border.ColorAngle = 45F;
            this.btnUpdate.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 576);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.txtClassPassed);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dateLeaving);
            this.Controls.Add(this.dateDuesCleared);
            this.Controls.Add(this.dateAdmissionDate);
            this.Controls.Add(this.dateDOB);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.lblClassPassed);
            this.Controls.Add(this.lblDateOfLeaving);
            this.Controls.Add(this.lblDuesClearedUpto);
            this.Controls.Add(this.lblAdmissionDate);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblMotherName);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRollValue);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.lblEnrollmentValue);
            this.Controls.Add(this.lblEnroll);
            this.Name = "UpdateStudentRecord";
            this.Text = "Update Records";
            this.Load += new System.EventHandler(this.UpdateStudentRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnroll;
        private System.Windows.Forms.Label lblEnrollmentValue;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblRollValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblMotherName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblAdmissionDate;
        private System.Windows.Forms.Label lblDuesClearedUpto;
        private System.Windows.Forms.Label lblDateOfLeaving;
        private System.Windows.Forms.Label lblClassPassed;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.DateTimePicker dateDOB;
        private System.Windows.Forms.DateTimePicker dateAdmissionDate;
        private System.Windows.Forms.DateTimePicker dateDuesCleared;
        private System.Windows.Forms.DateTimePicker dateLeaving;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFatherName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMotherName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSession;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClassPassed;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAttendance;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRemark;
        private studentTCandCCDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
    }
}