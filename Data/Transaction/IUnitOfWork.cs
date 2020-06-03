using System;

namespace HubPedidos.v1.Data.Transaction
{
    public interface IUnitOfWork : IDisposable
    {
        AbstractDataContext Context { get;  }

        void Commit();

        void RollBack();
    }
}