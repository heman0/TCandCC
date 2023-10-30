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
            this.tblStudentInfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTCandCCDataSet1 = new WindowsFormsApp1.studentTCandCCDataSet1();
            this.tblStudentInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTCandCCDataSet = new WindowsFormsApp1.studentTCandCCDataSet();
            this.tblStudentInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tCandCCDataSet2 = new WindowsFormsApp1.TCandCCDataSet2();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCandCCDataSet1 = new WindowsFormsApp1.TCandCCDataSet1();
            this.tbl_Student_InfoTableAdapter = new WindowsFormsApp1.TCandCCDataSet1TableAdapters.tbl_Student_InfoTableAdapter();
            this.tbl_Student_InfoTableAdapter1 = new WindowsFormsApp1.TCandCCDataSet2TableAdapters.tbl_Student_InfoTableAdapter();
            this.txtSearchRecordForUpdate = new System.Windows.Forms.TextBox();
            this.btnSearchRecordForUpdate = new System.Windows.Forms.Button();
            this.tbl_Student_InfoTableAdapter2 = new WindowsFormsApp1.studentTCandCCDataSetTableAdapters.tbl_Student_InfoTableAdapter();
            this.tbl_Student_InfoTableAdapter3 = new WindowsFormsApp1.studentTCandCCDataSet1TableAdapters.tbl_Student_InfoTableAdapter();
            this.gridShowDataForUpdate = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTCandCCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTCandCCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowDataForUpdate)).BeginInit();
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
            // tblStudentInfoBindingSource3
            // 
            this.tblStudentInfoBindingSource3.DataMember = "tbl_Student_Info";
            this.tblStudentInfoBindingSource3.DataSource = this.studentTCandCCDataSet1;
            // 
            // studentTCandCCDataSet1
            // 
            this.studentTCandCCDataSet1.DataSetName = "studentTCandCCDataSet1";
            this.studentTCandCCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentInfoBindingSource2
            // 
            this.tblStudentInfoBindingSource2.DataMember = "tbl_Student_Info";
            this.tblStudentInfoBindingSource2.DataSource = this.studentTCandCCDataSet;
            // 
            // studentTCandCCDataSet
            // 
            this.studentTCandCCDataSet.DataSetName = "studentTCandCCDataSet";
            this.studentTCandCCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentInfoBindingSource1
            // 
            this.tblStudentInfoBindingSource1.DataMember = "tbl_Student_Info";
            this.tblStudentInfoBindingSource1.DataSource = this.tCandCCDataSet2;
            // 
            // tCandCCDataSet2
            // 
            this.tCandCCDataSet2.DataSetName = "TCandCCDataSet2";
            this.tCandCCDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tbl_Student_InfoTableAdapter1
            // 
            this.tbl_Student_InfoTableAdapter1.ClearBeforeFill = true;
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
            // tbl_Student_InfoTableAdapter2
            // 
            this.tbl_Student_InfoTableAdapter2.ClearBeforeFill = true;
            // 
            // tbl_Student_InfoTableAdapter3
            // 
            this.tbl_Student_InfoTableAdapter3.ClearBeforeFill = true;
            // 
            // gridShowDataForUpdate
            // 
            this.gridShowDataForUpdate.AllowUserToAddRows = false;
            this.gridShowDataForUpdate.AllowUserToDeleteRows = false;
            this.gridShowDataForUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridShowDataForUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowDataForUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update});
            this.gridShowDataForUpdate.Location = new System.Drawing.Point(21, 55);
            this.gridShowDataForUpdate.Name = "gridShowDataForUpdate";
            this.gridShowDataForUpdate.ReadOnly = true;
            this.gridShowDataForUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridShowDataForUpdate.Size = new System.Drawing.Size(1053, 561);
            this.gridShowDataForUpdate.TabIndex = 0;
            this.gridShowDataForUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridShowDataForUpdate_CellContentClick);
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForLinkValue = true;
            // 
            // UpdateStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 638);
            this.Controls.Add(this.btnSearchRecordForUpdate);
            this.Controls.Add(this.txtSearchRecordForUpdate);
            this.Controls.Add(this.gridShowDataForUpdate);
            this.Name = "UpdateStudentRecord";
            this.Text = "UpdateStudentRecord";
            this.Load += new System.EventHandler(this.UpdateStudentRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTCandCCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTCandCCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCandCCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowDataForUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tCandCCDataSetBindingSource;
        private TCandCCDataSet tCandCCDataSet;
        private TCandCCDataSet1 tCandCCDataSet1;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource;
        private TCandCCDataSet1TableAdapters.tbl_Student_InfoTableAdapter tbl_Student_InfoTableAdapter;
        private TCandCCDataSet2 tCandCCDataSet2;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource1;
        private TCandCCDataSet2TableAdapters.tbl_Student_InfoTableAdapter tbl_Student_InfoTableAdapter1;
        private System.Windows.Forms.TextBox txtSearchRecordForUpdate;
        private System.Windows.Forms.Button btnSearchRecordForUpdate;
        private studentTCandCCDataSet studentTCandCCDataSet;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource2;
        private studentTCandCCDataSetTableAdapters.tbl_Student_InfoTableAdapter tbl_Student_InfoTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceDataGridViewTextBoxColumn;
        private studentTCandCCDataSet1 studentTCandCCDataSet1;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource3;
        private studentTCandCCDataSet1TableAdapters.tbl_Student_InfoTableAdapter tbl_Student_InfoTableAdapter3;
        private System.Windows.Forms.DataGridView gridShowDataForUpdate;
        private System.Windows.Forms.DataGridViewLinkColumn Update;
    }
}