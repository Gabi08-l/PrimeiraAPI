namespace PrimeiraAPI.Models
{
    public class AlunoCurso
    {
        public Guid AlunoCursoId { get; set; }  //identificador unico do registro da associação entre aluno e o curso

         //chave estrangeira | FK | para o Aluno
         public Guid AlunoId { get; set; }

        public Aluno? Aluno { get; set; } //propriedade de navegação para acessar os detalhes do aluno associado a esse registro

        //chave estrangeira para o curso e propriedade de navegação
        public Guid CursoId { get; set; }
        public Curso? Curso { get; set; } 
    }
}
