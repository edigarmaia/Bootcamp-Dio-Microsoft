using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Edigar", sobrenome: "Maia dos Santos");
// p1.Nome = "Edigar";
// p1.SobreNome = "Maia";

Pessoa p2 = new Pessoa(nome: "Paula", sobrenome: "Souza");
// p2.Nome = "Paula";
// p2.SobreNome = "Souza";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();








// p1.Nome = "Edigar";
// p1.SobreNome = "Maia";
// p1.Idade = 40;
// p1.Apresentar();