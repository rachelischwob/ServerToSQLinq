using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Services
{
    public class Files : IFiles
    {
        public UsingApi APIserver;

        //swagger ExcelPackage  הערה: בהתחלה קיבלתי מה 
        //וממנו חילצתי נתונים וכו 
        //ניתקע post רק כשה  
        // IfromFile ראיתי שצריך לקבל 
        // IfromFile to ExcelPackage וכבר לא היה לי זמן לחפש איך ממירים מ 
        public List<Person> readFromExelFile(ExcelPackage excel)
        {
           //
            ExcelWorksheet worksheet = excel.Workbook.Worksheets[1]; 
            List<Person> result = new List<Person>();
            Person p;
            for (int i = 2; i <= worksheet.Dimension.End.Row; i++)
            {
                var row = worksheet.Cells[i, 1, i, worksheet.Dimension.End.Column];
                p=new Person();
                p.Name = worksheet.Cells[i, 1].Text +" "+ worksheet.Cells[i,2].Text;
                p.TZ= worksheet.Cells[i,3].Text;
                //p.Age = worksheet.Cells[i, 4].Value; צריךלהמיר את המחרזת  לשנה

              result.Add(p);
            }
            return result;
        }
        public List<Person> CheckValidExcel(List<Person> people)
        {
           List<Person> result = new List<Person>();
         foreach(Person person in people)
            {
                if (IsValid(person.TZ))
                {
                    person.IsValid=true;
                    result.Add(APIserver.AddId(person));
                }
                else
                {
                    person.IsValid=false;
                    result.Add(person);
                }
            }
            return result;
        }

        private bool IsValid(string TZ)
        {
            if(TZ.Count()!=9)
                return false;
            return true;
        }
    }
}
