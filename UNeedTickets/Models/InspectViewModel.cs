using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNeedTickets.Models
{
	[NotMapped]
	public class InspectViewModel
    {
		//public string UserId { get; set; }
		public IdentityUser UserName { get; set; }
		public List<string> NormalizedName { get; set; }


	}
}
