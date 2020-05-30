/*
 * File: Employee.cs
 * Author: Niovan Martinez Vargas 845-11-4640
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/10/2018
 * Purpose: This class represents a employee.
 */

using System;

namespace EmployeeMaintenance.Domain
{
    /// <summary>
    /// Represents a employee.
    /// </summary>
    public class Employee
    {
        /// <summary>The number of employees that have been created.</summary>
        public static int NumberOfEmployees { get; private set; } = 0;

        /// <summary>The employeeId of this employee.</summary>
        public string EmployeeId { get; private set; }

        /// <summary>The fullName of this employee.</summary> 
        public string FullName { get; set; }

        /// <summary>The department of this employee.</summary>
        public Department Department { get; set; }

        /// <summary>The weekStart of this employee.</summary>
        public DateTime WeekStart { get; set; }

        /// <summary>The salary of this employee.</summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Creates a new employee with the given data.
        /// Both department and weekStart has a default value of 0.
        /// </summary>
        /// <param name="employeeId">The employeeId of this employee.</param>
        /// <param name="fullName">The fullName of this employee.</param>
        /// <param name="department">The department of this employee.</param>
        /// <param name="weekStart">The weekStart of this employee.</param>
        /// <param name="salary">The salary of this employee.</param>
        public Employee(string employeeId, string fullName, Department department, DateTime weekStart, decimal salary)
        {
            EmployeeId = employeeId;
            FullName = fullName;
            Department = department;
            WeekStart = weekStart;
            Salary = salary;

            NumberOfEmployees++;
        }

        /// <summary>
        /// Determines whether this employee has the same data as the given object.
        /// </summary>
        /// <param name="obj">The object that this employee is compared to.</param>
        /// <returns>true if both objects contains the data; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Employee other = (Employee)obj;
            return this.EmployeeId == other.EmployeeId &&
                this.FullName == other.FullName &&
                this.Department == other.Department &&
                this.WeekStart == other.WeekStart &&
                this.Salary == other.Salary;
        }

        /// <summary>
        /// Returns the hash employeeId for this employee.
        /// </summary>
        /// <returns>The hash employeeId based on the employee's key field.</returns>
        public override int GetHashCode() => EmployeeId.GetHashCode();

        /// <summary>
        /// Returns the string representation of this employee.
        /// </summary>
        /// <returns>A formatted string with the employee's data.</returns>
        public override string ToString() =>
                $"EmployeeId: {EmployeeId}\n" +
                $"FullName: {FullName}\n" +
                $"Department: {Department}\n" +
                $"WeekStart: {WeekStart}\n" +
                $"Salary: {Salary:c}";
    }
}
