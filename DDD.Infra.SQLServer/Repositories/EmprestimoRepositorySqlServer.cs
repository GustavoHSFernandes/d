using DDD.Domain.BibliotecaContext;
using DDD.Domain.SecretariaContext;
using DDD.Infra.SQLServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Repositories
{
    public class EmprestimoRepositorySqlServer : IEmprestimoRepository
    {
        private readonly SqlContext _context;

        public EmprestimoRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }
        public void DeleteEmprestimo(Emprestimo emprestimo)
        {
            throw new NotImplementedException();
        }

        public Emprestimo GetEmprestimoById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Matricula> GetEmprestimos()
        {
            throw new NotImplementedException();
        }

        public Emprestimo InsertEmprestimo(int idLivro, int idAluno)
        {
            
            var livro = _context.Livros.First(i => i.LivroId == idLivro);
            var aluno = _context.Alunos.First(i => i.UserId == idAluno);

            var emprestimo = new Emprestimo
            {
                Livro = livro
                
            };

            try
            {

                _context.Add(emprestimo);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                var msg = ex.InnerException;
                throw;
            }

            return emprestimo;
        }

        public void UpdateEmprestimo(Emprestimo emprestimo)
        {
            throw new NotImplementedException();
        }
    }
}
