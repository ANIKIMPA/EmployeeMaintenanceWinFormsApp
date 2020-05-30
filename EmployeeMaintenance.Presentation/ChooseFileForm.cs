using EmployeeMaintenance.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMaintenance.Presentation
{
    public partial class ChooseFileForm : Form
    {
        public IEmployeeDA ChoosenFile { get; private set; }

        public string FileName { get; private set; }

        public ChooseFileForm()
        {
            InitializeComponent();
        }

        private void ChooseFileForm_Load(object sender, EventArgs e)
        {
            cboChooseFile.Items.Add("Binary File");
            cboChooseFile.Items.Add("CSV File");
            cboChooseFile.Items.Add("In Memory File");
            cboChooseFile.Items.Add("XML File");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int index = cboChooseFile.SelectedIndex;

                if (index != -1)
                {
                    if (index >= 3)
                        ChoosenFile = new EmployeeXmlFileDA();
                        
                    else if (index >= 2)
                        ChoosenFile = new EmployeeInMemoryDA();
                        
                    else if (index >= 1)
                        ChoosenFile = new EmployeeCsvFileDA();
                        
                    else if (index >= 0)
                        ChoosenFile = new EmployeeBinaryFileDA();

                    FileName = (string)cboChooseFile.SelectedItem;
                    this.DialogResult = DialogResult.OK;
                }
                else
                MessageBox.Show("No file was selected.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Error Caught", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
