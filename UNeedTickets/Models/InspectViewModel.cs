using Microsoft.AspNetCore.Identity;

namespace UNeedTickets.Models
{
    public class InspectViewModel
    {
		//public string UserId { get; set; }
		public IdentityUser UserName { get; set; }
		public List<string> NormalizedName { get; set; }


	}
}
