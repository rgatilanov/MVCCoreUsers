using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCoreUsers.Models;

namespace MVCCoreUsers.Data
{
    public class MVCCoreUsersContext : DbContext
    {
        public MVCCoreUsersContext (DbContextOptions<MVCCoreUsersContext> options)
            : base(options)
        {
        }

        public DbSet<MVCCoreUsers.Models.User> User { get; set; }
    }
}
