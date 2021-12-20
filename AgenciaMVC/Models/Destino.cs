using System;
using System.ComponentModel.DataAnnotations;

namespace AgenciaMVC.Models
{
    public class Destino
    {
        [Key]
        [Required]
        public int IdDestino{get;set;}

        [Required]  
        [StringLength(60)]
        public string nomeDestino{get;set;}


        [Required]  
         public string estadoDestino{get;set;}

        [Required]  
        [StringLength(20)]
         public string paisDestino{get;set;}

        [Required]
        public decimal valorDiaria{get;set;}

        [Required]
        public string dataInicio{get;set;}

        [Required]
        public string dataFinal{get;set;}
        
    }
}