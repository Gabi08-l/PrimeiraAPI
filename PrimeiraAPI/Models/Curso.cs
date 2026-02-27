using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Curso
    {
        public Guid CursoId { get; set; }
        [Required]
        public string? Nome { get; set; }
        public int Semestres { get; set; }
        public bool Ativo { get; set; }
        [DataType(DataType.Currency)]  //<= serve pra indicar que sera um numero decimal com dois numeros depoois do ponto (.)
        public decimal Mensalidade { get; set; }


        //propriedade de navegação para relação N=N(muitos pra muitos, muitos alunos para muitos cursos) com o Curso
        public ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();
        public ICollection<Disciplina>Disciplinas { get; set; } = new List<Disciplina>();
    }
}
