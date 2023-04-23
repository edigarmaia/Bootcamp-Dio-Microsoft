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

            for (int count = 0; count < Alunos.Count; count++){
                // string texto = "Nº " + (count+1) + " - " + Alunos[count].NomeCompleto;//Concatenação
                string texto = $"Nº {count+1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}