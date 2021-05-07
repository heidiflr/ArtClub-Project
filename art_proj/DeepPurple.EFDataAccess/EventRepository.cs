using DDeepPurple.EFDataAccess;
using DeepPurple.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;
using DeepPurple.ApplicationLogic.Abstractions;

namespace DeepPurple.EFDataAccess
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(DeepPurpleContext dbContext) : base(dbContext)
        {

        }
    }
}
