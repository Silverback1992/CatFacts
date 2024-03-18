using CatFacts.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFacts.Infrastructure.Data
{
    public class CatFactsDbContext : DbContext
    {
        public CatFactsDbContext(DbContextOptions<CatFactsDbContext> options) : base(options)
        {
            
        }

        public DbSet<CatFactWithPicture> CatFactWitchPictures { get; set; }
    }
}
