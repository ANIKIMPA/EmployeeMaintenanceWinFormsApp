/*
 * File: EmployeeXmlFileDA.cs
 * Author: Niovan Martinez Vargas 845-11-4640
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/10/2018
 * Purpose: This class provides presistence for a collection of employees
 *          as an XML file.
 */

using EmployeeMaintenance.Domain;

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace EmployeeMaintenance.DataAccess
{
    /// <summary>
    /// Provides presistence for a collection of employees as a csv text file.
    /// </summary>
    public class EmployeeXmlFileDA : IEmployeeDA
    {
        /// <summary>The path of the binary file with the collection of employees.</summary>
        private const string FilePath = @"..\..\Data\employees.xml";

        /// <summary>The in-memory copy of the collection of employees.</summary>
        private List<Employee> employees;

        /// <summary>
        /// Creates a data access object for an XML file.
        /// </summary>
        public EmployeeXmlFileDA()
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

                if (!File.Exists(FilePath))
                    CreateEmptyXmlFile(FilePath);

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;

                using (XmlReader xmlFileIn = XmlReader.Create(FilePath, settings))
                {
                    try
                    {
                        if (xmlFileIn.ReadToDescendant("Employee"))
                        {
                            do
                            {
                                string employeeId = xmlFileIn.GetAttribute("EmployeeId");
                                xmlFileIn.ReadStartElement("Employee");
                                string fullName = xmlFileIn.ReadElementContentAsString();
                                Department department = (Department)Enum.Parse(typeof(Department),
                                                            xmlFileIn.ReadElementContentAsString());
                                DateTime weekStart = DateTime.Parse(xmlFileIn.ReadElementContentAsString());
                                decimal salary = xmlFileIn.ReadElementContentAsDecimal();

                                employees.Add(new Employee(employeeId, fullName, department, weekStart, salary));
                            } while (xmlFileIn.ReadToNextSibling("Employee"));
                        }
                    }
                    catch (Exception) { throw; }
                }
            }
            return employees;
        }

        /// <summary>
        /// Creates an empty XML file at the given path.
        /// </summary>
        /// <param name="path">The path where the file will be created.</param>
        private void CreateEmptyXmlFile(string path)
        {
            XmlWriter xmlNew = XmlWriter.Create(FilePath);
            xmlNew.WriteStartDocument();
            xmlNew.WriteStartElement("Employees");
            xmlNew.WriteEndElement();
            xmlNew.Close();
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
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");  // 4 spaces

            using (XmlWriter xmlOut = XmlWriter.Create(FilePath, settings))
            {
                try
                {
                    xmlOut.WriteStartDocument();
                    xmlOut.WriteComment("This is the collection of employees.");
                    xmlOut.WriteStartElement("Employees");

                    foreach (Employee employee in employees)
                    {
                        xmlOut.WriteStartElement("Employee");
                        xmlOut.WriteAttributeString("EmployeeId", employee.EmployeeId);
                        xmlOut.WriteElementString("FullName", employee.FullName);
                        xmlOut.WriteElementString("Department", employee.Department.ToString());
                        xmlOut.WriteElementString("WeekStart", employee.WeekStart.ToString());
                        xmlOut.WriteElementString("Salary", employee.Salary.ToString());
                        xmlOut.WriteEndElement();
                    }

                    xmlOut.WriteEndElement();
                }
                catch (Exception) { throw; }
            }
        }
    }
}
