using Lab14.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab14.Services
{
    public class ProductService : IProductRepository
    {
        public SQLiteAsyncConnection _database;
        public ProductService(string dbpath)
        {
            _database = new SQLiteAsyncConnection(dbpath);
            _database.CreateTableAsync<Productinfo>().Wait();
        }
        public async Task<bool> AddProductAsync(Productinfo productinfo)
        {
            if(productinfo.ProductId > 0)
            {
                await _database.UpdateAsync(productinfo);
            }
            else
            {
                await _database.InsertAsync(productinfo);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteProductAsyn(int id)
        {
            await _database.DeleteAsync<Productinfo>(id);
            return await Task.FromResult(true);
        }

        public async Task<Productinfo> GetProductAsyn(int id)
        {
            return await _database.Table<Productinfo>().Where(p => p.ProductId == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Productinfo>> GetProductAsyn()
        {
            return await Task.FromResult(await _database.Table<Productinfo>().ToListAsync());
        }



        public Task<bool> UpdateProductAsyn(Productinfo productinfo)
        {
            throw new NotImplementedException();
        }
    }
}
