using Escola.Domain.Entities;
using Escola.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Infra.Data.Repositories
{
    public class TurmaRepository : IturmaRepository
    {
        public Task<turmas> AddSync(turmas turma)
        {
            throw new NotImplementedException();
        }

        public Task<turmas> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<turmas>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<turmas> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<turmas> UpdateAsync(turmas turma)
        {
            throw new NotImplementedException();
        }
    }
}
