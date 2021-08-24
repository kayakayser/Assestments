using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Logiwa.Core.Models;
using Logiwa.Core.Repositories;
using Logiwa.Core.Service;
using Logiwa.Core.UnitOfWorks;

namespace Logiwa.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

    
    }
}
