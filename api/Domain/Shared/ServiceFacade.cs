using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data;
using api.Repository;

namespace api.Service
{
    public class ServiceFacade<TEntity> where TEntity : class
    {
        protected readonly DataContext Context;
        private readonly BaseRepository<TEntity> _repository;

        public ServiceFacade(DataContext context, BaseRepository<TEntity> repository)
        {
            Context = context;
            _repository = repository;
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public virtual async Task<TEntity> GetOneById(string id)
        {
            return await _repository.GetOneById(id);
        }
        
        public virtual async Task<TEntity> GetOneById(int id)
        {
            return await _repository.GetOneById(id);
        }
        
        


    }
}