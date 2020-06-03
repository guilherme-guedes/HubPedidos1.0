
namespace HubPedidos.v1.Data.Transaction
{
public class UnitOfWork :  IUnitOfWork
    {
        public AbstractDataContext Context { get; }
 
        public UnitOfWork(AbstractDataContext context)
        {
            Context = context;
        }
        public void Commit()
        {
            Context.SaveChanges();
        }
 
        public void Dispose()
        {
           Context.Dispose();            
        }

        public void RollBack()
        {
            throw new System.NotImplementedException();
        }
    }
}