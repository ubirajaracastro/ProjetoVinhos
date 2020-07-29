using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoVinhos.Models;

namespace ProjetoVinhos.Repositorio
{
    public class RepositoryVinhos : IRepositoryVinhos
    {
        private meuBanco context = new meuBanco();

        public void DeleteVinho(Vinhos vinho)
        {
            context.vinhos.Remove(vinho);
            this.Save();
        }

        public IEnumerable<Vinhos> GetVinhos()
        {
            return context.vinhos.ToList();
        }

        public Vinhos GetVinhosByID(int id)
        {
            return context.vinhos.Find(id);
        }

        public void InsertVinho(Vinhos vinho)
        {
            context.vinhos.Add(vinho);
            this.Save();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateVinho(Vinhos vinho)
        {
            context.Entry(vinho).State = System.Data.Entity.EntityState.Modified;
            this.Save();
        }
    }
}