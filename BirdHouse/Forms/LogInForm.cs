using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace BirdHouse
{
    public partial class LogInForm : Form
    {
        private IExcelService _excelService;
        private Excel.Workbook _workbook;

        public LogInForm(IExcelService excelService)
        {
            InitializeComponent();
            _excelService = excelService;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            // finding the path to the data file
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = projectPath + "\\users.xls";

            _workbook = _excelService.OpenWorkbook(filePath);
            Excel.Worksheet worksheet = _workbook.Worksheets[1];

            try
            {
                // Search for the user's credentials
                for (int i = 2; i <= worksheet.UsedRange.Rows.Count; i++)
                {
                    //add input check
                    string? username = worksheet.Cells[i, 2].Value?.ToString();
                    string? password = worksheet.Cells[i, 3].Value?.ToString();

                    if (userNameBox.Text == username && passwordBox.Text == password)
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        return;
                    }
                }
                MessageBox.Show("Invalid username or password.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            // this line adds an event handler to detect this form closing
            this.FormClosing += new FormClosingEventHandler(this.LogInForm_FormClosing);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(_excelService);
            registerForm.Show();
            
        }

        private void LogInForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // this method is activated when the form is closed , it closes the excel file 
            if (_workbook != null)
            {
                _excelService.CloseAll(_workbook);
            }
        }

        private void LogInButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}

