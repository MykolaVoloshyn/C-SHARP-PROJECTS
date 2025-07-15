using CarInsurance.Data;
using CarInsurance.Models;
using CarInsurance.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly CarInsuranceContext _context;

        public InsureesController(CarInsuranceContext context)
        {
            _context = context;
        }

        // GET: Insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        // GET: Insurees/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarMake,CarModel,CarYear,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Id = Guid.NewGuid();
                insuree.Quote = CalculateQuote(insuree);
                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarMake,CarModel,CarYear,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    insuree.Quote = CalculateQuote(insuree); // calculates a client's insurance quote
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree != null)
            {
                _context.Insurees.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(Guid id)
        {
            return _context.Insurees.Any(e => e.Id == id);
        }

        // GET: Insurees
        public async Task<IActionResult> Admin()
        {
            var insurees = await _context.Insurees.ToListAsync();

            // Loops through each Insuree object in insurees list and
            // creates a new InsureesAdminPageVm object from it
            var adminPageInsurees = insurees.Select(x => new InsureesAdminPageVm
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                EmailAddress = x.EmailAddress,
                Quote = x.Quote
            });

            return View(adminPageInsurees);
        }




        private decimal CalculateQuote(Insuree insuree)
        {
            decimal quote = 50m;

            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            DateOnly dob = insuree.DateOfBirth;
            int insureeAge = DateTime.Now.Year - dob.Year;

            if (dob > today.AddYears(-insureeAge)) insureeAge--;

            if (insureeAge <= 18) quote += 100;
            else if (insureeAge >= 26) quote += 25;
            else quote += 50;

            if (insuree.CarYear < 2000 || insuree.CarYear > 2015) quote += 25;

            if (string.Equals(insuree.CarMake, "Porsche", StringComparison.OrdinalIgnoreCase))
            {
                if (string.Equals(insuree.CarModel, "911 Carrera", StringComparison.OrdinalIgnoreCase)) quote += 25;

                quote += 25;
            }

            if (insuree.SpeedingTickets > 0) quote += insuree.SpeedingTickets * 10;

            if (insuree.DUI)
                quote *= 1.25m;

            if (string.Equals(insuree.CoverageType, "Full coverage", StringComparison.OrdinalIgnoreCase))
                quote *= 1.5m;

            return quote;
        }
    }
}
