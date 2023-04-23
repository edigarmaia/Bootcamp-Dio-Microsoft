using ExemploExplorando.Models;
using System.Globalization;//Alterando a localização do código

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