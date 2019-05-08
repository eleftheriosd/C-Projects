using Eshop_11_4.Data;
using Eshop_11_4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_11_4.ViewComponents
{
    public class DropdownRoomsViewComponent : ViewComponent
    {


        private readonly ApplicationDbContext _context;
        public DropdownRoomsViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {

            return View(_context.Rooms.ToList()

            );




        }


    }
}

