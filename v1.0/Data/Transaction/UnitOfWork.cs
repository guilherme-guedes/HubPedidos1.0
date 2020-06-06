
namespace HubPedidos.v1.Data.Transaction
{
public class UnitOfWork :  IUnitOfWork
    {
        public AbstractDataContext Context { get; }
 
        public UnitOfWork(AbstractDataContext context)
        {
            this.Context = context;
        }
        public void Commit()
        {
            this.Context.SaveChanges();
        }
 
        public void Dispose()
        {
           this.Context.Dispose();            
        }

        public void RollBack()
        {
        }
    }
}