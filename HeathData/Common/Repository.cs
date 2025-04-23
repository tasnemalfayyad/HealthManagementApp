using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Application.Common
{
    public class Repository<T> where T : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _entities;

        public Repository(DbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
            var numberofAffectedRows = _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var entity = _entities.Find(id);

            if (entity == null)
            {
                Console.WriteLine($"There is no item with this ID: {id}");
                return;
            }

            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _entities.ToList();
        }
    }
}