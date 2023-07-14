using CadastroDeAlunos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos.Infra.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        #region DbSets<Tables>
        public DbSet<Aluno> Usuarios { get; set; }
        public DbSet<Turma> Itens { get; set; }
        #endregion
    }
}
