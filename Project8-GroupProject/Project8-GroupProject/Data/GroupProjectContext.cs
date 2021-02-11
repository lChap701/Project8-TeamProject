using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project8_GroupProject.Models;

namespace Project8_GroupProject.Data
{
<<<<<<< HEAD
    /// <summary>
    /// Used to define the "context" for our database
    /// </summary>
=======
>>>>>>> 94f42e13dcdf0e1cb70e8e63e9ffb2c0f4e28038
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
