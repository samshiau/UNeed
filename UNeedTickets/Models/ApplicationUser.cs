using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNeedTickets.Models
{
    public class ApplicationUser: IdentityUser
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

    }
}
