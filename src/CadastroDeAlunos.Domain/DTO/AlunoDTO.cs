using CadastroDeAlunos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos.Domain.DTO
{
    public class AlunoDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }

        public DateTime dataDeNascimento { get; set; }
        public int turmaId { get; set; }
        public int estado { get; set; }

        public Aluno mapToEntity()
        {
            return new Aluno
            {
                Id = id,
                Nome = nome,
                Email = email,
                DataDeNascimento = dataDeNascimento,
                TurmaId = turmaId,
                Estado = estado
            };
        }
        public AlunoDTO mapToDTO(Aluno aluno)   
        {
            return new AlunoDTO()
            {
                id = aluno.Id,
                nome = aluno.Nome,
                email = aluno.Email,
                dataDeNascimento = aluno.DataDeNascimento,
                turmaId = aluno.TurmaId,
                estado = aluno.Estado
            };
        }
    }
}
