using Robo.Services.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Robo.Services.Domain.Interfaces
{
    public interface IBaseInterface<T> where T : BaseEntity
    {
        public T Get();

        public List<T> GetList();

        public bool Create(T entity);

        public bool Update(T entity);

        public bool Delete(int id);


    }
}
