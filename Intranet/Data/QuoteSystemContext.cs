using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AcsIntranet.Data
{
    public class QuoteSystemContext : DbContext
    {
        public DbSet<QuoteSystem.BlockModel> Blocks { get; set; }

        public QuoteSystemContext(DbContextOptions<QuoteSystemContext> options) : base(options) { }


    }
}
