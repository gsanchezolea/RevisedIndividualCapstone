using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using oSport.ActionFilters;
using oSport.Data;
using oSport.Models;

namespace oSport.Controllers
{
    [Authorize(Roles = "League Admin")]
    public class LeagueAdminsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeagueAdminsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LeagueAdmins
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var dbUser = await _context.LeagueAdmins.SingleOrDefaultAsync(a => a.IdentityUserId == userId);

            var listOfLeagues = await _context.Leagues.Include(a => a.Sport).Where(a => a.LeagueAdminId == dbUser.Id).ToListAsync();
            ViewBag.Leagues = listOfLeagues;

            return View(dbUser);
        }

        // GET: LeagueAdmins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leagueAdmin = await _context.LeagueAdmins
                .Include(l => l.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leagueAdmin == null)
            {
                return NotFound();
            }

            return View(leagueAdmin);
        }

        // GET: LeagueAdmins/Create
        public IActionResult Create()
        {            
            var leagueAdmin = new LeagueAdmin();            
            return View(leagueAdmin);
        }

        // POST: LeagueAdmins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeagueAdmin leagueAdmin)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                leagueAdmin.IdentityUserId = userId;
                _context.Add(leagueAdmin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", leagueAdmin.IdentityUserId);
            return View(leagueAdmin);
        }

        // GET: LeagueAdmins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leagueAdmin = await _context.LeagueAdmins.FindAsync(id);
            if (leagueAdmin == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", leagueAdmin.IdentityUserId);
            return View(leagueAdmin);
        }

        // POST: LeagueAdmins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdentityUserId,FirstName,LastName,PhoneNumber")] LeagueAdmin leagueAdmin)
        {
            if (id != leagueAdmin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leagueAdmin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeagueAdminExists(leagueAdmin.Id))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", leagueAdmin.IdentityUserId);
            return View(leagueAdmin);
        }

        // GET: LeagueAdmins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leagueAdmin = await _context.LeagueAdmins
                .Include(l => l.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leagueAdmin == null)
            {
                return NotFound();
            }

            return View(leagueAdmin);
        }

        // POST: LeagueAdmins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leagueAdmin = await _context.LeagueAdmins.FindAsync(id);
            _context.LeagueAdmins.Remove(leagueAdmin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeagueAdminExists(int id)
        {
            return _context.LeagueAdmins.Any(e => e.Id == id);
        }
    }
}
