using AutoMapper;
using GeekShopping.API.Data.ValueObjects;
using GeekShopping.API.Model;
using GeekShopping.API.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShopping.API.Repository
{
    public class ProductRepository : IProductRepository
    {

        private readonly MySqlContext _context;
        private IMapper _mapper;
       

        public ProductRepository(MySqlContext context, IMapper mapper)
        {
                _context = context;
                 _mapper = mapper;
        }

        public  Task<ProductVO> Create(ProductVO product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(long id)
        {
            Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public Task<ProductVO> Update(ProductVO product)
        {
            throw new NotImplementedException();
        }


        public Task<bool> Delete(ProductVO product)
        {
            throw new NotImplementedException();
        }

       
    }
}
