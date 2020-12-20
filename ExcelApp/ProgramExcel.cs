using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelApp
{
    class ProgramExcel
    {
        static void Main(string[] args)
        {

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWb = excelApp.Workbooks.Add();
            Excel.Worksheet excelSheet = excelWb.Sheets[1];

            excelSheet.Name = "Custom sheet";
            excelSheet.Cells[1, 1] = "Custom test data";

            //excelWb.SaveAs("testsheet.xls");
            excelWb.Close();
            excelApp.Quit();

            Marshal.ReleaseComObject(excelSheet);
            Marshal.ReleaseComObject(excelWb);
            Marshal.ReleaseComObject(excelApp);
            
        }
    }
}
