namespace EmployeeMaintenance.Presentation
{
    partial class ViewEmployeeForm
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
            this.grpEmployeeData = new System.Windows.Forms.GroupBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtWeekStart = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblWeekStart = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpEmployeeData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployeeData
            // 
            this.grpEmployeeData.Controls.Add(this.txtDepartment);
            this.grpEmployeeData.Controls.Add(this.txtSalary);
            this.grpEmployeeData.Controls.Add(this.txtWeekStart);
            this.grpEmployeeData.Controls.Add(this.lblSalary);
            this.grpEmployeeData.Controls.Add(this.lblWeekStart);
            this.grpEmployeeData.Controls.Add(this.txtEmployeeId);
            this.grpEmployeeData.Controls.Add(this.lblEmployeeId);
            this.grpEmployeeData.Controls.Add(this.lblFullName);
            this.grpEmployeeData.Controls.Add(this.txtFullName);
            this.grpEmployeeData.Controls.Add(this.lblDepartment);
            this.grpEmployeeData.Location = new System.Drawing.Point(14, 16);
            this.grpEmployeeData.Margin = new System.Windows.Forms.Padding(2);
            this.grpEmployeeData.Name = "grpEmployeeData";
            this.grpEmployeeData.Padding = new System.Windows.Forms.Padding(2);
            this.grpEmployeeData.Size = new System.Drawing.Size(297, 158);
            this.grpEmployeeData.TabIndex = 3;
            this.grpEmployeeData.TabStop = false;
            this.grpEmployeeData.Text = "Employee &Data";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(77, 71);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(145, 20);
            this.txtDepartment.TabIndex = 13;
            this.txtDepartment.TabStop = false;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(77, 123);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 12;
            this.txtSalary.TabStop = false;
            // 
            // txtWeekStart
            // 
            this.txtWeekStart.Location = new System.Drawing.Point(77, 97);
            this.txtWeekStart.Name = "txtWeekStart";
            this.txtWeekStart.ReadOnly = true;
            this.txtWeekStart.Size = new System.Drawing.Size(100, 20);
            this.txtWeekStart.TabIndex = 11;
            this.txtWeekStart.TabStop = false;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(27, 126);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(39, 13);
            this.lblSalary.TabIndex = 10;
            this.lblSalary.Text = "Salary:";
            // 
            // lblWeekStart
            // 
            this.lblWeekStart.AutoSize = true;
            this.lblWeekStart.Location = new System.Drawing.Point(9, 100);
            this.lblWeekStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeekStart.Name = "lblWeekStart";
            this.lblWeekStart.Size = new System.Drawing.Size(64, 13);
            this.lblWeekStart.TabIndex = 6;
            this.lblWeekStart.Text = "Week Start:";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(77, 20);
            this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeeId.Size = new System.Drawing.Size(52, 20);
            this.txtEmployeeId.TabIndex = 1;
            this.txtEmployeeId.TabStop = false;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(3, 23);
            this.lblEmployeeId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "Employee ID:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(17, 47);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 13);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(77, 44);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(212, 20);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.TabStop = false;
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
            this.btnOK.Location = new System.Drawing.Point(241, 178);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ViewEmployeeForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 211);
            this.Controls.Add(this.grpEmployeeData);
            this.Controls.Add(this.btnOK);
            this.Name = "ViewEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employee";
            this.grpEmployeeData.ResumeLayout(false);
            this.grpEmployeeData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployeeData;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtWeekStart;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblWeekStart;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnOK;
    }
}