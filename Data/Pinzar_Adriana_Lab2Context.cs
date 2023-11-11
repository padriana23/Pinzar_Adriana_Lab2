using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pinzar_Adriana_Lab2.Models;

namespace Pinzar_Adriana_Lab2.Data
{
    public class Pinzar_Adriana_Lab2Context : DbContext
    {
        public Pinzar_Adriana_Lab2Context (DbContextOptions<Pinzar_Adriana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Pinzar_Adriana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Pinzar_Adriana_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Pinzar_Adriana_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Pinzar_Adriana_Lab2.Models.BookCategory>? BookCategory { get; set; }

        public DbSet<Pinzar_Adriana_Lab2.Models.Category>? Category { get; set; }
    }
}
