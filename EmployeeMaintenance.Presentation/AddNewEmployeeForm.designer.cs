namespace EmployeeMaintenance.Presentation
{
    partial class AddNewEmployeeForm
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

        #region Windows Form Designer generated employeeId

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the employeeId editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpEmployeeData = new System.Windows.Forms.GroupBox();
            this.dtpWeekStartDate = new System.Windows.Forms.DateTimePicker();
            this.updSalary = new System.Windows.Forms.NumericUpDown();
            this.lblSalary = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblWeekStart = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.grpEmployeeData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(9, 23);
            this.lblEmployeeId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(65, 13);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "EmployeeId:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(72, 46);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.MaxLength = 30;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(212, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(9, 47);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "FullName:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(9, 73);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(157, 185);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(237, 185);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpEmployeeData
            // 
            this.grpEmployeeData.Controls.Add(this.dtpWeekStartDate);
            this.grpEmployeeData.Controls.Add(this.updSalary);
            this.grpEmployeeData.Controls.Add(this.lblSalary);
            this.grpEmployeeData.Controls.Add(this.cboDepartment);
            this.grpEmployeeData.Controls.Add(this.lblWeekStart);
            this.grpEmployeeData.Controls.Add(this.txtEmployeeId);
            this.grpEmployeeData.Controls.Add(this.lblEmployeeId);
            this.grpEmployeeData.Controls.Add(this.lblFullName);
            this.grpEmployeeData.Controls.Add(this.txtFullName);
            this.grpEmployeeData.Controls.Add(this.lblDepartment);
            this.grpEmployeeData.Location = new System.Drawing.Point(10, 16);
            this.grpEmployeeData.Margin = new System.Windows.Forms.Padding(2);
            this.grpEmployeeData.Name = "grpEmployeeData";
            this.grpEmployeeData.Padding = new System.Windows.Forms.Padding(2);
            this.grpEmployeeData.Size = new System.Drawing.Size(297, 156);
            this.grpEmployeeData.TabIndex = 0;
            this.grpEmployeeData.TabStop = false;
            this.grpEmployeeData.Text = "Employee &Data";
            // 
            // dtpWeekStartDate
            // 
            this.dtpWeekStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeekStartDate.Location = new System.Drawing.Point(72, 98);
            this.dtpWeekStartDate.MaxDate = new System.DateTime(2018, 5, 10, 0, 0, 0, 0);
            this.dtpWeekStartDate.MinDate = new System.DateTime(1780, 1, 1, 0, 0, 0, 0);
            this.dtpWeekStartDate.Name = "dtpWeekStartDate";
            this.dtpWeekStartDate.Size = new System.Drawing.Size(121, 20);
            this.dtpWeekStartDate.TabIndex = 7;
            this.dtpWeekStartDate.Value = new System.DateTime(2018, 5, 10, 0, 0, 0, 0);
            // 
            // updSalary
            // 
            this.updSalary.DecimalPlaces = 2;
            this.updSalary.Location = new System.Drawing.Point(72, 124);
            this.updSalary.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.updSalary.Name = "updSalary";
            this.updSalary.Size = new System.Drawing.Size(76, 20);
            this.updSalary.TabIndex = 9;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(12, 126);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(60, 13);
            this.lblSalary.TabIndex = 8;
            this.lblSalary.Text = "Salary:     $";
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(72, 70);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(145, 21);
            this.cboDepartment.TabIndex = 5;
            // 
            // lblWeekStart
            // 
            this.lblWeekStart.AutoSize = true;
            this.lblWeekStart.Location = new System.Drawing.Point(9, 100);
            this.lblWeekStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeekStart.Name = "lblWeekStart";
            this.lblWeekStart.Size = new System.Drawing.Size(61, 13);
            this.lblWeekStart.TabIndex = 6;
            this.lblWeekStart.Text = "WeekStart:";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(72, 21);
            this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeId.MaxLength = 6;
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(76, 20);
            this.txtEmployeeId.TabIndex = 1;
            // 
            // AddNewEmployeeForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(326, 220);
            this.Controls.Add(this.grpEmployeeData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddNewEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.AddNewEmployeeForm_Load);
            this.grpEmployeeData.ResumeLayout(false);
            this.grpEmployeeData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpEmployeeData;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblWeekStart;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.NumericUpDown updSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.DateTimePicker dtpWeekStartDate;
    }
}