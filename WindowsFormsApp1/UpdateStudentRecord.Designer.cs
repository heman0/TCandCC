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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.lblMotherName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblAdmissionDate = new System.Windows.Forms.Label();
            this.lblDuesClearedUpto = new System.Windows.Forms.Label();
            this.lblDateOfLeaving = new System.Windows.Forms.Label();
            this.txtClassPassed = new System.Windows.Forms.TextBox();
            this.lblClassPassed = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.lblSession = new System.Windows.Forms.Label();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtTCCreated = new System.Windows.Forms.TextBox();
            this.lblTCCreated = new System.Windows.Forms.Label();
            this.txtCCCreated = new System.Windows.Forms.TextBox();
            this.lblCCCreated = new System.Windows.Forms.Label();
            this.dateDOB = new System.Windows.Forms.DateTimePicker();
            this.dateAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.dateDuesCleared = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dateLeaving = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblEnroll
            // 
            this.lblEnroll.AutoSize = true;
            this.lblEnroll.Location = new System.Drawing.Point(60, 45);
            this.lblEnroll.Name = "lblEnroll";
            this.lblEnroll.Size = new System.Drawing.Size(56, 13);
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
            this.lblRoll.Location = new System.Drawing.Point(60, 88);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(45, 13);
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
            this.lblName.Location = new System.Drawing.Point(60, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(258, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(258, 178);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(140, 20);
            this.txtFatherName.TabIndex = 7;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AllowDrop = true;
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(60, 181);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(65, 13);
            this.lblFatherName.TabIndex = 6;
            this.lblFatherName.Text = "FatherName";
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(258, 226);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(140, 20);
            this.txtMotherName.TabIndex = 9;
            // 
            // lblMotherName
            // 
            this.lblMotherName.AutoSize = true;
            this.lblMotherName.Location = new System.Drawing.Point(60, 229);
            this.lblMotherName.Name = "lblMotherName";
            this.lblMotherName.Size = new System.Drawing.Size(68, 13);
            this.lblMotherName.TabIndex = 8;
            this.lblMotherName.Text = "MotherName";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(258, 281);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(140, 20);
            this.txtAddress.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(60, 284);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(60, 342);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(30, 13);
            this.lblDoB.TabIndex = 12;
            this.lblDoB.Text = "DOB";
            // 
            // lblAdmissionDate
            // 
            this.lblAdmissionDate.AutoSize = true;
            this.lblAdmissionDate.Location = new System.Drawing.Point(60, 398);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Size = new System.Drawing.Size(80, 13);
            this.lblAdmissionDate.TabIndex = 14;
            this.lblAdmissionDate.Text = "Admission Date";
            // 
            // lblDuesClearedUpto
            // 
            this.lblDuesClearedUpto.AutoSize = true;
            this.lblDuesClearedUpto.Location = new System.Drawing.Point(60, 456);
            this.lblDuesClearedUpto.Name = "lblDuesClearedUpto";
            this.lblDuesClearedUpto.Size = new System.Drawing.Size(71, 13);
            this.lblDuesClearedUpto.TabIndex = 16;
            this.lblDuesClearedUpto.Text = "Dues Cleared";
            // 
            // lblDateOfLeaving
            // 
            this.lblDateOfLeaving.AutoSize = true;
            this.lblDateOfLeaving.Location = new System.Drawing.Point(60, 513);
            this.lblDateOfLeaving.Name = "lblDateOfLeaving";
            this.lblDateOfLeaving.Size = new System.Drawing.Size(85, 13);
            this.lblDateOfLeaving.TabIndex = 18;
            this.lblDateOfLeaving.Text = "Date Of Leaving";
            // 
            // txtClassPassed
            // 
            this.txtClassPassed.Location = new System.Drawing.Point(740, 343);
            this.txtClassPassed.Name = "txtClassPassed";
            this.txtClassPassed.Size = new System.Drawing.Size(140, 20);
            this.txtClassPassed.TabIndex = 21;
            // 
            // lblClassPassed
            // 
            this.lblClassPassed.AutoSize = true;
            this.lblClassPassed.Location = new System.Drawing.Point(542, 346);
            this.lblClassPassed.Name = "lblClassPassed";
            this.lblClassPassed.Size = new System.Drawing.Size(70, 13);
            this.lblClassPassed.TabIndex = 20;
            this.lblClassPassed.Text = "Class Passed";
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(740, 51);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(140, 20);
            this.txtSession.TabIndex = 23;
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(542, 54);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(44, 13);
            this.lblSession.TabIndex = 22;
            this.lblSession.Text = "Session";
            // 
            // txtAttendance
            // 
            this.txtAttendance.Location = new System.Drawing.Point(740, 108);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.Size = new System.Drawing.Size(140, 20);
            this.txtAttendance.TabIndex = 25;
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Location = new System.Drawing.Point(542, 111);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(62, 13);
            this.lblAttendance.TabIndex = 24;
            this.lblAttendance.Text = "Attendance";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(740, 164);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(140, 20);
            this.txtRemark.TabIndex = 27;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(542, 167);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(49, 13);
            this.lblRemark.TabIndex = 26;
            this.lblRemark.Text = "Remark";
            // 
            // txtTCCreated
            // 
            this.txtTCCreated.Location = new System.Drawing.Point(740, 223);
            this.txtTCCreated.Name = "txtTCCreated";
            this.txtTCCreated.Size = new System.Drawing.Size(140, 20);
            this.txtTCCreated.TabIndex = 29;
            // 
            // lblTCCreated
            // 
            this.lblTCCreated.AutoSize = true;
            this.lblTCCreated.Location = new System.Drawing.Point(542, 226);
            this.lblTCCreated.Name = "lblTCCreated";
            this.lblTCCreated.Size = new System.Drawing.Size(61, 13);
            this.lblTCCreated.TabIndex = 28;
            this.lblTCCreated.Text = "TC Created";
            // 
            // txtCCCreated
            // 
            this.txtCCCreated.Location = new System.Drawing.Point(740, 284);
            this.txtCCCreated.Name = "txtCCCreated";
            this.txtCCCreated.Size = new System.Drawing.Size(140, 20);
            this.txtCCCreated.TabIndex = 31;
            // 
            // lblCCCreated
            // 
            this.lblCCCreated.AutoSize = true;
            this.lblCCCreated.Location = new System.Drawing.Point(542, 287);
            this.lblCCCreated.Name = "lblCCCreated";
            this.lblCCCreated.Size = new System.Drawing.Size(61, 13);
            this.lblCCCreated.TabIndex = 30;
            this.lblCCCreated.Text = "CC Created";
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(545, 398);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 33);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dateLeaving
            // 
            this.dateLeaving.Location = new System.Drawing.Point(258, 506);
            this.dateLeaving.Name = "dateLeaving";
            this.dateLeaving.Size = new System.Drawing.Size(140, 20);
            this.dateLeaving.TabIndex = 36;
            // 
            // UpdateStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 576);
            this.Controls.Add(this.dateLeaving);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dateDuesCleared);
            this.Controls.Add(this.dateAdmissionDate);
            this.Controls.Add(this.dateDOB);
            this.Controls.Add(this.txtCCCreated);
            this.Controls.Add(this.lblCCCreated);
            this.Controls.Add(this.txtTCCreated);
            this.Controls.Add(this.lblTCCreated);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.txtClassPassed);
            this.Controls.Add(this.lblClassPassed);
            this.Controls.Add(this.lblDateOfLeaving);
            this.Controls.Add(this.lblDuesClearedUpto);
            this.Controls.Add(this.lblAdmissionDate);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.lblMotherName);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.txtName);
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.Label lblMotherName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblAdmissionDate;
        private System.Windows.Forms.Label lblDuesClearedUpto;
        private System.Windows.Forms.Label lblDateOfLeaving;
        private System.Windows.Forms.TextBox txtClassPassed;
        private System.Windows.Forms.Label lblClassPassed;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.TextBox txtAttendance;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtTCCreated;
        private System.Windows.Forms.Label lblTCCreated;
        private System.Windows.Forms.TextBox txtCCCreated;
        private System.Windows.Forms.Label lblCCCreated;
        private System.Windows.Forms.DateTimePicker dateDOB;
        private System.Windows.Forms.DateTimePicker dateAdmissionDate;
        private System.Windows.Forms.DateTimePicker dateDuesCleared;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dateLeaving;
    }
}