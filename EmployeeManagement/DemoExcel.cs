using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class DemoExcel
    {
        [Test]
        public void DemoExcelRead()
        {
            XLWorkbook book = new XLWorkbook("C:\\Users\\shitalc\\Desktop\\C#_2022\\AutomationFramework\\EmployeeManagement\\TestData\\Orange_data.xlsx");
            IXLWorksheet sheet = book.Worksheet("InvalidLoginTest");

            IXLRange range = sheet.RangeUsed();

                for(int r=2;r<=4;r++)
            {
                for(int c=1;c<=3;c++)
                {
                    string value =range.Cell(r,c).GetString();
                    Console.WriteLine(value);
                    //Console.WriteLine(r);
                    //Console.WriteLine(c);
                    //Console.WriteLine("-----------------");
                }
            }
                book.Dispose();
        }
    }
}
