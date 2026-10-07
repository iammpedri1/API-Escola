using Escola.Domain.Entities;
using Escola.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Infra.Data.Repositories
{
    public class MatriculaRepository : ImatriculaRepository
    {
        public Task<Matricula> AddSync(Matricula matricula)
        {
            throw new NotImplementedException();
        }

        public Task<Matricula> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Matricula>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Matricula> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Matricula> UpdateAsync(Matricula matricula)
        {
            throw new NotImplementedException();
        }
    }
}
