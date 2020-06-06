using System.Collections.Generic;

namespace HubPedidos.v1.Models
{
    public class Order : Entity
    {
        public Customer Customer { get; private set;}
        public List<OrderItem> Items { get; private set;}
        public long Amount {get; private set;}
        public long Addition {get; private set;}
        public long Discount {get; private set;}
        public long TaxFee {get;private set;}
        public long Subtotal {get{ return ((this.Amount + this.Addition) - this.Discount); }}
        public long SubtotalWithoutTax {get{ return ((this.Amount + this.Addition) - this.Discount); }}
        public long Total {get{ return (this.Subtotal + this.TaxFee); }}

        public Order(Customer customer, long discount = 0, long taxFee = 0, long addition = 0)
        {
            if(customer == null)
                throw new System.Exception("Melhorar tratamentos de erros");

            this.Customer = customer;
            this.Discount = discount;
            this.TaxFee = taxFee;
            this.Addition = addition;
        } 

        public void AddItem(OrderItem item)
        {
            if(this.Items?.Count < 0)
                this.Items = new List<OrderItem>();

            this.Items.Add(item);
        }
        public void AddTaxFee(double taxFeeValue)
        {
            if(taxFeeValue <= 0)
                throw new System.Exception("Melhorar tratamentos de erros");

            this.TaxFee = taxFeeValue.ToLongPrice();
        }
    }
}