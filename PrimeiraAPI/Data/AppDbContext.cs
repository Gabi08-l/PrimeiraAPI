using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        // DbSet => Representa uma coleção de entidades do tipo especificado, permitindo realizar operações de consulta e manipulação de dados.Representação da tabela dentro do sistema db
        //deve ser add uma propriedade DbSet para cada tabela que deseja mapear para o banco de dados
        public DbSet<Models.Aluno> Alunos { get; set; }
        public DbSet<Models.Curso> Cursos { get; set; }

        public DbSet<Models.AlunoCurso> AlunosCursos { get; set; }
       
        public DbSet<Models.DisciplinaCurso> DisciplinasCursos { get; set; }
        public DbSet<PrimeiraAPI.Models.Disciplina> Disciplina { get; set; } = default!;

    }
}
