using GeekShopping.API.Data.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShopping.API.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> FindAll();

        Task<ProductVO> FindById(long id);

        Task<ProductVO> Create(ProductVO product);

        Task<ProductVO> Update(ProductVO product);

        Task<bool> Delete(ProductVO product);
    }
}
