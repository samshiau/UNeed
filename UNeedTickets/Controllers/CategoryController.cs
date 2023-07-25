using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
