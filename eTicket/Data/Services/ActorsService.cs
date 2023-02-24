using eTicket.Data.Base;
using eTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        //private readonly AppDBContext _dbContext;
        public ActorsService(AppDBContext dbContext) : base(dbContext) { }




        //public async Task AddAsync(Actor actor)
        //{
        //    await _dbContext.Actors.AddAsync(actor);
        //    await _dbContext.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var result = await _dbContext.Actors.FirstOrDefaultAsync(n => n.Id == id);

        //    _dbContext.Actors.Remove(result);
        //    await _dbContext.SaveChangesAsync();

        //}

        //public async Task<IEnumerable<Actor>> GetAllAsync()
        //{
        //    var result = await _dbContext.Actors.ToListAsync();
        //    return result;
        //}

        //public async Task<Actor> GetByIdAsync(int id)
        //{
        //    var result = await _dbContext.Actors.FirstOrDefaultAsync(n => n.Id == id);
        //    return result;
        //}

        //public async Task<Actor> UpdateAsync(int id, Actor newActor)
        //{
        //    _dbContext.Update(newActor);
        //    await _dbContext.SaveChangesAsync();
        //    return newActor;
        //}


    }
}
