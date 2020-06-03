using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HubPedidos.v1.Models
{
    public class Product
    {
        [Key]
        public Guid Id {get;set;}

        [Required(ErrorMessage="Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage="Este campo deve conter entre 5 a 60 caracteres")]
        [MinLength(5, ErrorMessage="Este campo deve conter entre 5 a 60 caracteres")]   
        public String Name { get;set;}
        
        [Required(ErrorMessage="Este campo é obrigatório")]
        [Range(1, 100000000, ErrorMessage="A quantidade deve ser maior que 0 e menor que 100000000(1.000.000,00)")]
        public long Price {get;set;}

        [Required(ErrorMessage="Este campo é obrigatório")]
        public Guid ExternalUniversalCode {get;set;}      

        public String  ExternalCode {get;set;}

        public virtual List<OrderItem> OrderItems {get;set;}
    }
}