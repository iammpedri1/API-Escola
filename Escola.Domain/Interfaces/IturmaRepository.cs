using Escola.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Interfaces
{
    public interface IturmaRepository
    {
        Task<turmas> GetByIdAsync(int id);
        Task<List<turmas>> GetAllAsync();
        Task<turmas> AddSync(turmas turma);
        Task<turmas> UpdateAsync(turmas turma);
        Task<turmas> DeleteAsync(int id);
    }
}
