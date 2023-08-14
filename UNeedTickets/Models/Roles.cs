using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNeedTickets.Models
{
	[NotMapped]
	public class Roles: IdentityRole
	{
       // public string Id { get; set; }
      //  public string Name { get; set; }
    }
}
