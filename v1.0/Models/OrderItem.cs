namespace HubPedidos.v1.Models
{
    public class OrderItem : Entity
    {        
        public Product Product {get;set;}
        public decimal Quantity {get; private set;}
        public long UnitPrice {get; private set;}
        public long Addition {get; private set;}
        public long Discount {get; private set;}
        public long Subtotal {get{ return (this.UnitPrice * this.Quantity).ToLongPrice(); }}
        public long Total {get; private set;}
        public virtual Order Order { get;set;}

        public OrderItem(double unitPrice, decimal quantity)
        {
            if(unitPrice < 0)
                throw new System.Exception("Mehlorar tratamento de erros");
            if(quantity <= 0)
                throw new System.Exception("Mehlorar tratamento de erros");

            this.UnitPrice = unitPrice.ToLongPrice();
            this.Quantity = quantity;
        }

        public void Increase()
        {
            this.Quantity++;
        }
        
        public void Decrease()
        {
            this.Quantity--;
        }        
        
        public void ChangeQuantity(decimal quantity)
        {
            if(quantity <= 0 )  
                throw new System.Exception("Mehlorar tratamento de erros");

            this.Quantity = quantity;
        }

        public void AddDiscount(double discountValue)
        {
            if(discountValue <= 0 || discountValue > this.UnitPrice)
                throw new System.Exception("Melhorar tratamentos de erros");

            this.Discount = discountValue.ToLongPrice();
        }
        
        public void AddAddition(double additionValue)
        {
            if(additionValue <= 0)
                throw new System.Exception("Melhorar tratamentos de erros");

            this.Addition = additionValue.ToLongPrice();
        }
        
    }
}