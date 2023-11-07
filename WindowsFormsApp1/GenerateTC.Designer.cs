namespace WindowsFormsApp1
{
    partial class GenerateTC
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtNameTC = new System.Windows.Forms.TextBox();
            this.txtFatherNameTC = new System.Windows.Forms.TextBox();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtCourseTC = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnSearchStudentForTC = new System.Windows.Forms.Button();
            this.dateDOBTC = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(194, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtNameTC
            // 
            this.txtNameTC.Location = new System.Drawing.Point(320, 86);
            this.txtNameTC.Name = "txtNameTC";
            this.txtNameTC.Size = new System.Drawing.Size(100, 20);
            this.txtNameTC.TabIndex = 1;
            // 
            // txtFatherNameTC
            // 
            this.txtFatherNameTC.Location = new System.Drawing.Point(320, 144);
            this.txtFatherNameTC.Name = "txtFatherNameTC";
            this.txtFatherNameTC.Size = new System.Drawing.Size(100, 20);
            this.txtFatherNameTC.TabIndex = 3;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(194, 147);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(75, 13);
            this.lblFatherName.TabIndex = 2;
            this.lblFatherName.Text = "Father\'s Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(194, 212);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "DOB";
            // 
            // txtCourseTC
            // 
            this.txtCourseTC.Location = new System.Drawing.Point(320, 270);
            this.txtCourseTC.Name = "txtCourseTC";
            this.txtCourseTC.Size = new System.Drawing.Size(100, 20);
            this.txtCourseTC.TabIndex = 7;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(194, 273);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Course";
            // 
            // btnSearchStudentForTC
            // 
            this.btnSearchStudentForTC.Location = new System.Drawing.Point(320, 320);
            this.btnSearchStudentForTC.Name = "btnSearchStudentForTC";
            this.btnSearchStudentForTC.Size = new System.Drawing.Size(100, 23);
            this.btnSearchStudentForTC.TabIndex = 8;
            this.btnSearchStudentForTC.Text = "Search";
            this.btnSearchStudentForTC.UseVisualStyleBackColor = true;
            // 
            // dateDOBTC
            // 
            this.dateDOBTC.Location = new System.Drawing.Point(320, 204);
            this.dateDOBTC.Name = "dateDOBTC";
            this.dateDOBTC.Size = new System.Drawing.Size(134, 20);
            this.dateDOBTC.TabIndex = 9;
            // 
            // GenerateTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 425);
            this.Controls.Add(this.dateDOBTC);
            this.Controls.Add(this.btnSearchStudentForTC);
            this.Controls.Add(this.txtCourseTC);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtFatherNameTC);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.txtNameTC);
            this.Controls.Add(this.lblName);
            this.Name = "GenerateTC";
            this.Text = "GenerateTC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNameTC;
        private System.Windows.Forms.TextBox txtFatherNameTC;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtCourseTC;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnSearchStudentForTC;
        private System.Windows.Forms.DateTimePicker dateDOBTC;
    }
}