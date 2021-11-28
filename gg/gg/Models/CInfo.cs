using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gg.Models
{
    public class CInfo
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public int AcountNo { get; set; }
        public int CAge { get; set; }
        public string CAddress { get; set; }
        public string CNominee { get; set; }
        public string Password { get; set; }




        public List<CInfo> CustomerInfo()
        {
            var ata = new List<CInfo>();
            ata.Add(new CInfo() { Id = 1, AcountNo = 0150, CAddress = "Dhaka", CAge = 15, CName = "Shakib", CNominee = "O", Password = "12345" });
            ata.Add(new CInfo() { Id = 1, AcountNo = 0150, CAddress = "Dhaka", CAge = 15, CName = "Shakib", CNominee = "O", Password = "12345" });
           ata.Add(new CInfo() { Id = 1, AcountNo = 0150, CAddress = "Dhaka", CAge = 15, CName = "Shakib", CNominee = "O", Password = "12345" });
            ata.Add(new CInfo() { Id = 1, AcountNo = 0150, CAddress = "Dhaka", CAge = 15, CName = "Shakib", CNominee = "O", Password = "12345" });
            ata.Add(new CInfo() { Id = 1, AcountNo = 0150, CAddress = "Dhaka", CAge = 15, CName = "Shakib", CNominee = "O", Password = "12345" });
            ata.Add(new CInfo() { Id = 1, AcountNo = 0150, CAddress = "Dhaka", CAge = 15, CName = "Shakib", CNominee = "O", Password = "12345" });
            ata.Add(new CInfo() { Id = 1, AcountNo = 0150, CAddress = "Dhaka", CAge = 15, CName = "Shakib", CNominee = "O", Password = "12345" });
            ata.Add(new CInfo() { Id = 1, AcountNo = 0150, CAddress = "Dhaka", CAge = 15, CName = "Shakib", CNominee = "O", Password = "12345" });
            ata.Add(new CInfo() { Id = 1, AcountNo = 0150, CAddress = "Dhaka", CAge = 15, CName = "Shakib", CNominee = "O", Password = "12345" });
            ata.Add(new CInfo() { Id = 1, AcountNo = 0150, CAddress = "Dhaka", CAge = 15, CName = "Shakib", CNominee = "O", Password = "12345" });
      
            return ata;
        }
    }
}
