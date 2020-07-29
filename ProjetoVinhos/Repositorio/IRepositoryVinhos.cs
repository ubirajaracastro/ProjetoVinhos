using ProjetoVinhos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVinhos.Repositorio
{
    public interface IRepositoryVinhos
    {
        IEnumerable<Vinhos> GetVinhos();

        Vinhos GetVinhosByID(int id);

        void InsertVinho(Vinhos vinho);

        void UpdateVinho(Vinhos vinho);

        void DeleteVinho(Vinhos vinho);

        void Save();
        
    }
}
