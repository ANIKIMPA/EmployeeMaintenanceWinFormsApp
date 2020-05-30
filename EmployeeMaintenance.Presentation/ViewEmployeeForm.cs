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

namespace EmployeeMaintenance.Presentation
{
    /// <summary>
    /// Allows the modification of an employee.
    /// </summary>
    public partial class ViewEmployeeForm : Form
    {
        /// <summary>Provides data access for an employee.</summary>
        private IEmployeeDA employeeDA;

        /// <summary>Contains the data of an employee.</summary>
        private Employee employee;

        /// <summary>
        /// Creates a View Employee form and displays the data of the employee with
        /// the given employeeId.
        /// </summary>
        /// <param name="employeeDA">Provides data access for a employee.</param>
        /// <param name="employeeId">The employeeId of the employee being modified.</param>
        public ViewEmployeeForm(IEmployeeDA employeeDA, String employeeId)
        {
            InitializeComponent();
            this.employeeDA = employeeDA;

            employee = employeeDA.GetEmployeeByEmployeeId(employeeId);

            txtEmployeeId.Text = employee.EmployeeId;
            txtFullName.Text = employee.FullName;
            txtDepartment.Text = employee.Department.ToString();
            txtWeekStart.Text = employee.WeekStart.ToString("d");
            txtSalary.Text = employee.Salary.ToString("c");
        }

        /// <summary>
        /// Return to the main form when the OK button is clicked.
        /// </summary>
        /// <param name="sender">The button that is clicked.</param>
        /// <param name="e">Additional event information.</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
