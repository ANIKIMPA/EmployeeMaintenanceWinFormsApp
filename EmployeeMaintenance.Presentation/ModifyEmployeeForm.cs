/*
 * File: ModifyEmployeeForm.cs
 * Author: Niovan Martinez Vargas 845-11-4640
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/10/2018
 * Purpose: This form allows the modification of a employee.
 */

using EmployeeMaintenance.DataAccess;
using EmployeeMaintenance.Domain;

using System;
using System.Windows.Forms;

using ValidationLibrary;

namespace EmployeeMaintenance.Presentation
{
    /// <summary>
    /// Allows the modification of a employee.
    /// </summary>
    public partial class ModifyEmployeeForm : Form
    {
        /// <summary>Provides data access for a employee.</summary>
        private IEmployeeDA employeeDA;

        /// <summary>Contains the data of a employee.</summary>
        private Employee employee;

        /// <summary>
        /// Creates a Modify Employee form and displays the data of the employee with
        /// the given employeeId.
        /// </summary>
        /// <param name="employeeDA">Provides data access for a employee.</param>
        /// <param name="employeeId">The employeeId of the employee being modified.</param>
        public ModifyEmployeeForm(IEmployeeDA employeeDA, string employeeId)
        {
            InitializeComponent();
            this.employeeDA = employeeDA;
            employee = employeeDA.GetEmployeeByEmployeeId(employeeId);

            txtEmployeeId.Text = employee.EmployeeId;
            txtFullName.Text = employee.FullName;
            cboDepartment.Text = employee.Department.ToString();
            dtpWeekStartDate.Value = employee.WeekStart;
            updSalary.Value = employee.Salary;
        }

        /// <summary>
        /// Updates the employee when the Ok button is clicked.
        /// </summary>
        /// <param name="sender">The button that is clicked.</param>
        /// <param name="e">Additional event information.</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    employee.FullName = txtFullName.Text;
                    employee.Department = (Department)Enum.Parse(typeof(Department), cboDepartment.Text);
                    employee.WeekStart = dtpWeekStartDate.Value;
                    employee.Salary = updSalary.Value;

                    employeeDA.UpdateEmployee(employee);
                    this.DialogResult = DialogResult.OK;      
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() +
                    "\n" + ex.StackTrace, "Exception Caught",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Determines whether this form contains valid data.
        /// </summary>
        /// <returns>true if the form contains valid data; otherwise, false.</returns>
        private bool IsValidData()
        {
            return Validator.IsPresent(txtFullName, "Full name") &&
                Validator.MatchesPattern(txtFullName, "Full name", "^[A-Z].+$") &&
                Validator.IsPresent(cboDepartment, "Department");
        }

        /// <summary>
        /// Cancels the update operation when the Cancel button is clicked.
        /// </summary>
        /// <param name="sender">The button that is clicked.</param>
        /// <param name="e">Additional event information.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// When the form load add the departements to a combo box.
        /// </summary>
        /// <param name="sender">The buton that is clicked.</param>
        /// <param name="e">Additional event information.</param>
        private void ModifyEmployeeForm_Load(object sender, EventArgs e)
        {
            cboDepartment.Items.Add(Department.Finance);
            cboDepartment.Items.Add(Department.HumanResources);
            cboDepartment.Items.Add(Department.InformationTechnology);
            cboDepartment.Items.Add(Department.Marketing);
            cboDepartment.Items.Add(Department.Sales);

            dtpWeekStartDate.MaxDate = DateTime.Today;
        }
    }
}
