using Microsoft.EntityFrameworkCore;
using NikitaRubic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NikitaRubic.Context
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options) : base(options)
        {

        }
         public DbSet<Note> Notes { get; set; }
    }
}
