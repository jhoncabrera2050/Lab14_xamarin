using Lab14.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab14.Services
{
    public interface IProductRepository
    {
        Task<bool> AddProductAsync(Productinfo productinfo);
        Task<bool> UpdateProductAsyn(Productinfo productinfo);

        Task<bool> DeleteProductAsyn(int id); 

        Task<Productinfo> GetProductAsyn(int id);


        Task<IEnumerable<Productinfo>> GetProductAsyn();
    }
}
