
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDBContext _dbContext;
        public EntityBaseRepository(AppDBContext appDBContext)
        {
            _dbContext = appDBContext;
        }
        public async Task AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbContext.Set<T>().FirstOrDefaultAsync(n => n.Id == id);

            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry entityEtry = _dbContext.Entry<T>(entity);
            entityEtry.State = EntityState.Deleted;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _dbContext.Set<T>().ToListAsync();
            return result;
        }
        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _dbContext.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }


        public async Task UpdateAsync(int id, T entity)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry entityEtry = _dbContext.Entry<T>(entity);
            entityEtry.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
