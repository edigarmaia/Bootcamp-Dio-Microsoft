using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Pessoa
    {
        //Criando uma classe
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Criando um método
        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é "
            + "{Nome}, e tenho {Idade} anos");
            //Console.WriteLine($"Olá, meu nome é {Nome},\n e tenho {Idade} anos");

        }
    }
}