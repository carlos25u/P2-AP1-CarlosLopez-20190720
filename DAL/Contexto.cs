using Microsoft.EntityFrameworkCore;
using P2_AP1_CarlosLopez_20190720.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_CarlosLopez_20190720.DAL
{
    class Contexto : DbContext
    {
        public DbSet<TiposTareas> TiposTareas { get; set; }
        public DbSet<Proyectos> Proyectos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\proyectoDetalle.db");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas
            {
                TipoId = 1,
                TipoTarea = "Analisis",
                Requerimiento = "Analizar la opcion de clientes",
                Tiempo = 120
            }
           );
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas
            {
                TipoId = 2,
                TipoTarea = "Diseño",
                Requerimiento = "Hacer un diseño excelente",
                Tiempo = 60
            }
           );
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas
            {
                TipoId = 3,
                TipoTarea = "Programacion",
                Requerimiento = "Programar todo el registro",
                Tiempo = 240
            }
           );
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas
            {
                TipoId = 4,
                TipoTarea = "Prueba",
                Requerimiento = "Probar con mucho cuidado",
                Tiempo = 30
            }
           );
        }
    }
}
