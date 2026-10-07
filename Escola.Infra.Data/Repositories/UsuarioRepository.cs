using Escola.Domain.Entities;
using Escola.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Infra.Data.Repositories
{
    public class UsuarioRepository : IusuarioRepository
    {
        public Task<usuario> AddSync(usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<usuario> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<usuario>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<usuario> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<usuario> UpdateAsync(usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
