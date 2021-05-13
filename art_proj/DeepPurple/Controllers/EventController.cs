using Microsoft.AspNetCore.Mvc;
using DeepPurple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeepPurple.ApplicationLogic.Services;
using DeepPurple.ApplicationLogic.Abstractions;

namespace DeepPurple.Controllers
{
    public class EventController : Controller
    {
        private readonly EventServices eventServices;

        public EventController(EventServices eventServices)
        {
            this.eventServices = eventServices;
        }

        public IActionResult Event()
        {
            try
            {
                var events = eventServices.GetAll();
                return View(new GetAllEventsViewModel { Event = events });
            }
            catch(Exception)
            {
                return BadRequest("Invalid Request");
            }
        }

        [HttpGet]
        public IActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEvent([FromForm]AddEventViewModel model)
        {
            eventServices.AddEvent(model.EventName, model.EventDescription);
            return RedirectToAction("Event");
        }


    }
}