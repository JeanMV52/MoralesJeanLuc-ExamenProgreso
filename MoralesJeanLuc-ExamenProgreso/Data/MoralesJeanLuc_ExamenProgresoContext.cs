using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoralesJeanLuc_ExamenProgreso.Models;

namespace MoralesJeanLuc_ExamenProgreso.Data
{
    public class MoralesJeanLuc_ExamenProgresoContext : DbContext
    {
        public MoralesJeanLuc_ExamenProgresoContext (DbContextOptions<MoralesJeanLuc_ExamenProgresoContext> options)
            : base(options)
        {
        }

        public DbSet<MoralesJeanLuc_ExamenProgreso.Models.MoralesJeanLuc> MoralesJeanLuc { get; set; } = default!;
        public DbSet<MoralesJeanLuc_ExamenProgreso.Models.Celular> Celular { get; set; } = default!;
    }
}
