/*
 * File: EmployeeMaintenanceForm.cs
 * Author: Niovan Martinez Vargas 845-4640
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/10/2018
 * Purpose: This form provides the basic maintenance operations for a employee.
 */

using EmployeeMaintenance.DataAccess;
using EmployeeMaintenance.Domain;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace EmployeeMaintenance.Presentation
{
    /// <summary>
    /// Provides the basic maintenance operations for a employee.
    /// </summary>
    public partial class EmployeeMaintenanceForm : Form
    {
        /// <summary>Provides access to data about a collection of employees.</summary>
        private IEmployeeDA employeeDA;

        /// <summary>
        /// Creates a Employee Maintenance form.
        /// </summary>
        public EmployeeMaintenanceForm()
        {
            InitializeComponent();

            ChooseFileForm frmChooseFile = new ChooseFileForm();
            DialogResult result = frmChooseFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                employeeDA = frmChooseFile.ChoosenFile;
                this.Text = frmChooseFile.FileName;
            }

            else
                employeeDA = new EmployeeBinaryFileDA();
        }

        /// <summary>
        /// Fills the Employee list view when the form loads.
        /// </summary>
        /// <param name="sender">The form that loads.</param>
        /// <param name="e">Additional event information.</param>
        private void frmEmployeeMaintenance_Load(object sender, EventArgs e)
        {
            this.FillEmployeeListView();
        }

        /// <summary>
        /// Populates the Employee list view with the data of all employees.
        /// </summary>
        private void FillEmployeeListView()
        {
            lvwEmployees.Items.Clear();
            foreach (Employee employee in employeeDA.GetAllEmployees())
            {
                string[] fields = {
                    employee.EmployeeId, employee.FullName,
                    employee.Department.ToString(), employee.WeekStart.ToString("d"), employee.Salary.ToString("c") };
                lvwEmployees.Items.Add(new ListViewItem(fields));
            }    
        }

        /// <summary>
        /// Displays the View Employee form when the View button is clicked.
        /// </summary>
        /// <param name="sender">The button that is clicked.</param>
        /// <param name="e">Additional event information</param>
        private void btnView_Click(object sender, EventArgs e)
        {
            if (lvwEmployees.SelectedIndices.Count == 0)
            {
                MessageBox.Show("No employee was selected.", "View Employee",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int index = lvwEmployees.SelectedIndices[0];
                string employeeId = lvwEmployees.Items[index].SubItems[0].Text;

                ViewEmployeeForm frmViewEmployee = new ViewEmployeeForm(employeeDA, employeeId);
                frmViewEmployee.ShowDialog();

                lvwEmployees.Items[index].Selected = false;
                lvwEmployees.Focus();
            }
        }

        /// <summary>
        /// Displays the Add New Employee form when the Add button is clicked.
        /// It then updates the user interface.
        /// </summary>
        /// <param name="sender">The button that is clicked.</param>
        /// <param name="e">Additional event information.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frmAddNewEmployee = new AddNewEmployeeForm(employeeDA);
            DialogResult result = frmAddNewEmployee.ShowDialog();

            if (result == DialogResult.OK)
                this.FillEmployeeListView();
            lvwEmployees.Focus();
        }

        /// <summary>
        /// Removes a employee when the Remove button is clicked.
        /// It then updates the user interface.
        /// </summary>
        /// <param name="sender">The button that is clicked.</param>
        /// <param name="e">Additional event information.</param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvwEmployees.SelectedIndices.Count == 0)
                MessageBox.Show("No employee was selected.", "Remove Employee",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int index = lvwEmployees.SelectedIndices[0];

                DialogResult answer = MessageBox.Show("Are you sure you want to remove?",
                        "Remove Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);

                if (answer == DialogResult.Yes)
                {
                    string employeeId = lvwEmployees.Items[index].SubItems[0].Text;
                    Employee employee = employeeDA.GetEmployeeByEmployeeId(employeeId);
                    employeeDA.RemoveEmployee(employee);
                    this.FillEmployeeListView();
                }
                else
                    lvwEmployees.Items[index].Selected = false;     
            }
            lvwEmployees.Focus();     
        }

        /// <summary>
        /// Displays the Modify Employee form when the Modify button is clicked.
        /// It then updates the user interface.
        /// </summary>
        /// <param name="sender">The button that is clicked.</param>
        /// <param name="e">Additional event information.</param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lvwEmployees.SelectedIndices.Count == 0)
                MessageBox.Show("No employee was selected.", "Modify Employee",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int index = lvwEmployees.SelectedIndices[0];
                string employeeId = lvwEmployees.Items[index].SubItems[0].Text;
                Form frmModifyEmployee = new ModifyEmployeeForm(employeeDA, employeeId);
                DialogResult result = frmModifyEmployee.ShowDialog();

                if (result == DialogResult.OK)
                    this.FillEmployeeListView();
                else
                    lvwEmployees.Items[index].Selected = false;
            }
            lvwEmployees.Focus();
        }

        /// <summary>
        /// Closes the form when the Exit button is clicked.
        /// </summary>
        /// <param name="sender">The button that is clicked.</param>
        /// <param name="e">Additional event information.</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Confirms the user decision to close the form.
        /// </summary>
        /// <param name="sender">The form that is closing.</param>
        /// <param name="e">Additional event information.</param>
        private void EmployeeMaintenaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer =
                MessageBox.Show("Are you sure you want to exit?", "Exit Application",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

            if (answer == DialogResult.No)
            {
                e.Cancel = true;
                lvwEmployees.Focus();
            }    
        }
    }
}
