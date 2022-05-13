using ACCEPTED.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACCEPTED.Data
{
    public class AcceptedContext:DbContext
    {
        public AcceptedContext(DbContextOptions options) : base(options) { }

        public DbSet<Match> Match {get; set; }
        public DbSet<MatchOdds> MatchOdds { get; set; }
    }
}
