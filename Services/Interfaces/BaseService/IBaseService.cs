using ProductAPI.Utilities;

namespace ProductAPI.Services.Interfaces.BaseService
{
    public interface IBaseService<T>
    {
        public Task<ResponseMessage> Add(T entity); 
        public Task Delete(T entity); 
        public T GetById(int id); 
        public Task<ResponseMessage> GetAll();
        public Task<ResponseMessage> Update(T entity);
    }
}
