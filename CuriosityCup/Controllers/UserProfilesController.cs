﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CuriosityCup.Data;
using CuriosityCup.Models;

namespace CuriosityCup.Controllers
{
    public class UserProfilesController : Controller
    {
        //private readonly ApplicationDbContext _context;

        //public UserProfilesController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //// GET: UserProfiles
        //public async Task<IActionResult> Index()
        //{
        //    var applicationDbContext = _context.UserProfiles.Include(u => u.User);
        //    return View(await applicationDbContext.ToListAsync());
        //}

        //// GET: UserProfiles/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var userProfile = await _context.UserProfiles
        //        .Include(u => u.User)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (userProfile == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(userProfile);
        //}

        //// GET: UserProfiles/Create
        //public IActionResult Create()
        //{
        //    ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
        //    return View();
        //}

        //// POST: UserProfiles/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,UserPicture,UserId,Phone,FName,LName,DOB,Country,Bio")] UserProfile userProfile)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(userProfile);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userProfile.UserId);
        //    return View(userProfile);
        //}

        //// GET: UserProfiles/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var userProfile = await _context.UserProfiles.FindAsync(id);
        //    if (userProfile == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userProfile.UserId);
        //    return View(userProfile);
        //}

        //// POST: UserProfiles/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,UserPicture,UserId,Phone,FName,LName,DOB,Country,Bio")] UserProfile userProfile)
        //{
        //    if (id != userProfile.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(userProfile);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!UserProfileExists(userProfile.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userProfile.UserId);
        //    return View(userProfile);
        //}

        //// GET: UserProfiles/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var userProfile = await _context.UserProfiles
        //        .Include(u => u.User)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (userProfile == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(userProfile);
        //}

        //// POST: UserProfiles/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var userProfile = await _context.UserProfiles.FindAsync(id);
        //    _context.UserProfiles.Remove(userProfile);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool UserProfileExists(int id)
        //{
        //    return _context.UserProfiles.Any(e => e.Id == id);
        //}
    }
}
