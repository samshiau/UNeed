using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Documents;
using Microsoft.EntityFrameworkCore;
using UNeedTickets.Data;
using UNeedTickets.Models;


namespace UNeedTickets.Controllers
{
	
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

		public IActionResult ShowUserAccounts()
		{
			List<IdentityUser> users= _db.Users.ToList();
            
            return View(users);	
		}

		public IActionResult Register() 
		{
			return View();
		}

		

		public IActionResult Index()
        {
			List<Tickets> objCategoryList = _db.Tickets.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create() 
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tickets obj) 
        {
            _db.Tickets.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

		public IActionResult Edit(int id)
		{
            Tickets? ticketFromDb= _db.Tickets.Find(id);
			return View(ticketFromDb);
		}

		public IActionResult Inspect(string id)
		{
			IdentityUser? user = _db.Users.Find(id);

			return View(user);

			//	var normalizedname = _db.Roles
			//		.Join
			//		(
			//			_db.UserRoles
			//			,r=> r.Id
			//			,ur =>ur.RoleId,
			//			(r, ur) => new { r.NormalizedName, ur.UserId }
			//		)
			//		.Where(joined => joined.UserId == id)
			//		.Select(joined => joined.NormalizedName)
			//		.ToList();

			//	var normalizedname = _db.Roles
			//		.Join(
			//			_db.UserRoles,
			//			role => role.Id,
			//			userRole => userRole.RoleId,
			//			(role, userRole) => new { Role = role, UserRole = userRole }
			//		)
			//	.Where(joined => joined.UserRole.UserId == id)
			//		.Select(joined => joined.Role.NormalizedName)
			//		.ToList();

			//string sqlQuery = "SELECT NormalizedName FROM UNeed.dbo.AspNetRoles " +
			//			  "JOIN UNeed.dbo.AspNetUserRoles ON dbo.AspNetUserRoles.RoleId = dbo.AspNetRoles.Id " +
			//			  "WHERE dbo.AspNetUserRoles.UserId = {0}";

			//List<string> normalizedname = _db.Roles.FromSqlRaw(sqlQuery, id).Select(role => role.NormalizedName).ToList();

			//InspectViewModel insViewModel = new InspectViewModel
			//{
			//	NormalizedName = normalizedname,
			//	UserName=user

			//};

			//return View(insViewModel);


			
		}

		[HttpPost]
		public IActionResult Edit(Tickets obj)
		{
			_db.Tickets.Update(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult Delete(int? id)
		{
			Tickets? categoryFromDb = _db.Tickets.Find(id);
			return View(categoryFromDb);
		}
		
		[HttpPost, ActionName("Delete")]
		public IActionResult DeletePOST(int? id)
		{
			Tickets? obj = _db.Tickets.Find(id);
			if (obj == null)
			{
				return NotFound();
			}

			_db.Tickets.Remove(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
