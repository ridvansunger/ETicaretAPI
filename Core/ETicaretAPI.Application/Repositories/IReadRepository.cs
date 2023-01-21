﻿using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T>:IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        //şarta göre veri getirme
        IQueryable<T> GetWhere(Expression<Func<T,bool>>method);
        Task<T> GetSingleAsync(Expression<Func<T,bool>>method);
        Task<T> GetByIdAsync(string id);
    }
}
