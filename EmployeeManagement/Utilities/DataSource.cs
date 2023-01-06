using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Utilities
{
    public class DataSource
    {
        public static object[] InvalidLoginData()
        {


            string[] dataSet1 = new string[3];
            dataSet1[0] = "john";
            dataSet1[1] = "john123";
            dataSet1[2] = "Invalid credentials";

            string[] dataSet2 = new string[3];
            dataSet2[0] = "peter";
            dataSet2[1] = "peter123";
            dataSet2[2] = "Invalid credentials";


            string[] dataSet3 = new string[3];
            dataSet3[0] = "saul";
            dataSet3[1] = "saul123";
            dataSet3[2] = "Invalid credentials";


            object[] allDataSet = new object[3];//number of test case
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            allDataSet[2] = dataSet3;
            //allDataSet[2] = dataSet3;
            return allDataSet;



        }
        public static object[] AddEmployeeTestData()
        {
            string[] dataset1= new string[6];
            dataset1[0] = "Admin";
            dataset1[1] = "admin123";
            dataset1[2] = "john";
            dataset1[3] = "w";
            dataset1[4] = "weak";
            dataset1[5] = "john weak";

            string[] dataset2 = new string[6];
            dataset2[0] = "Admin";
            dataset2[1] = "admin123";
            dataset2[2] = "saul";
            dataset2[3] = "g";
            dataset2[4] = "goodman";
            dataset2[5] = "saul goodman";

            object[] allDataSets= new object[2];
            allDataSets[0] = dataset1;
            allDataSets[1] = dataset2;

            return allDataSets;


        }
        public static object[] InvalidLoginData2()
        {
            object[] data = ExcelUtils.GetSheetIntObjectArray(@"C:\Users\shitalc\Desktop\C#_2022\AutomationFramework\EmployeeManagement\TestData\Orange_data.xlsx", "InvalidLoginTest");
            return data;
        }
        



    }
}
