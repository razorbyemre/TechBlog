﻿using BusinessLayer.Abstracts;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TechBlogUI.ViewComponents.Category
{
    public class CategoryListDashboard: ViewComponent
    {
        readonly ICategoryService cm;

        public CategoryListDashboard(ICategoryService cm)
        {
            this.cm = cm;
        }

        public IViewComponentResult Invoke()
        {
            var val = cm.GetList();

            return View(val);
        }
    }
}
