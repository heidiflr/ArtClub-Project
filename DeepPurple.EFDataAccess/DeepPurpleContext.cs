using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeepPurple.EFDataAccess;
using DeepPurple.ApplicationLogic.Data;

namespace DDeepPurple.EFDataAccess
{
    public class DeepPurpleContext : DbContext
    {
        public DeepPurpleContext(DbContextOptions<DeepPurpleContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Brandmark> Brandmarks { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Resource> Resource { get; set; }
        public DbSet<ResourceEvent> ResourceEvent { get; set; }
        public DbSet<AdminEvent> AdminEvent { get; set; }
        public DbSet<UserEvent> UserEvent { get; set; }
        public DbSet<UserCard> UserCard { get; set; }
        


    }
}
