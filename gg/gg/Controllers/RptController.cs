using AspNetCore.Reporting;
using gg.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gg.Controllers
{
    public class RptController : Controller
    {

        private readonly IWebHostEnvironment _webHostEnvironment;

        public RptController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
           
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Print()
        {


            string mimtype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\DBCon.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("prm", "RDLC REPORT");
            LocalReport localReport = new LocalReport(path);
            CInfo nfo = new CInfo();
            localReport.AddDataSource("DataSet1", nfo.CustomerInfo());


            var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimtype);
            return File(result.MainStream, "application/pdf");


        }
        public IActionResult BEPPrint()
        {
            string mimtype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\BEPZA.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("params", "BEPZA TEST REPORT");
            LocalReport localReport = new LocalReport(path);
            BEPZACLASS BN = new BEPZACLASS();
            localReport.AddDataSource("BEPZAREPORT", BN.ReportData());
            var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimtype);
            return File(result.MainStream, "application/pdf");

        }


        public IActionResult NewMO()
        {
            string mimtype = "";
            int extention = 1;
            CInfo fo = new CInfo();

            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\DBCon.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("prm", "RDLC Report");
            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("DataSet1", fo.CustomerInfo());
            var res = localReport.Execute(RenderType.Pdf, extention, parameters, mimtype);
            return File(res.MainStream, "application/Pdf");

        }

    }
}
