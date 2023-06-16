using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication3.Entities;

namespace WebApplication3.DBcontexts
{
    public class MyDbcontext : DbContext
    {
        public DbSet<HangHoa> hangHoas { get; set; }
        public MyDbcontext(DbContextOptions options) : base(options)
        {
        }



    }
}
