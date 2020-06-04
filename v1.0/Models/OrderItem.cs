using System;
using System.ComponentModel.DataAnnotations;

namespace HubPedidos.v1.Models
{
    public class OrderItem
    {
        [Key]
        public Guid Id {get;set;}
        
        [Required(ErrorMessage="Este campo é obrigatório")]
        public Product Product {get;set;}

        [Required(ErrorMessage="Este campo é obrigatório")]
        [Range(0.1, 1000, ErrorMessage="A quantidade deve ser maior que 0")]
        public double Quantity {get;set;}

        public long Addition {get;set;}

        public long Discount {get;set;}

        [Required(ErrorMessage="Este campo é obrigatório")]
        [Range(1, 100000000, ErrorMessage="O valor subtotal deve ser maior que 0 e menor que 100000000(1.000.000,00)")]
        public long Subtotal {get;set;}

        [Required(ErrorMessage="Este campo é obrigatório")]
        [Range(1, 100000000, ErrorMessage="O valor total deve ser maior que 0 e menor que 100000000(1.000.000,00)")]
        public long Total {get;set;}

        public virtual Order Order { get;set;}
    }
}