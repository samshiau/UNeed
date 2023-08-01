using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UNeedTickets.Models
{
    public class UserRoles: IdentityUserRole<string>
	{
        //[Key]
       // public int Id { get; set; }
      //  public string UserId { get; set; }
      //  public string RoleId { get; set; }
      //  public string test {get; set; }
    }
}
