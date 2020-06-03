using System;
using System.ComponentModel.DataAnnotations;

namespace HubPedidos.v1.Models
{
    public class Customer 
    {
        [Key]
        public Guid Id {get;set;}

        [Required(ErrorMessage="Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage="Este campo deve conter entre 5 a 60 caracteres")]
        [MinLength(5, ErrorMessage="Este campo deve conter entre 5 a 60 caracteres")]
        public String Name { get;set;}

        public DateTime Birth {get;set;}
        
        public virtual Order Order {get;set;}
    }
}