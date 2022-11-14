﻿//using Abp.Domain.Uow;

//using Abp.Domain.Uow;
using Microsoft.AspNetCore.Mvc;
using ParthsBooks.DataAccess.Repository.IRepository;

using ParthsBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ParthsBooksStore2.Areas.Admin.Controllers
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

        public IActionResult Upsert(int? id)   // action method for upsert
        {
            Category category = new Category();  // using ParthsBooks.Models
            if(id ==null)
            {
                // this is for create
                return View(category);
            }
            //this is for edit
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if(category == null)
            {
                return NotFound();
            }
            return View();
        }

        // API calls here
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            // return not found
            var allObj = _unitOfWork.Category.GetALL();
            return Json(new { data = allObj });
        }
        #endregion
    }
}
