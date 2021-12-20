using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations.Schema;

using System;

using System.ComponentModel.DataAnnotations;

namespace AgenciaMVC.Models
{
    public class Pacote
    {
        [Key]
        [Required]
        public int IdPacotes{get;set;}

        [Required]  
        public int FK_IdDestino{get;set;}
        public Destino destino {get;set;}

        [Required]        
        public int FK_IdCliente{get;set;}
        public Cliente cliente{get;set;}

        [Required] 
        public int qtdePessoas {get;set;}

        [Required] 
        public int qtdeDias {get;set;}
       
    }
}