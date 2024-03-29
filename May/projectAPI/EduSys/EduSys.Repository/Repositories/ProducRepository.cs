using EduSys.Core.Models;
using EduSys.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Repository.Repositories
{
    public class ProducRepository : GenericRepository<Product>,  IProductRepository
    {
        public ProducRepository(AppDbContext context) : base(context)
        {
                    
        }

        public async Task<List<Product>> GetProductsWithCategory() 
        {
            //Eager Loading
            return await _context.Products.Include(x => x.Category).ToListAsync();  

            //1. Eager Loading
            //2. Lazy Loading
        }
    }
}
