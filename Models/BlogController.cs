using BlogPostApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BlogPostApp.Controllers
{
    public class BlogController : Controller
    {
        private static readonly List<Post> _posts = new List<Post>
        {
            new Post { Id = 1, Title = "First Post", Content = "This is the first blog post.", Author = "Ace" },
            new Post { Id = 2, Title = "Second Post", Content = "This is the second blog post.", Author = "Ace" },
            new Post { Id = 3, Title = "Third Post", Content = "This is the third blog post.", Author = "Ace" }
        };

        public IActionResult Index()
        {
            return View(_posts);
        }

        public IActionResult Details(int id)
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }
    }
}