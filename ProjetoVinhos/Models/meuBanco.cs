using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoVinhos.Models
{
    public class meuBanco:DbContext
    {

        public meuBanco():base("bancoDados")
        {

        }

        public DbSet<Vinhos> vinhos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vinhos>().HasKey(c => c.cod_vinho);

            modelBuilder.Entity<Vinhos>().Property(c => c.nome_vinho).
                IsRequired().
                HasMaxLength(100).
                HasColumnType("VARCHAR");


        }



    }




   

}