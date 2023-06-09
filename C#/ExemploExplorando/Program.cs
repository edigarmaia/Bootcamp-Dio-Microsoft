﻿using ExemploExplorando.Models;
using System.Globalization;//Alterando a localização do código



//implementando um dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

//verificando se um item existe
Console.WriteLine(estados["MG"]);
// foreach(var item in estados){
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// Console.WriteLine("******************");
// //removendo um item
// estados.Remove("BA");

// //alterando um item
// estados["SP"] = "São Paulo Capital";

// foreach(var item in estados){
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA2";
// Console.WriteLine($"Verificando um elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}"); 
// }else
// {
//     Console.WriteLine($"Valor não existe, é seguro adicionar a chave: {chave}");
// }




/*
//implementando uma pilha
Stack<int> pilha = new Stack<int>();

//adicionando item na pilha
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha){
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}\n");

pilha.Push(20);
foreach(int item in pilha){
    Console.WriteLine(item);
}
*/


/*
//implementando uma fila
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila){
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach(int item in fila){
    Console.WriteLine(item);
}
*/

// new ExemploExcecao().Metodo1();



/*
try
{
    string[] linhas = File.ReadAllLines("Arquivos/a/arquivoLeitura.txt");//fazendo a leitura de um arquivo

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. Caminho da pasta não encontrado {ex.Message}");
}
catch(Exception ex){
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}finally{
    Console.WriteLine("Chegou até aqui");
}
*/


/*
string dataString = "2023-04-17 18:00";
bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
                CultureInfo.InvariantCulture, 
                DateTimeStyles.None, 
                out DateTime data);

if(sucesso){
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}else{
    Console.WriteLine($"{dataString} não é uma data válida!");
}
*/


// DateTime data = DateTime.Parse(dataString);
// Console.WriteLine(data);

// DateTime data = DateTime.Now;//data e hora atual do computador

// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data);
// Console.WriteLine(data.ToShortTimeString());
// Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm"));
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1282.40M;

// // Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// Console.WriteLine(valorMonetario.ToString("C1"));//uma casa decimal
// Console.WriteLine(valorMonetario.ToString("C2"));//duas casa decimal
// Console.WriteLine(valorMonetario.ToString("N2"));//duas casa decimal, sem o R$

// double porcentangem = .3421;
// Console.WriteLine(porcentangem.ToString("P"));

// int numero = 12345678;
// Console.WriteLine(numero.ToString("##-##-####"));



// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);




// Pessoa p1 = new Pessoa(nome: "Edigar", sobrenome: "Maia dos Santos");
// // p1.Nome = "Edigar";
// // p1.SobreNome = "Maia";

// Pessoa p2 = new Pessoa(nome: "Paula", sobrenome: "Souza");
// // p2.Nome = "Paula";
// // p2.SobreNome = "Souza";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();





// p1.Nome = "Edigar";
// p1.SobreNome = "Maia";
// p1.Idade = 40;
// p1.Apresentar();