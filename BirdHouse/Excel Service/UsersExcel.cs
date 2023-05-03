using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace BirdHouse
{
    internal class UsersExcel : IExcelService
    {
        private Excel.Application? _xlApp;

        public UsersExcel()
        {
            _xlApp = new Excel.Application();
        }

        public Excel.Workbook OpenWorkbook(string filePath)
        {
            if (File.Exists(filePath))
            {
                // file is found in the directory, so we assume the users data file exists
                return _xlApp.Workbooks.Open(filePath);
            }

            else
            {
                // file doesn't exist, create it
                object misValue = System.Reflection.Missing.Value;

                var xlWorkBook = _xlApp.Workbooks.Add(misValue);
                var xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "id";
                xlWorkSheet.Cells[1, 2] = "username";
                xlWorkSheet.Cells[1, 3] = "password";

                
                xlWorkBook.SaveAs(filePath, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                Marshal.ReleaseComObject(xlWorkSheet);
                return xlWorkBook;
            }
        }
        public void CloseWorkbook(Excel.Workbook workbook)
        {
            if (workbook.Worksheets[1] != null)
            {
                Marshal.ReleaseComObject(workbook.Worksheets[1]);
            }

            if (workbook != null)
            {
                workbook.Save();
                workbook.Close(true);
                Marshal.ReleaseComObject(workbook);
            }

        }
        public void CloseAll(Excel.Workbook workbook)
        {
            if (workbook != null)
            {
                workbook.Close(true);
                Marshal.ReleaseComObject(workbook);
            }

            if (_xlApp != null)
            {
                _xlApp.Quit();
                Marshal.ReleaseComObject(_xlApp);
                _xlApp = null;
            }
        }





    }
}
