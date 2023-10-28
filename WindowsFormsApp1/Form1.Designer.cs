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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridShowData = new System.Windows.Forms.DataGridView();
            this.pnlDeleteStudent = new System.Windows.Forms.Panel();
            this.txtRollNoForDelete = new System.Windows.Forms.TextBox();
            this.lblRollNoForDelete = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowData)).BeginInit();
            this.pnlDeleteStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentManagementToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem});
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student Record";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student Record";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // gridShowData
            // 
            this.gridShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowData.Location = new System.Drawing.Point(23, 27);
            this.gridShowData.Name = "gridShowData";
            this.gridShowData.Size = new System.Drawing.Size(899, 479);
            this.gridShowData.TabIndex = 1;
            // 
            // pnlDeleteStudent
            // 
            this.pnlDeleteStudent.Controls.Add(this.button1);
            this.pnlDeleteStudent.Controls.Add(this.lblRollNoForDelete);
            this.pnlDeleteStudent.Controls.Add(this.txtRollNoForDelete);
            this.pnlDeleteStudent.Location = new System.Drawing.Point(23, 27);
            this.pnlDeleteStudent.Name = "pnlDeleteStudent";
            this.pnlDeleteStudent.Size = new System.Drawing.Size(670, 467);
            this.pnlDeleteStudent.TabIndex = 2;
            this.pnlDeleteStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDeleteStudent_Paint);
            // 
            // txtRollNoForDelete
            // 
            this.txtRollNoForDelete.Location = new System.Drawing.Point(103, 80);
            this.txtRollNoForDelete.Name = "txtRollNoForDelete";
            this.txtRollNoForDelete.Size = new System.Drawing.Size(100, 20);
            this.txtRollNoForDelete.TabIndex = 0;
            // 
            // lblRollNoForDelete
            // 
            this.lblRollNoForDelete.AutoSize = true;
            this.lblRollNoForDelete.Location = new System.Drawing.Point(32, 83);
            this.lblRollNoForDelete.Name = "lblRollNoForDelete";
            this.lblRollNoForDelete.Size = new System.Drawing.Size(42, 13);
            this.lblRollNoForDelete.TabIndex = 1;
            this.lblRollNoForDelete.Text = "Roll No";
            this.lblRollNoForDelete.UseMnemonic = false;
            this.lblRollNoForDelete.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 506);
            this.Controls.Add(this.pnlDeleteStudent);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gridShowData);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCandCC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowData)).EndInit();
            this.pnlDeleteStudent.ResumeLayout(false);
            this.pnlDeleteStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridShowData;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDeleteStudent;
        private System.Windows.Forms.Label lblRollNoForDelete;
        private System.Windows.Forms.TextBox txtRollNoForDelete;
        private System.Windows.Forms.Button button1;
    }
}

