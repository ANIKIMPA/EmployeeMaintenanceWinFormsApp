/*
 * File: EmployeeBinaryFileDA.cs
 * Author: Niovan Martinez Vargas 845-11-4640
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/10/2018
 * Purpose: This class provides presistence for a collection of employees
 *          as a binary file.
 */

using EmployeeMaintenance.Domain;

using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeMaintenance.DataAccess
{
    /// <summary>
    /// Provides presistence for a collection of employees as a binary file.
    /// </summary>
    public class EmployeeBinaryFileDA : IEmployeeDA
    {
        /// <summary>The path of the binary file with the collection of employees.</summary>
        private const string FilePath = @"..\..\Data\employees.bin";

        /// <summary>The in-memory copy of the collection of employees.</summary>
        private List<Employee> employees;

        /// <summary>
        /// Creates a data access object for a binary file.
        /// </summary>
        public EmployeeBinaryFileDA()
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
                employees = new List<Employee>();

                string dirPath = Path.GetDirectoryName(FilePath);
                if (!Directory.Exists(dirPath))
                    Directory.CreateDirectory(dirPath);

                using (BinaryReader binFileIn = new BinaryReader(
                    new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Read)))
                {
                    try
                    {
                        while (binFileIn.PeekChar() != -1)
                        {
                            string employeeId = binFileIn.ReadString();
                            string fullName = binFileIn.ReadString();
                            Department department = (Department)Enum.Parse(typeof(Department),
                                                        binFileIn.ReadString());
                            DateTime weekStart = DateTime.Parse(binFileIn.ReadString());
                            decimal salary = decimal.Parse(binFileIn.ReadString());

                            employees.Add(new Employee(employeeId, fullName, department, weekStart, salary));
                        }
                    }
                    catch (Exception) { throw; }
                }
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
            this.SaveAllEmployees();
        }

        /// <summary>
        /// Removes the given employee from the collection of employees.
        /// </summary>
        /// <param name="employee">The employee to be removed.</param>
        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
            this.SaveAllEmployees();
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
            this.SaveAllEmployees();
        }

        /// <summary>
        /// Saves the collection of employees in secondary storage.
        /// </summary>
        private void SaveAllEmployees()
        {
            using (BinaryWriter binFileOut = new BinaryWriter(
                new FileStream(FilePath, FileMode.Create, FileAccess.Write)))
            {
                try
                {
                    foreach (Employee employee in employees)
                    {
                        binFileOut.Write(employee.EmployeeId);
                        binFileOut.Write(employee.FullName);
                        binFileOut.Write(employee.Department.ToString());
                        binFileOut.Write(employee.WeekStart.ToString());
                        binFileOut.Write(employee.Salary.ToString());
                    }
                }
                catch (Exception) { throw; }
            }
        }
    }
}
