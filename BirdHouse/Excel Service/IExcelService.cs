using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace BirdHouse
{
    public interface IExcelService
    {
        Excel.Workbook OpenWorkbook(string filePath);
        void CloseAll(Excel.Workbook workbook);

        void CloseWorkbook(Excel.Workbook workbook);

        //create file
        //save

    }
}
