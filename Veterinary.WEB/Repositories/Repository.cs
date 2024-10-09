
namespace Veterinary.WEB.Repositories
{
    public class Repository : IRepository
    {
        public Task<HttpResponseWrapper<T>> GetAsync<T>(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T model)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<TResponse>> PostAsync<T, TResponse>(string url, T model)
        {
            throw new NotImplementedException();
        }
    }
}
