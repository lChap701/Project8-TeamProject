using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project8_GroupProject.Models
{
    /// <summary>
    /// Models for the Accounts table
    /// </summary>
    public class Accounts
    {
        /// <summary>
        /// Property for the AccID column
        /// </summary>
        [Key]
        public int AccID { get; set; }

        /// <summary>
        /// Property for the Username column in the Accounts table
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Property for the Email column in the Accounts table
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Property for the Password column in the Accounts table
        /// </summary>
        public string Password { get; set; }
    }
}
