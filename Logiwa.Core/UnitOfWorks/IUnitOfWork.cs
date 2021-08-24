using Logiwa.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logiwa.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }

        ICategoryRepository categories { get; }

        Task CommitAsync();

        void Commit();
    }
}
