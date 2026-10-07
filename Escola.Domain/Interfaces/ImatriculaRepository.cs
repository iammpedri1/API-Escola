using Escola.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Interfaces
{
    public interface ImatriculaRepository
    {
        Task<Matricula> GetByIdAsync(int id);
        Task<List<Matricula>> GetAllAsync();
        Task<Matricula> AddSync(Matricula matricula);
        Task<Matricula> UpdateAsync(Matricula matricula);
        Task<Matricula> DeleteAsync(int id);
    }
}
