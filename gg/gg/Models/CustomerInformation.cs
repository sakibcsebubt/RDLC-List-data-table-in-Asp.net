
using gg.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gg.Data
{
    public class CustomerInformation: DbContext
    {
        public CustomerInformation(DbContextOptions<CustomerInformation> options) : base(options)
        {

        }
        //public DbSet<CInfo> CustomerAcounts { get; set; }
    }
}
