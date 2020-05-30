/*
 * File: EmployeeCsvFileDA.cs
 * Author: Niovan Martinez Vargas 845-11-4640
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/10/2018
 * Purpose: This class provides presistence for a collection of employees
 *          as a comma-separated values (CSV) text file.
 */

using EmployeeMaintenance.Domain;

using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeMaintenance.DataAccess
{
    /// <summary>
    /// Provides presistence for a collection of employees as a CSV text file.
    /// </summary>
    public class EmployeeCsvFileDA : IEmployeeDA
    {
        /// <summary>The path of the binary file with the collection of employees.</summary>
        private const string FilePath = @"..\..\Data\employees.csv";

        /// <summary>The field separator.</summary>
        private const char FieldSep = ',';

        /// <summary>The in-memory copy of the collection of employees.</summary>
        private List<Employee> employees = null;

        /// <summary>
        /// Creates a data access object for a CSV text file.
        /// </summary>
        public EmployeeCsvFileDA()
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

                using (StreamReader csvFileIn = new StreamReader(
                    new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Read)))
                {
                    try
                    {
                        csvFileIn.ReadLine();   // ignore header
                        while (csvFileIn.Peek() != -1)
                        {
                            string[] fields = csvFileIn.ReadLine().Split(FieldSep);

                            string employeeId = fields[0];
                            string fullName = fields[1];
                            Department department = (Department)Enum.Parse(typeof(Department), fields[2]);
                            DateTime weekStart = DateTime.Parse(fields[3]);
                            decimal salary = decimal.Parse(fields[4]);

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
            int index = employees.IndexOf(this.GetEmployeeByEmployeeId(employee.EmployeeId));

            employees.RemoveAt(index);
            employees.Insert(index, employee);
            this.SaveAllEmployees();
        }

        /// <summary>
        /// Saves the collection of employees in secondary storage.
        /// </summary>
        private void SaveAllEmployees()
        {
            using (StreamWriter csvFileOut = new StreamWriter(
                new FileStream(FilePath, FileMode.Create, FileAccess.Write)))
            {
                try
                {
                    csvFileOut.WriteLine($"EmployeeId{FieldSep}FullName{FieldSep}" +
                        $"Department{FieldSep}WeekStart{FieldSep}Salary");

                    foreach (Employee employee in employees)
                    {
                        csvFileOut.Write(employee.EmployeeId + FieldSep);
                        csvFileOut.Write(employee.FullName + FieldSep);
                        csvFileOut.Write(employee.Department+ FieldSep);
                        csvFileOut.WriteLine(employee.WeekStart);
                        csvFileOut.WriteLine(employee.Salary);
                    }

                }
                catch (Exception) { throw; }
            }
        }
    }
}
