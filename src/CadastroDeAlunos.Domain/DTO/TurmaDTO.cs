using CadastroDeAlunos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos.Domain.DTO
{
    public class TurmaDTO
    {
        public int id { get; set; }
        public string nome { get; set; }

        public int quantidadeDeAlunos { get; set; }

        public Turma mapToEntity()
        {
            return new Turma
            {
                Id = id,
                Nome = nome,
                QuantidadeDeAlunos= quantidadeDeAlunos,
            };
        }
        public TurmaDTO mapToDTO(Turma turma)
        {
            return new TurmaDTO
            {
                id = turma.Id,
                nome = turma.Nome,
                quantidadeDeAlunos = turma.QuantidadeDeAlunos,
            };
        }
    }
}
