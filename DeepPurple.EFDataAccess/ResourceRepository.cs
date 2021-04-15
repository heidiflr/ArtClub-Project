using DDeepPurple.EFDataAccess;
using DeepPurple.ApplicationLogic.Abstractions;
using DeepPurple.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepPurple.EFDataAccess
{
    public class ResourceRepository : BaseRepository<Resource>, IResourceRepository
    {
        public ResourceRepository(DeepPurpleContext dbContext) : base(dbContext)
        {

        }

        public Resource GetResourceById(Guid resourceID)
        {
            var oneResource = dbContext.Resource.Where(p => p.ResourceID == resourceID).SingleOrDefault();
            return oneResource;
        }
    }
}
