using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project8_GroupProject.Models;

namespace Project8_GroupProject.Data
{

    /// <summary>
    /// Used to define the "context" for our database
    /// </summary>
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
		
		// Add a property for the Courses model here
    }
}
