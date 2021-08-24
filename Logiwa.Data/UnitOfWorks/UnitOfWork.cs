using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Logiwa.Core.Repositories;
using Logiwa.Core.UnitOfWorks;
using Logiwa.Data.Repositories;

namespace Logiwa.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private ProductRepository _productRepository;
        private CategoryRepository _CategoryRepository;

        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);

        public ICategoryRepository categories => _CategoryRepository = _CategoryRepository ?? new CategoryRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}



