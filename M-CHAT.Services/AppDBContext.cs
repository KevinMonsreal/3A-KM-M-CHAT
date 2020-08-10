using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using M_CHAT.Models;

namespace M_CHAT.Services
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }
       
        public DbSet<Centro> Centros { get; set; }
        public DbSet<Niño> Niños { get; set; }
        public DbSet<Preguntas> Preguntas { get; set; }
        public DbSet<Tutor> Turores{ get; set; }
        
    }
}
