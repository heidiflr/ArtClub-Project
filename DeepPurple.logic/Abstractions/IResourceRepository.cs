using DeepPurple.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepPurple.ApplicationLogic.Abstractions
{
    public interface IResourceRepository : IRepository<Resource>
    {
        
        public Resource GetResourceById(Guid resourceID);
    }
    
}
