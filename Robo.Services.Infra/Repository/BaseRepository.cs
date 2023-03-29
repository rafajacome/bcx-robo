using Microsoft.EntityFrameworkCore;
using Robo.Services.Domain.Entities;
using Robo.Services.Domain.Interfaces;
using Robo.Services.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo.Services.Infra.Repository
{

    public class BaseRepository<T> : IBaseInterface<T> where T : BaseEntity
    {
        protected readonly RoboContext context;
        private DbSet<T> dataset;
        public BaseRepository(RoboContext context)
        {
            this.context = context;
            dataset = context.Set<T>();
        }

        public bool Create(T entity)
        {
            try
            {
                entity.CreateAt = DateTime.UtcNow;
                dataset.Add(entity);
                context.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var result = dataset.SingleOrDefault(x => x.Id.Equals(id));

                if (result == null)
                    return false;

                dataset.Remove(result);

                context.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Get()
        {
            try
            {
                return dataset.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<T> GetList()
        {
            try
            {
                return dataset.OrderBy(u => u.Id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                var result = dataset.SingleOrDefault(u => u.Id == entity.Id);

                if (result == null)
                    return false;

                entity.UpdateAt = DateTime.UtcNow;

                context.Entry(result).CurrentValues.SetValues(entity);
                context.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
