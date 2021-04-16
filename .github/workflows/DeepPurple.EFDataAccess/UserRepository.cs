using DDeepPurple.EFDataAccess;
using DeepPurple.ApplicationLogic.Abstractions;
using DeepPurple.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepPurple.EFDataAccess
{
    public class UserRepository : BaseRepository<Users>, IUserRepository
    {
        public UserRepository(DeepPurpleContext dbContext) : base(dbContext)
        {

        }


    }
}
