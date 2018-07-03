using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Services
{
    public class RecordSheetService<T> : IServices<T> where T : class
    {
        private readonly IRepository<T> repo;

        public RecordSheetService(IRepository<T> repository)
        {
            repo = repository;
        }
        public void Add(T entity)
        {
            repo.Add(entity);
        }

        public void Delete(T entity)
        {
            repo.Delete(entity);
        }

        public void Edit(T entity)
        {
            repo.Edit(entity);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return repo.GetAll();
        }

        public T GetSingle(int id)
        {
            return repo.GetSingle(id);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
