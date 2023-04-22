using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //Adicionar aluno
        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }
        //Obter alunos matriculados
        public int ObterQuantidadeAlunosMatriculados(){
        int quantidade = Alunos.Count;
        return quantidade;
        }

        //Remover alunos
        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
        }

        //Listar alunos
        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso de {Nome}");
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}