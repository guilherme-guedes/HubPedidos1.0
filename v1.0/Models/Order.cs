using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HubPedidos.v1.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get;set;}

        [Required(ErrorMessage="Este campo é obrigatório")]
        [Range(1, 1000000, ErrorMessage="A quantidade deve ser maior que 0")]
        public long Amount {get;set;}

        [Required(ErrorMessage="Este campo é obrigatório")]
        public DateTimeOffset Date{get;set;}

        [Required(ErrorMessage="Este campo é obrigatório")]
        public Customer Customer { get;set;}

        [Required(ErrorMessage="Este campo é obrigatório")]
        public List<OrderItem> Items { get;set;}

        public long Addition {get;set;}

        public long Discount {get;set;}

        [Required(ErrorMessage="Este campo é obrigatório")]
        [Range(1, 10000000000, ErrorMessage="O subtotal deve ser maior que 0 e menor que 100000000000(1000.000.000,00)")]
        public long Subtotal {get;set;}

        [Required(ErrorMessage="Este campo é obrigatório")]
        [Range(1, 10000000000, ErrorMessage="O valor total deve ser maior que 0 e menor que 100000000000(100.000.000,00)")]
        public long Total {get;set;}

        public virtual SaleChannel SaleChannel { get;set;}
    }
}