using AspNetCore.Reporting;
using gg.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace gg.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Print()
        {
            var dt = new DataTable();
            dt = GetCustomerInformation();

            string mimtype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\Report1.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("prm", "RDLC REPORT");
            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("DataSet1", dt);


            var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimtype);
            return File(result.MainStream, "application/pdf"); 

            
        }

        public DataTable GetCustomerInformation()
        {
            var dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("CustName");
            dt.Columns.Add("AccountNo");
            dt.Columns.Add("Balance");

            DataRow row;
            for(int i=100; i <= 120; i++)
            {
                row = dt.NewRow();
                row["id"] = i;
                row["CustName"] = "Mr. Sakib " +i ;
                row["AccountNo"] = 10;
                row["Balance"] = 987;

                dt.Rows.Add(row);



            }
            return dt;

        }
    }
}
