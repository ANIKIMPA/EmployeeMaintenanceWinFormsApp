/*
 * File: AddNewEmployeeForm.cs
 * Author: Niovan Martinez Vargas 845-11-4640
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/10/2018
 * Purpose: This form allows the addition of a employee.
 */

using EmployeeMaintenance.DataAccess;
using EmployeeMaintenance.Domain;

using System;
using System.Windows.Forms;

using ValidationLibrary;

namespace EmployeeMaintenance.Presentation
{
    /// <summary>
    /// Allows the addition of a employee.
    /// </summary>
    public partial class AddNewEmployeeForm : Form
    {
        /// <summary>Provides data access for a employee.</summary>
        private IEmployeeDA employeeDA;

        /// <summary>
        /// Creates a Add New Employee form.
        /// </summary>
        /// <param name="employeeDA">Provides data access for a employee.</param>
        public AddNewEmployeeForm(IEmployeeDA employeeDA)
        {
            InitializeComponent();
            this.employeeDA = employeeDA;
        }

        /// <summary>
        /// Adds the employee when the Ok button is clicked.
        /// </summary>
        /// <param name="sender">The button that is clicked.</param>
        /// <param name="e">Additional event information.</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    Employee employee = employeeDA.GetEmployeeByEmployeeId(txtEmployeeId.Text);

                    if (employee == null)
                    {
                        employee = new Employee(txtEmployeeId.Text, txtFullName.Text,
                            (Department)cboDepartment.SelectedItem, dtpWeekStartDate.Value, updSalary.Value);
                        employeeDA.AddEmployee(employee);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Employee is already on list.", "Add Employee",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmployeeId.SelectAll();
                        txtEmployeeId.Focus();
                    }                       
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
            return Validator.MatchesPattern(txtEmployeeId, "Employee ID", @"^[A-Z]{2}-\d{3}$") &&
                Validator.IsPresent(txtFullName, "FullName") &&
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
        /// When the form load add the departments to the combo box.
        /// </summary>
        /// <param name="sender">The button that is clicked.</param>
        /// <param name="e">Additional event information.</param>
        private void AddNewEmployeeForm_Load(object sender, EventArgs e)
        {
            cboDepartment.Items.Add(Department.Finance);
            cboDepartment.Items.Add(Department.HumanResources);
            cboDepartment.Items.Add(Department.InformationTechnology);
            cboDepartment.Items.Add(Department.Marketing);
            cboDepartment.Items.Add(Department.Sales);

            dtpWeekStartDate.MaxDate = DateTime.Today;
            dtpWeekStartDate.Value = DateTime.Today;
        }
    }
}
