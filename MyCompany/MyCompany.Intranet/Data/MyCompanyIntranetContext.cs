using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany.Intranet.Models.Warehouse;

namespace MyCompany.Intranet.Data
{
    public class MyCompanyIntranetContext : DbContext
    {
        public MyCompanyIntranetContext (DbContextOptions<MyCompanyIntranetContext> options)
            : base(options)
        {
        }

        public DbSet<Warehouse> Warehouse { get; set; } = default!;
    }
}
