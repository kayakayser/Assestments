using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Logiwa.Core.Models;
using Logiwa.Core.Repositories;
using Logiwa.Core.Service;
using Logiwa.Core.UnitOfWorks;

namespace Logiwa.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }
    }
}
