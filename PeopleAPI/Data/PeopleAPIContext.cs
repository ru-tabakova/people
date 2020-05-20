using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeopleAPI.Model;

namespace PeopleAPI.Data
{
    public class PeopleAPIContext : DbContext
    {
        public PeopleAPIContext (DbContextOptions<PeopleAPIContext> options)
            : base(options)
        {
        }

        public DbSet<PeopleAPI.Model.Person> People { get; set; }
    }
}
