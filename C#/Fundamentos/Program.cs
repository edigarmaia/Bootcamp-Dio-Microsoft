using Fundamentos.Models;


//Operadores condicionais - if aninhado
int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if(quantidadeCompra == 0){
    Console.WriteLine("Venda inválida");
}
else if(possivelVenda){
    Console.WriteLine("Venda realizada");

}
else{
    Console.WriteLine("Não temos a quantidade solicitada em estoque");
}

//Operadores condicionais
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 14;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if(possivelVenda){
//     Console.WriteLine("Venda realizada");

// }else{
//     Console.WriteLine("Não temos a quantidade solicitada em estoque");
// }


// string a = "15";
// int b = Convert.ToInt32(a);

// Console.WriteLine(a);

//int a = 5;
//double b = a;

// int a = 5;
// long b = a;

// long a = 5;
// int b = Convert.ToInt32(a);
// Console.WriteLine(a);


// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);


// //int a = Convert.ToInt32("5");
// int a = int.Parse("5");

// Console.WriteLine(a);


// int a = 10;
// int b = 20;
// int c = a + b;

// Console.WriteLine(c += 5);
// Console.WriteLine(c -= 5);



// DateTime dataAtual = DateTime.Now;
// DateTime dataAtualMais5 = DateTime.Now.AddDays(5);
// //Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
// Console.WriteLine(dataAtualMais5);



// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("\nValor da quantidade " +  quantidade);
// Console.WriteLine("\nValor da altura " +  altura.ToString("0.00"));
// Console.WriteLine("\nValor da preço " +  preco);
// Console.WriteLine("\nValor da condição " +  condicao);


/*
Pessoa pessoa = new Pessoa();

pessoa.Nome = "Edigar";
pessoa.Idade = 40;
pessoa.Apresentar();
*/