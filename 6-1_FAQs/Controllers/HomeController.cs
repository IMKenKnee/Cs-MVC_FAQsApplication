// Kenny Hedlund
// Chapter 6 FAQ App
// COP.4813
// Handles logic for the home page

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _6_1_FAQs.Data;
using _6_1_FAQs.Models;

namespace _6_1_FAQs.Controllers
{
    public class HomeController : Controller
    {
        private readonly FaqContext _context;

        // Injects database context
        public HomeController(FaqContext context)
        {
            _context = context;
        }

        // Displays FAQs and filters
        public IActionResult Index(string topic = null, string category = null)
        {
            // Queried objects
            IQueryable<FAQ> faqs = _context.FAQs
                                           .Include(f => f.Topic)
                                           .Include(f => f.Category);

            // Apply topic filtering if necessary
            if (!string.IsNullOrEmpty(topic))
            {
                faqs = faqs.Where(f => f.TopicId == topic);
            }

            // Logic for applying filters
            if (!string.IsNullOrEmpty(category))
            {
                faqs = faqs.Where(f => f.CategoryId == category);
            }

            // Pass filtered FAQs to view
            ViewBag.Topics = _context.Topics.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View(faqs.ToList());
        }
    }
}


