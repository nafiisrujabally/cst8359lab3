using Microsoft.AspNetCore.Mvc;
using Workshop_RSVP.Models;

namespace Workshop_RSVP.Controllers
{
    public class WorkshopsController : Controller
    {
        // In-memory list
        private static List<Rsvp> registrations = new List<Rsvp>();

        // GET: /Workshops
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Workshops/RsvpForm
        public IActionResult RsvpForm()
        {
            return View();
        }

        // POST: /Workshops/Confirm
        [HttpPost]
        public IActionResult Confirm(Rsvp model)
        {
            registrations.Add(model);

            ViewData["Message"] = $"Thanks for registering, {model.FullName}!";

            return View(model);
        }

        // GET: /Workshops/Registrations
        public IActionResult Registrations()
        {
            return View(registrations);
        }
    }
}