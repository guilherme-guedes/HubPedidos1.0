using HubPedidos.v1.Models;
using Microsoft.EntityFrameworkCore;

namespace HubPedidos.v1.Data
{
    public class DataContext : AbstractDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}