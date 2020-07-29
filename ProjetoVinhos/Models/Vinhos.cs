using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoVinhos.Models
{
    public class Vinhos
    {
        public int cod_vinho { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="Campo inválido!", MinimumLength =4)]
        public string nome_vinho { get; set; }

        public int idade_vinho { get; set; }

        [DataType(DataType.Currency)]
        public decimal preco_vinho { get; set; }


    }
}