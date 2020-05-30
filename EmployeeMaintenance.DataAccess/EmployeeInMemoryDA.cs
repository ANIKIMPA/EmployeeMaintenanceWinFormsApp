/*
 * File: EmployeeInMemoryFileDA.cs
 * Author: Niovan Martinez Vargas 845-11-4640
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/10/2018
 * Purpose: This class provides presistence for a collection of employees
 *          as an in-memory list.
 */

using EmployeeMaintenance.Domain;
using System;
using System.Collections.Generic;

namespace EmployeeMaintenance.DataAccess
{
    /// <summary>
    /// Provides presistence for a collection of employees as an in-memory list.
    /// </summary>
    public class EmployeeInMemoryDA : IEmployeeDA
    {
        /// <summary>The in-memory collection of employees.</summary>
        private List<Employee> employees = null;

        /// <summary>
        /// Creates a data access object for the in-memory collection.
        /// </summary>
        public EmployeeInMemoryDA()
        {
            employees = GetAllEmployees();
        }

        /// <summary>
        /// Returns the list of all employees in the collection.
        /// </summary>
        /// <returns>The list of all employees.</returns>
        public List<Employee> GetAllEmployees()
        {
            if (employees == null)
            {
                employees = new List<Employee>() {
                    new Employee("HW-111", "John Doe", Department.Finance, DateTime.Parse("04/23/2008"), 400.00m),
                    new Employee("HW-222", "Jane Doe", Department.InformationTechnology, DateTime.Parse("04/23/2008"), 450.00m) };

            }
            return employees;
        }

        /// <summary>
        /// Returns the data of the employee in the collection with the given employeeId.
        /// </summary>
        /// <param name="employeeId">The employeeId of the searched employee.</param>
        /// <returns>The employee with the given employeeId.</returns>
        public Employee GetEmployeeByEmployeeId(string employeeId)
        {
            foreach (Employee employee in employees)
            {
                if (employeeId == employee.EmployeeId)
                    return new Employee(employee.EmployeeId, employee.FullName,
                        employee.Department, employee.WeekStart, employee.Salary);
            }
            return null;
        }

        /// <summary>
        /// Adds the given employee to the collection of employees.
        /// </summary>
        /// <param name="employee">The employee to be added.</param>
        public void AddEmployee(Employee employee)
        {            
            employees.Add(employee);
        }

        /// <summary>
        /// Removes the given employee from the collection of employees.
        /// </summary>
        /// <param name="employee">The employee to be removed.</param>
        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        /// <summary>
        /// Updates the given employee from the collection of employees.
        /// </summary>
        /// <param name="employee">The employee to be updated.</param>
        public void UpdateEmployee(Employee employee)
        {
            Employee storedEmployee = this.GetEmployeeByEmployeeId(employee.EmployeeId);
            int index = employees.IndexOf(storedEmployee);

            employees.RemoveAt(index);
            employees.Insert(index, employee);
        }
    }
}
