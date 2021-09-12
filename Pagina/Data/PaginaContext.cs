using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcFrameWork.Models;

namespace Pagina.Data
{
    public class PaginaContext : DbContext
    {
        public PaginaContext (DbContextOptions<PaginaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcFrameWork.Models.Albums> albums { get; set; }
    }
}
