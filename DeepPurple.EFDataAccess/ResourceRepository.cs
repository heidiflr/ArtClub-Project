using DDeepPurple.EFDataAccess;
using DeepPurple.ApplicationLogic.Abstractions;
using DeepPurple.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepPurple.EFDataAccess
{
    public class ResourceRepository : BaseRepository<Resource>, IResourceRepository
    {
        public ResourceRepository(DeepPurpleContext dbContext) : base(dbContext)
        {

        }


    }
}
