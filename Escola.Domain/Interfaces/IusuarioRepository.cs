using Escola.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Interfaces
{
    public interface IusuarioRepository
    {
        Task<usuario> GetByIdAsync(int id);
        Task<List<usuario>> GetAllAsync();
        Task<usuario> AddSync(usuario usuario);
        Task<usuario> UpdateAsync(usuario usuario);
        Task<usuario> DeleteAsync(int id);
    }
}
