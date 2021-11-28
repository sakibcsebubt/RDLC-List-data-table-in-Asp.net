using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gg.Models
{
    public class BEPZACLASS
    {


        public int Sl { get; set; }
        public string Details { get; set; }
        public int DTaka { get; set; }
        public string DType   { get; set; }
        public string PCondition   { get; set; }
        public string LawNo   { get; set; }


        public List<BEPZACLASS> ReportData()
        {
            var datalist = new List<BEPZACLASS>();
            datalist.Add(new BEPZACLASS() { Sl = 1, Details = "Comilla Zone", DTaka = 7000, DType = "Started", LawNo = "Serial-6 v sladsfapjaldsf ladfslafl", PCondition = "No Status" });
            datalist.Add(new BEPZACLASS() { Sl = 2, Details = "Comilla Zone", DTaka = 7000, DType = "Started", LawNo = "Serial-6 v sladsfapjaldsf ladfslafl", PCondition = "Completed" });
            datalist.Add(new BEPZACLASS() { Sl = 3, Details = "Comilla Zone", DTaka = 7000, DType = "Started", LawNo = "Serial-6 v sladsfapjaldsf ladfslafl", PCondition = "No Status" });
            datalist.Add(new BEPZACLASS() { Sl = 4, Details = "Comilla Zone", DTaka = 7000, DType = "Started", LawNo = "Serial-6 v sladsfapjaldsf ladfslafl", PCondition = "No Status" });
            datalist.Add(new BEPZACLASS() { Sl = 5, Details = "Dhaka", DTaka = 5000, DType = "Started", LawNo = "Serial-6 v sladsSDADFAfapjaldsf ladfslafl", PCondition = "Completed" });
            datalist.Add(new BEPZACLASS() { Sl = 6, Details = "Dhaka", DTaka = 5000, DType = "Started", LawNo = "Serial-6 v sladsSDADFAfapjaldsf ladfslafl", PCondition = "No Status" });
            datalist.Add(new BEPZACLASS() { Sl = 7, Details = "Dhaka", DTaka = 5000, DType = "Started", LawNo = "Serial-6 v sladsSDADFAfapjaldsf ladfslafl", PCondition = "Completed" });
            datalist.Add(new BEPZACLASS() { Sl = 8, Details = "Dhaka", DTaka = 5000, DType = "Started", LawNo = "Serial-6 v sladsSDADFAfapjaldsf ladfslafl", PCondition = "Not Completed" });
           
           
            datalist.Add(new BEPZACLASS() { Sl = 9, Details = "Comilla Zone", DTaka = 7000, DType = "Started", LawNo = "Serial-6 v sladsfapjaldsf ladfslafl", PCondition = "No Status" });
            datalist.Add(new BEPZACLASS() { Sl = 10, Details = "BanghuBOndhu Hi-Tech Park , Kaliakoir Gazipur. ", DTaka = 8000, DType = "Started", LawNo = "Serial-121", PCondition = "No Status" });
            datalist.Add(new BEPZACLASS() { Sl = 11, Details = "BanghuBOndhu Hi-Tech Park , Kaliakoir Gazipur. ", DTaka = 8000, DType = "Started", LawNo = "Serial-121", PCondition = "Completed" });
            datalist.Add(new BEPZACLASS() { Sl = 12, Details = "BanghuBOndhu Hi-Tech Park , Kaliakoir Gazipur. ", DTaka = 8000, DType = "Started", LawNo = "Serial-121", PCondition = "Not Completed" });
            datalist.Add(new BEPZACLASS() { Sl = 13, Details = "BanghuBOndhu Hi-Tech Park , Kaliakoir Gazipur. ", DTaka = 8000, DType = "Started", LawNo = "Serial-121", PCondition = "Not Completed" });
            datalist.Add(new BEPZACLASS() { Sl = 14, Details = "BanghuBOndhu Hi-Tech Park , Kaliakoir Gazipur. ", DTaka = 8000, DType = "Started", LawNo = "Serial-121", PCondition = "Not Completed" });
            datalist.Add(new BEPZACLASS() { Sl = 15, Details = "BanghuBOndhu Hi-Tech Park , Kaliakoir Gazipur. ", DTaka = 8000, DType = "Started", LawNo = "Serial-121", PCondition = "Not Completed" });
            datalist.Add(new BEPZACLASS() { Sl = 16, Details = "BanghuBOndhu Hi-Tech Park , Kaliakoir Gazipur. ", DTaka = 8000, DType = "Started", LawNo = "Serial-121", PCondition = "Not Completed" });
            datalist.Add(new BEPZACLASS() { Sl = 17, Details = "BanghuBOndhu Hi-Tech Park , Kaliakoir Gazipur. ", DTaka = 8000, DType = "Started", LawNo = "Serial-121", PCondition = "Not Completed" });
            
            datalist.Add(new BEPZACLASS() { Sl = 18, Details = "BanghuBOndhu Hi-Tech Park , Kaliakoir Gazipur. ", DTaka = 8000, DType = "Started", LawNo = "Serial-121", PCondition = "Not Completed" });
          
            datalist.Add(new BEPZACLASS() { Sl = 19, Details = "BanghuBOndhu Hi-Tech Park , Kaliakoir Gazipur. ", DTaka = 5000, DType = "Started", LawNo = "Serial-121", PCondition = "Not Commpleted" });
            datalist.Add(new BEPZACLASS() { Sl = 20, Details = "BanghuBOndhu Hi-Tech Park , Kaliakoir Gazipur. ", DTaka = 1452, DType = "Not Started ", LawNo = "Hospitality ", PCondition = "No Status" });
            return datalist;
           
        }
    }
}
