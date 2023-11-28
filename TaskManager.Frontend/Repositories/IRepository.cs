using TaskManager.Shared.Models;

namespace TaskManager.Frontend.Repositories
{
    public interface IRepository
    {
       Task<Response<T>> GetAsync<T>(string url);     
       
       Task<Response<T>> PostAsync<T>(string url, T model);     
       
       Task<Response<T>> PutAsync<T>(string url, T model);     
       
       Task<Response<T>> DeleteAsync<T>(string url);     
    }
}
