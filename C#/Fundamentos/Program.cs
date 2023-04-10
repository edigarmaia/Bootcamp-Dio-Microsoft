using Fundamentos.Models;

string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("\nValor da quantidade " +  quantidade);
Console.WriteLine("\nValor da altura " +  altura.ToString("0.00"));
Console.WriteLine("\nValor da preço " +  preco);
Console.WriteLine("\nValor da condição " +  condicao);


/*
Pessoa pessoa = new Pessoa();

pessoa.Nome = "Edigar";
pessoa.Idade = 40;
pessoa.Apresentar();
*/