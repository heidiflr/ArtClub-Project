using DeepPurple.ApplicationLogic.Abstractions;
using DeepPurple.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepPurple.ApplicationLogic.Services
{
    public class ResourceServices
    {
        private IResourceRepository resourceRepository;

        public ResourceServices (IResourceRepository resourceRepository)
        {
            this.resourceRepository = resourceRepository;
        }

        public IEnumerable<Resource> GetAll()
        {
            return resourceRepository.GetAll();
        }

        public void AddResource(string ResourceName, string ResDescription, int ResPrice)
        {
            resourceRepository.Add(new Resource
            {
                ResourceID = Guid.NewGuid(),
                ResourceName = ResourceName,
                ResDescription = ResDescription,
                ResPrice = ResPrice
            });
        }
    }
}
