using AutoMapper;
using FirstAppEf.Models;
using FirstAppEf.Repository.Entities;
using FirstAppEf.Repository.InterfacesDao;
using Microsoft.AspNetCore.Identity;
using static FirstAppEf.Repository.InterfacesDao.IRepository;

namespace FirstAppEf.Repository.Dao
{
    public class UsuarioDao: IUserStore<UsuarioDto>
    {
        public UsuarioDao()             
        {
        }

        public Task<IdentityResult> CreateAsync(UsuarioDto user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(UsuarioDto user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDto> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDto> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(UsuarioDto user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserIdAsync(UsuarioDto user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserNameAsync(UsuarioDto user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(UsuarioDto user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetUserNameAsync(UsuarioDto user, string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(UsuarioDto user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
