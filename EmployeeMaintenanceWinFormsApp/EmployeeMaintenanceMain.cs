﻿using EmployeeMaintenance.Presentation;

using System;
using System.Windows.Forms;

namespace EmployeeMaintenanceWinFormsApp
{
    static class EmployeeMaintenanceMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeMaintenanceForm());
        }
    }
}