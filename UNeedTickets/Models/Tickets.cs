using System.ComponentModel.DataAnnotations;

namespace UNeedTickets.Models
{
	public class Tickets
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Summary { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public string Status { get; set; }

		[Required]
		public bool ResolvedorNot { get; set; }

		[Required]
		public string Severity { get; set; }

		[Required]
		public string Priority { get; set; }


	}
}
