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
            this.btnSearchWithDetailsCC = new System.Windows.Forms.Button();
            this.txtCourseCC = new System.Windows.Forms.TextBox();
            this.lblCourseCC = new System.Windows.Forms.Label();
            this.txtNameCC = new System.Windows.Forms.TextBox();
            this.lblNameCC = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new WindowsFormsApp1.studentTCandCCDataSet1TableAdapters.TableAdapterManager();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.lblRoll = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupSearchByName = new System.Windows.Forms.GroupBox();
            this.searchWithRoll = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupSearchByName.SuspendLayout();
            this.searchWithRoll.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1038, 407);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.searchWithRoll.Controls.Add(this.button1);
            this.searchWithRoll.Controls.Add(this.lblRoll);
            this.searchWithRoll.Controls.Add(this.txtRoll);
            this.searchWithRoll.Location = new System.Drawing.Point(559, 12);
            this.searchWithRoll.Name = "searchWithRoll";
            this.searchWithRoll.Size = new System.Drawing.Size(302, 100);
            this.searchWithRoll.TabIndex = 23;
            this.searchWithRoll.TabStop = false;
            this.searchWithRoll.Text = "Search With Roll No.";
            this.searchWithRoll.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GenerateCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 557);
            this.Controls.Add(this.searchWithRoll);
            this.Controls.Add(this.groupSearchByName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GenerateCC";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateCC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupSearchByName.ResumeLayout(false);
            this.groupSearchByName.PerformLayout();
            this.searchWithRoll.ResumeLayout(false);
            this.searchWithRoll.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupSearchByName;
        private System.Windows.Forms.GroupBox searchWithRoll;
        private System.Windows.Forms.Button button1;
    }
}