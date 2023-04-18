using Fundamentos.Models;


//Array
int[] arrayInteiros = new int[3];
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

Console.WriteLine("REDIMENSIONANDO UM ARRAY\n");
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);//dobra o tamanho do array

Console.WriteLine("Percorrendo o array com o FOR");
for(int i = 0; i < arrayInteiros.Length; i++){
    Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");
}

/*
Console.WriteLine("\nPercorrendo o array com o FOREACH");
int contadorForeach = 0;
foreach (int valor in arrayInteiros){
    Console.WriteLine($"Posição nº {contadorForeach} - {valor}");
    contadorForeach++;
}
*/


/*
//Construindo menu interativo com while
string opcao;
bool exibirMenu = true;

while (exibirMenu){
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao){
        case "1":
        Console.WriteLine("Cadastro de Cliente");
        break;
        case "2":
        Console.WriteLine("Busca de Cliente");
        break;
        case "3":
        Console.WriteLine("Apagar Cliente");
        break;
        case "4":
        Console.WriteLine("Encerrar");
        //Environment.Exit(0); //Sair do programa sem executar o que está a baixo
        exibirMenu = false;
        break;

        default:
            Console.WriteLine("Opção inválida");
            break;
        

    }
      Console.WriteLine("Depois do menu");

}
*/

/*
//For
int numero = 10;
for(int contador = 0; contador < numero; contador++){
    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
}
*/

/*
//While
int numero = 10;
int contador = 0;
while(contador <= numero){
    Console.WriteLine($"{contador+1}º Execução: {numero} X {contador} = {numero * contador}");
    contador++;

    if(contador == 6){
        break; //interrompe o fluxo da execução
    }
    
}
*/

/*
//Do while
int soma = 0, numero = 0;

do {
    Console.WriteLine("Digite um número: (0 para encerrar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
}while (numero != 0);
 Console.WriteLine($"Total dos números digitados é = {soma}");
*/
/*
Calculadora calc = new Calculadora();

calc.RaizQuadrada(9);
*/
/*
//Incremento e decremento
int numero = 10;

Console.WriteLine(numero);

Console.WriteLine("Incrementando o 10");
//numero+=1;
numero++;
Console.WriteLine(numero);

Console.WriteLine("\n");

int numeroDecremento = 20;
Console.WriteLine(numeroDecremento);

Console.WriteLine("Decrementando o 20");
numeroDecremento--;
Console.WriteLine(numeroDecremento);
*/

/*
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
*/
/*
calc.Somar(5, 4);
calc.Subtrair(10,50);
calc.Multiplicar(15,45);
calc.Dividir(2,2);

calc.Potencia(3,3);
*/

/*
//Operadores aritméticos
//Operador not
bool choveu = true;
bool estaTarde = true;

if(!choveu && estaTarde){
    Console.WriteLine("Vou pedalar!");
}
else{
    Console.WriteLine("Vou pedalar outro dia!");
}

*/
/*
//Operador and &&
bool possuiPresencaMinima = true;
double media = 6.5;
if(possuiPresencaMinima && media >= 7.0){
    Console.WriteLine("Aprovado!");
}else{
    Console.WriteLine("Reprovado!");
}
*/

/*
//Operador or ||
bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel){
    Console.WriteLine("Entrada liberada");
}
else{
    Console.WriteLine("Entrada não liberada");
}
*/


//Operadores condicionais - switch case
/*
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":

    Console.WriteLine("É vogal!");
    break;

    default:
    Console.WriteLine("Não é uma vogal!");
    break;
}
*/

/*
//Operadores condicionais - if aninhado
int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

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
*/

/*
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u"){
        Console.WriteLine("Vogal");
    }
    else{
        Console.WriteLine("Não é vogal");
    }
    
*/
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