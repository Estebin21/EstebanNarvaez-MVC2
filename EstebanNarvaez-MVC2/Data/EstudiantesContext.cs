using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EstebanNarvaez_MVC2.Models;

    public class EstudiantesContext : DbContext
    {
        public EstudiantesContext (DbContextOptions<EstudiantesContext> options)
            : base(options)
        {
        }

        public DbSet<EstebanNarvaez_MVC2.Models.EstudianteUDLA> EstudianteUDLA { get; set; } = default!;
    }
