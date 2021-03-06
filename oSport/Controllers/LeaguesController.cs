﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using oSport.Data;
using oSport.Models;

namespace oSport.Controllers
{
    public class LeaguesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeaguesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Leagues
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Leagues.Include(l => l.LeagueAdmin).Include(l => l.Sport);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Leagues/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var league = await _context.Leagues
                .Include(l => l.LeagueAdmin)
                .Include(l => l.Sport)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (league == null)
            {
                return NotFound();
            }

            return View(league);
        }

        // GET: Leagues/Create
        public IActionResult Create()
        {
            var league = new League();
            var sports = _context.Sports.ToList();
            ViewBag.Sport = new SelectList(sports, "Id", "Name");
            return View(league);
        }

        // POST: Leagues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(League league)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var adminId = _context.LeagueAdmins.SingleOrDefault(a => a.IdentityUserId == userId).Id;
                league.LeagueAdminId = adminId;
                _context.Add(league);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "LeagueAdmins");
            }
            ViewData["LeagueAdminId"] = new SelectList(_context.LeagueAdmins, "Id", "FirstName", league.LeagueAdminId);
            ViewData["SportId"] = new SelectList(_context.Sports, "Id", "Name", league.SportId);
            return View(league);
        }

        // GET: Leagues/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var league = await _context.Leagues.FindAsync(id);
            if (league == null)
            {
                return NotFound();
            }
            ViewData["LeagueAdminId"] = new SelectList(_context.LeagueAdmins, "Id", "FirstName", league.LeagueAdminId);
            ViewData["SportId"] = new SelectList(_context.Sports, "Id", "Name", league.SportId);
            return View(league);
        }

        // POST: Leagues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LeagueAdminId,SportId,LeagueName,TeamCapacity")] League league)
        {
            if (id != league.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(league);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeagueExists(league.Id))
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
            ViewData["LeagueAdminId"] = new SelectList(_context.LeagueAdmins, "Id", "FirstName", league.LeagueAdminId);
            ViewData["SportId"] = new SelectList(_context.Sports, "Id", "Name", league.SportId);
            return View(league);
        }

        // GET: Leagues/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var league = await _context.Leagues
                .Include(l => l.LeagueAdmin)
                .Include(l => l.Sport)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (league == null)
            {
                return NotFound();
            }

            return View(league);
        }

        // POST: Leagues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var league = await _context.Leagues.FindAsync(id);
            _context.Leagues.Remove(league);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeagueExists(int id)
        {
            return _context.Leagues.Any(e => e.Id == id);
        }
    }
}
