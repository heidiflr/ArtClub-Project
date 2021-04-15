using DeepPurple.ApplicationLogic.Services;
using DeepPurple.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.Controllers
{
    public class ResourcesController : Controller
    {
        private readonly ResourceServices resourceServices; 

        public ResourcesController(ResourceServices resourceServices)
        {
            this.resourceServices = resourceServices;
        }
        public IActionResult Resources()
        {
            try
            {
                var resources = resourceServices.GetAll();
                return View(new GetAllResourcesViewModel
                {
                    Resources = resources
                });
            }
            catch (Exception)
            {
                return BadRequest("Invalid Request");
            }
            
        }

        [HttpGet]
        public IActionResult AddResource()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddResource([FromForm]AddResourceViewModel model)
        {
            resourceServices.AddResource(model.ResourceName, model.ResDescription, model.ResPrice);

            return View("Resources", "Resources");
        }
        [HttpGet]
        public IActionResult DeleteResource([FromRoute] Guid resourceId)
        {
            var deleteVM = new DeleteResourceViewModel { ResourceID = resourceId };

            return View(deleteVM);
        }

        [HttpPost]
        public IActionResult DeleteResource(DeleteResourceViewModel model)
        {
            resourceServices.DeleteResource(model.ResourceID);
            return Redirect(Url.Action("Resources", "Resources"));
        }
    }

}

