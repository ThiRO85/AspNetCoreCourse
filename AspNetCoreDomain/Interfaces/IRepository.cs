﻿using AspNetCoreDomain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreDomain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T item);
        Task<T> SelectAsync(Guid id);
        Task<IEnumerable<T>> SelectAsync();
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistAsync(Guid id);
    }
}