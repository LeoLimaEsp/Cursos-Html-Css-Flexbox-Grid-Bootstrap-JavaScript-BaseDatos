﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Escuela_Entity_basics
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EscuelaEntities1 : DbContext
    {
        public EscuelaEntities1()
            : base("name=EscuelaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumno> Alumno{ get; set; }
        public virtual DbSet<Calificación> Calificación { get; set; }
        public virtual DbSet<Materia> Materias { get; set; }
        public virtual DbSet<Profesor> Profesores { get; set; }
        public virtual DbSet<ProfesorMateria> ProfesorMaterias { get; set; }
    }
}