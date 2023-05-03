using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace BirdHouse
{
    public partial class RegisterForm : Form
    {
        private IExcelService _excelService;
        private Excel.Workbook _workbook;

        public RegisterForm(IExcelService excelService)
        {
            InitializeComponent();
            _excelService = excelService;

        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = projectPath + "\\users.xls";

            try
            {
                _workbook = _excelService.OpenWorkbook(filePath);
                Excel.Worksheet worksheet = _workbook.Worksheets[1];

                string? username = userNameBox.Text;
                string? password = passwordBox.Text;
                string? id = idBox.Text;
                // add input check

                int lastRow = worksheet.UsedRange.Rows.Count + 1;

                // if input check passed , we can save the data to the file 
                worksheet.Cells[lastRow, 1] = idBox.Text;
                worksheet.Cells[lastRow, 2] = userNameBox.Text;
                worksheet.Cells[lastRow, 3] = passwordBox.Text;

                MessageBox.Show("Register Successful !");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // this line adds an event handler to detect this form closing
            this.FormClosing += new FormClosingEventHandler(this.RegisterForm_FormClosing);
        }

        private void RegisterForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // this method is activated when the form is closed , it closes the excel file 
            if (_workbook != null)
                _excelService.CloseAll(_workbook);
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
