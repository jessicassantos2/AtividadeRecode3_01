using System;
using System.ComponentModel.DataAnnotations;

namespace AgenciaMVC.Models
{
    public class Cliente
    {
        [Key]   
        [Required]     
        public int IdCliente {get;set;}


        [Required] 
        [StringLength(60)] 
        public string nomeCliente {get;set;}


        [Required] 
        [StringLength(14)] 
        public string cpf {get;set;}


        [Required]   
        [StringLength(60)]
        
        public string endereco {get;set;}


        [Required]  
        [StringLength(60)]
        public string cidadeCliente {get;set;}

        [Required]  
        public string estadoCliente {get;set;}
        
        [Required]  
        public string telefone {get;set;}
    }
}