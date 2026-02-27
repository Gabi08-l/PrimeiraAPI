namespace PrimeiraAPI.Models
{
    public class DisciplinaCurso
    {
        public Guid DisciplinaCursoId { get; set; }

        public int NotaCurricular { get; set; }

        //chave fk do curso
        public Guid CursoId { get; set; }
        public Curso? Curso { get; set; }

        public Guid DisciplinaId { get; set; }
        public Disciplina? Disciplina { get; set; }
    }
}
