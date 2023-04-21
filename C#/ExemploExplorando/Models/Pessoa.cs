using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;//encapsulando a variavel
        public string Nome{ 
        get => _nome.ToUpper();
        /*
        { get{
            return _nome.ToUpper();
        }
         */ 
          set{
            if (value == ""){//se o nome for vazio, lança uma exceptio
                throw new ArgumentException("O nome não pode ser vazio");
            }
            _nome = value;
          }
          }
          private int _idade;
        public int Idade 
        { 
            get => _idade;
             set{
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
             } 
        }

        public void Apresentar(){
        Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}");
    }
    }

    
}