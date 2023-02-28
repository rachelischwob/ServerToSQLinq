using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services
{
    public interface IFiles
    {
       List<Person> readFromExelFile(IFormFile excel);
       List<Person> CheckValidExcel(List<Person> p);
    }
}
