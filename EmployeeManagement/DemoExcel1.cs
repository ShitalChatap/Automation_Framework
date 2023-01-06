using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class DemoExcel1
    {
        
        public object[] DemoExcelRead()
        {
            XLWorkbook book = new XLWorkbook("C:\\Users\\shitalc\\Desktop\\C#_2022\\AutomationFramework\\EmployeeManagement\\TestData\\Orange_data.xlsx");
            IXLWorksheet sheet = book.Worksheet("InvalidLoginTest");

            IXLRange range = sheet.RangeUsed();
            object[] allData = new object[2];
            for (int r = 2; r <= 3; r++)
            {
                //array for one test case //one row 
                string[] arr =new string[3];
                for (int c = 1; c <= 3; c++)
                {
                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);
                    arr[c - 1] = value;
                }
                //Console.WriteLine(r);
                //Console.WriteLine(c);
                //Console.WriteLine("-----------------");
                allData[r-2] = arr;
            }
            
            return allData;
        }


    }
}
