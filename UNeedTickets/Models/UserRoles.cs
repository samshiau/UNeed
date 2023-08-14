using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNeedTickets.Models
{
	[NotMapped]
	public class UserRoles: IdentityUserRole<string>
	{
        
    }
}
