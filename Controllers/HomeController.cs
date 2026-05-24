using Microsoft.AspNetCore.Mvc;
using SpendSmart.Models;
using System.Diagnostics;

namespace SpendSmart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;



        private readonly SpendSmartDbContext _context;

        public HomeController(ILogger<HomeController> logger,  SpendSmartDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expenses()
        {
            var expenses = _context.Expenses.ToList();
            return View(expenses);
        }

        public IActionResult CreateEditExpense(int? id)
        {
            if (id != null && id > 0)
            {
                var expenseInDb = _context.Expenses.SingleOrDefault(x => x.Id == id);
                if (expenseInDb != null)
                {
                    return View(expenseInDb);
                }
            }
            return View(new Expense());
        }

        [HttpPost]
        public IActionResult CreateEditExpenseForm(Expense model)
        {
            if (model.Id == 0)
            {
                _context.Expenses.Add(model);
            }
            else
            {
                var expenseInDb = _context.Expenses.SingleOrDefault(x => x.Id == model.Id);
                if (expenseInDb != null)
                {
                    expenseInDb.Value = model.Value;
                    expenseInDb.Description = model.Description;
                }
            }
            _context.SaveChanges();
            return RedirectToAction("Expenses");
        }

        public IActionResult DeleteExpense(int id)
        {
            var expenseInDb = _context.Expenses.SingleOrDefault(x => x.Id == id);
            if (expenseInDb != null)
            {
                _context.Expenses.Remove(expenseInDb);
                _context.SaveChanges();
            }
            return RedirectToAction("Expenses");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
