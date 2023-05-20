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
                //char[] specialChars = { '#', '$', '%', '^', '&', '*', '@', '!','|',')','(','?','.','>'  };
                //bool containsCharacter = password.Contains(targetCharacter);
                int counter = 0;
                // add input check
                if (username.Length < 6 || username.Length > 8)
                {
                    MessageBox.Show("Invalide username length! \nneed to be between 6 to 8 digits!");
                    return;
                }
                int lastRow = worksheet.UsedRange.Rows.Count + 1;

                for (int i = 0; i < username.Length - 1; i++)
                {
                    if (username[i] >= '0' && username[i] <= '9')
                    {
                        counter++;
                    }
                    if (!(username[i] >= 'a' && username[i] <= 'z' || username[i] >= 'A' && username[i] <= 'Z' || username[i] >= '0' && username[i] <= '9'))
                    {
                        MessageBox.Show("Invalide username! \nJust english letter are allow and numbers!");
                        return;
                    }
                    if (counter > 2)
                    {
                        MessageBox.Show("Invalide username! \nneed to containe at most 2 numbers!");
                        return;
                    }
                }
                if (password.Length >= 8 && password.Length <= 10)
                {
                    bool specialFlag = false;
                    bool numberFlag = false;
                    bool charFlag = false;
                    foreach (char c in password)
                    {

                        if (char.IsSymbol(c) || char.IsPunctuation(c))
                            specialFlag = true;

                        if (char.IsNumber(c))
                            numberFlag = true;

                        if (char.IsLetter(c))
                            charFlag = true;

                    }
                    if (specialFlag == false)
                    {
                        MessageBox.Show("Invalide password! \nneed to containe at least 1 special character!");
                        return;
                    }
                    if (numberFlag == false)
                    {
                        MessageBox.Show("Invalide password! \nneed to containe at least 1 number!");
                        return;
                    }
                    if (charFlag == false)
                    {
                        MessageBox.Show("Invalide password! \nneed to containe at least 1 letter!");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Invalide password length! \nneed to be between 8 to 10 digits!");
                    return;
                }

                if (id.Length > 0)
                {
                    foreach (char c in id)
                    {

                        if (!(char.IsNumber(c)))
                        {
                            MessageBox.Show("Invalide ID! \njust numbers allowed!");
                            return;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Invalide ID field is empty!");
                    return;
                }
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

        private void confirm_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
