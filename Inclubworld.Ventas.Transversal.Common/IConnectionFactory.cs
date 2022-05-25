using System.Data;

namespace Inclubworld.Ventas.Transversal.Common
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
