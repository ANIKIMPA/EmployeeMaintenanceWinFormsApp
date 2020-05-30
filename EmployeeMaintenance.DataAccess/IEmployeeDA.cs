/*
 * File: IEmployeeDA.cs
 * Author: Niovan Martinez Vargas 845-11-4640
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/10/2018
 * Purpose: This interface provides access to the data persistence
 *          mechanism for a collection of employees.
 */

using EmployeeMaintenance.Domain;

using System.Collections.Generic;

namespace EmployeeMaintenance.DataAccess
{
    /// <summary>
    /// Provides access to the data persistence mechanism for a collection of employees.
    /// </summary>
    public interface IEmployeeDA
    {
        /// <summary>
        /// Returns the list of all employees in the collection.
        /// </summary>
        /// <returns>The list of all employees.</returns>
        List<Employee> GetAllEmployees();

        /// <summary>
        /// Returns the data of the employee in the collection with the given employeeId.
        /// </summary>
        /// <param name="employeeId">The employeeId of the searched employee.</param>
        /// <returns>The employee with the given employeeId.</returns>
        Employee GetEmployeeByEmployeeId(string employeeId);

        /// <summary>
        /// Adds the given employee to the collection of employees.
        /// </summary>
        /// <param name="employee">The employee to be added.</param>
        void AddEmployee(Employee employee);

        /// <summary>
        /// Removes the given employee from the collection of employees.
        /// </summary>
        /// <param name="employee">The employee to be removed.</param>
        void RemoveEmployee(Employee employee);

        /// <summary>
        /// Updates the given employee from the collection of employees.
        /// </summary>
        /// <param name="employee">The employee to be updated.</param>
        void UpdateEmployee(Employee employee);
    }
}
