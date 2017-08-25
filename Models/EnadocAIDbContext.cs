using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EnadocAI.Models
{
    public class EnadocAIDbContext : DbContext
    {
        public EnadocAIDbContext() : base("EnadocAIConnectionString")
        {

        }
        public DbSet<DocumentDetail> DocumentDetails { get; set; }
        public DbSet <DocumentCount>  DocumentCounts { get; set; }
    }
}