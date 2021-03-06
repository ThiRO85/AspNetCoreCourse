using AspNetCoreDomain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreDomain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UserEntity> Post(UserEntity user);
        Task<UserEntity> Get(Guid id);
        Task<IEnumerable<UserEntity>> GetAll();
        Task<UserEntity> Put(UserEntity user);
        Task<bool> Delete(Guid id);
    }
}
