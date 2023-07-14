using CadastroDeAlunos.Domain.Entities;
using CadastroDeAlunos.Domain.IRepositories;
using CadastroDeAlunos.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos.Infra.Data.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        private readonly SQLServerContext _context;
        public AlunoRepository(SQLServerContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
