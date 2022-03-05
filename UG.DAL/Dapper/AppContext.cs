using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UG.DAL.Dapper
{
    public class AppContext : DbContext
    {
        public AppContext() { }
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    }
}
