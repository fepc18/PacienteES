using Context;
using Domain;
using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Base
{

    public interface IEntityService<T> : IService
        where T : Entity
    {
        T Find(object id);
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        DataCollection<T> Paged(int page, int take);
        void Update(T entity);
    }
}
