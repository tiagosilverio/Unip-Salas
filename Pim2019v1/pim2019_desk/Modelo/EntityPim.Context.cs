﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pim2019_desk.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class unip_salaEntities : DbContext
    {
        public unip_salaEntities()
            : base("name=unip_salaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tb_alfabeto> tb_alfabeto { get; set; }
        public virtual DbSet<tb_aluno> tb_aluno { get; set; }
        public virtual DbSet<tb_andar> tb_andar { get; set; }
        public virtual DbSet<tb_aula_local> tb_aula_local { get; set; }
        public virtual DbSet<tb_campus> tb_campus { get; set; }
        public virtual DbSet<tb_curso> tb_curso { get; set; }
        public virtual DbSet<tb_dia_semana> tb_dia_semana { get; set; }
        public virtual DbSet<tb_sala> tb_sala { get; set; }
        public virtual DbSet<tb_sigla> tb_sigla { get; set; }
        public virtual DbSet<tb_tipo_sala> tb_tipo_sala { get; set; }
        public virtual DbSet<tb_turma> tb_turma { get; set; }
        public virtual DbSet<tb_turma_aluno> tb_turma_aluno { get; set; }
    }
}
