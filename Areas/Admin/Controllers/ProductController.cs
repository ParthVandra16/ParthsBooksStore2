using Abp.Domain.Uow;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParthsBooksStore2.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        [Area("Admin")]
        public class CategoryController : Controller
        {
            private readonly IUnitOfWork _unitOfWork;
            // private IUnitOfWork _unitOfWork;

            public CategoryController(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public IActionResult Index()
            {
                return View();
            }
        }
    }
}
