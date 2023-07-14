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
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _alunoRepository.FindById(id);
            return await _alunoRepository.Delete(entity);
        }

        public List<AlunoDTO> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<AlunoDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(AlunoDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
