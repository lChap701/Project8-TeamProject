using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project8_GroupProject.Models;

namespace Project8_GroupProject.Data
{
    public class GroupProjectContext : DbContext
    {
        public GroupProjectContext(DbContextOptions<GroupProjectContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Represents the Accounts table 
        /// </summary>
        public DbSet<Accounts> Accounts { get; set; }
    }
}
