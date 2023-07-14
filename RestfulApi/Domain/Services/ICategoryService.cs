using RestfulApi.Domain.Models;

namespace RestfulApi.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
