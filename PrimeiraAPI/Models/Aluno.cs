using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Aluno
    {
        public Guid AlunoId { get; set; }
        [Required]
        public string? Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int RM { get; set; }
        public bool CadastroAtivo { get; set; }
        public decimal Mensalidade { get; set; }


        //propriedade de navegação para relação N=N(muitos pra muitos, muitos alunos para muitos cursos) com o Curso
        public ICollection<Curso>Cursos { get; set; } = new List<Curso>();
    }
}
