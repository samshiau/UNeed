// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNeedTickets.Models
{
	public class ApplicationUser : IdentityUser //IEnumerable<ApplicationUser>
	{
		//List<ApplicationUser> AppUsers { get; }

		[PersonalData]
		[Column(TypeName = "nvarchar(100)")]
		public string AccountType { get; set; }

		[Required]
		public string Name { get; set; }

		public string? StreetAddress { get; set; }
		public string? City { get; set; }
		public string? State { get; set; }
		public string? PostalCode { get; set; }

		//public IEnumerator<ApplicationUser> GetEnumerator()
	//	{
	//		return AppUsers.GetEnumerator();
	//	}

		//IEnumerator IEnumerable.GetEnumerator()
	//	{
	//		return GetEnumerator();
	//	}
	}
}
