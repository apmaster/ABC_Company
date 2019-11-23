using System;
using System.Collections.Generic;
using System.Text;

namespace Seedwork
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
