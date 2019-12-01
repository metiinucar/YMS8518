using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuestBook.data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace GuestBook.Controllers
{
    public class GuestBookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SendAction([FromBody]GuestBookSendActionDto guestBookSendActionDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(error: "Biz de zamanında yapardık.");
            }
            return new JsonResult("ok");
        }
    }
}