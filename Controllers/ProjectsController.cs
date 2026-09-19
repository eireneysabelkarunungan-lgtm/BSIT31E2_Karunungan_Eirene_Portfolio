using Microsoft.AspNetCore.Mvc;
using BSIT31E2_Karunungan_Eirene_Portfolio.Models;

namespace BSIT31E2_Karunungan_Eirene_Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }
            return View(ProjectData.All.OrderBy(p => p.Id).ToList());
        }


        public IActionResult Details(int id)
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }
            var project = ProjectData.All.FirstOrDefault(p => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            ViewBag.Comments = CommentStore.ForProject(id);
            return View(project);
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

        [HttpPost]
        public IActionResult AddComment(int projectId, string author, string text)
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }
            if (!string.IsNullOrWhiteSpace(author) && !string.IsNullOrWhiteSpace(text))
            {
                CommentStore.All.Add(new Comment
                {
                    ProjectId = projectId,
                    Author = author.Trim(),
                    Text = text.Trim()
                });
            }
            return RedirectToAction("Details", new { id = projectId });
        }
    }
}