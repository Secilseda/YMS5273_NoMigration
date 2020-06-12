using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YMS5273_NoMigration.Context;

namespace YMS5273_NoMigration.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ProjectContext _projectContext;
        public CategoryController(ProjectContext projectContext)
        {
            this._projectContext = projectContext;
        }
        public IActionResult Index()
        {
            return View(_projectContext.Categories.ToList());
        }
    }
}