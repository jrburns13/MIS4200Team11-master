using MIS4200Team11.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MIS4200Team11.DAL
{
    public class Team11Context : DbContext
    {
        public Team11Context()  :   base("name=DefaultConnection")
        {

        }
        public DbSet<Profile> profile { get; set; }
        public DbSet<Recognition> recognition { get; set; }
    }
}