using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UNeedTickets.Models
{
    public class ApplicationUser: IdentityUser, IEnumerable
	{
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string AccountType { get; set; }

        [Required]
        public string Name { get; set; }

        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }

		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}

		
	}
}
