using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Enitity;
using Core.Specification;

namespace Core.Interface
{
    public interface IGenericRepostorty<T> where T : BaseEntity
    {

         Task<T> GetByIdAsync(int id);
         Task<IReadOnlyList<T>> ListAllAsync();
         Task<T> GetEntityWithSpace(ISpecification<T> spec);
         Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
    }
}