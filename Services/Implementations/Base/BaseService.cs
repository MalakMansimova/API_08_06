using Microsoft.EntityFrameworkCore;
using ProductAPI.DAL;
using ProductAPI.Models.Common;
using ProductAPI.Services.Interfaces.BaseService;
using ProductAPI.Utilities;
using ProductAPI.Utilities.Exceptions;

namespace ProductAPI.Services.Implementations.Base
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly AppDbContext _context;
        private DbSet<T> _dbSet;
        public BaseService(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<ResponseMessage> Add(T entity)
        {
           await _dbSet.AddAsync(entity);
           await _context.SaveChangesAsync();
           return new ResponseMessage()
            {
                Data = entity,
                Message = "Entity successfully created!",
                StatusCode = System.Net.HttpStatusCode.Created
            };
        }

        public async Task Delete(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<ResponseMessage> GetAll()
        {
            List<T> entities = await _dbSet.ToListAsync();
            return new ResponseMessage()
            {
                Data = entities,
                Message = "Entities found",
                StatusCode = System.Net.HttpStatusCode.OK
            };
        
        }

        public T GetById(int id)
        {
            T entity = _dbSet.Find(id);
            
            return entity;
        }

        public async Task<ResponseMessage> Update(T entity)
        {
            _dbSet.Update(entity);
            if( await _context.SaveChangesAsync() >= 1 ) {
                return new ResponseMessage()
                {
                    Message = "Successfully created!",
                    StatusCode = System.Net.HttpStatusCode.OK
                };
            }
            else {
                return new ResponseMessage()
                {
                    Message = "Problems occured, could not update entity",
                    StatusCode = System.Net.HttpStatusCode.BadRequest
                };
            }

        }
    }
}
