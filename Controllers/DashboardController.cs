using apbdtask10_v2.Data;
using apbdtask10_v2.DTOs;
using apbdtask10_v2.Models;
using apbdtask10_v2.Service;
using apbdtask10_v2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace apbdtask10_v2.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {

        private readonly IUserNoteService _noteService;
        private readonly IAppUserService _userService;
        public DashboardController(IUserNoteService noteService, IAppUserService userService)
        {
            _noteService = noteService;
            _userService = userService;
        }

        public async Task<IActionResult> Home()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var notes = await _noteService.GetAllUserNotes(userId!);

            return View(notes);
        }

        public IActionResult NewNote()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewNote(AddNoteViewModel model)
        {
            if (ModelState.IsValid)
            {

                UserNote note = new UserNote();
                note.Title = model.Title;
                note.Content = model.Content;
                note.CreatedAt = DateTime.Now;
                note.AppUserId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

                await _noteService.AddNote(note);
                return RedirectToAction("Home", "Dashboard");
            }
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Admin()
        {
            var users = await _userService.GetAppUsers();

            return View(users);
        }
    }
}
