using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HubPedidos.v1.Models
{
    public class SaleChannel
    {
        [Key]
        public Guid Id {get;set;}   
        
        [Required(ErrorMessage="Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage="Este campo deve conter entre 5 a 60 caracteres")]
        [MinLength(5, ErrorMessage="Este campo deve conter entre 5 a 60 caracteres")]     
        public String Name {get;set;}
        
        public virtual List<Order> Orders {get;set;}
    }
}