using DearlerPlatform.Domain.UserInfo;
using System.Linq.Expressions;

namespace DearlerPlatform.Core.Repository
{
    public interface IRepository<TEntity> 
        where TEntity : class
    {
        TEntity Delete(TEntity entity);
        Task<TEntity> DeleteAsync(TEntity entity);
        TEntity Get(Func<TEntity, bool> predicate);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> GetList();
        List<TEntity> GetList(Func<TEntity, bool> predicate);
        Task<List<TEntity>> GetListAsync();
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, string sort, int pageIndex, int pageSize);
        Task<List<TEntity>> GetListAsync(PageWithSortDto pageWithSortDto);
        TEntity Insert(TEntity entity);
        Task<TEntity> InsertAsync(TEntity entity);
        TEntity Update(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}