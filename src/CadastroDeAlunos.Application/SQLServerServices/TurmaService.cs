using CadastroDeAlunos.Domain.DTO;
using CadastroDeAlunos.Domain.IRepositories;
using CadastroDeAlunos.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos.Application.SQLServerServices
{
    public class TurmaService : ITurmaService
    {
        private readonly ITurmaRepository _repository;
        public TurmaService(ITurmaRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TurmaDTO> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<TurmaDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(TurmaDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
