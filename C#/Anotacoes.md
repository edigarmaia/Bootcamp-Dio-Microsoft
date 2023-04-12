# Anotações:

# INTRODUÇÃO

dotnet new console -> cria um novo projeto
dotnet run -> executa o projeto

*.cs -> arquivo do c#
*.csproj -> arquivo de projeto do c#, comtém metadados

nome de classe começa com letra maiúscula(PascalCase)	
método, ação que a pessoa pode realizar. Começa com letra maiúscula(PascalCase)
namespace organiza as classes
variaveis com letra minúscula, camelCase.
	*não abreviar
	*sem caracter especial(exceto "_" underline)


Convenções Cases
camelCase
PascalCase
snake_case
spinal-case


Console.ReadLine(); -> Lê uma linha que o usuário digitar

# TIPOS DE DADOS

string -> cadeia de caracteres
char -> um caracter
bool -> booleano, true ou false -> padrão é false
int, long -> inteiro, sem casas decimais
byte -> 0 a 255
uint -> (unsigned) sem sinal, começa do zero, não representa valor negativo, dobra a capacidade para positivos

float -> casas decimais
double -> casas decimais, mais preciso que o float
decimal -> casas decimais, mais usado para valores monetários. Ex: 1.80M

Para formatar casas decimais > ToString("0.00")

# TRABALHANDO COM DATAS
DateTime.Now -> recebe e data e hora atual do seu computador
DateTime.Now.AddDays(5); -> Adiciona 5 dias da data atual
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); -> Formata a data e a hora


# CONVERTENDO TIPOS DE VARIÁVES
Cast ou Casting -> conversão de uma variável para outro tipo de variável
Ex:
int a = Convert.ToInt32("5"); ou int a = int.Parse("5");

int a = Convert.ToInt32(null); -> imprime 0 (zero)
int a = int.Parse(null); -> impreme Erro, valor não pode ser nulo


# CONVERSÃO PARA STRING
int inteiro = 5;
string a = inteiro.ToString();

# CASTING IMPLICITO
int a = 5;
double b = a;


Caso contrário, precisa de conversão
double a = 5;
int b = Convert.ToInt32(a);

# OPERADORES CONDICIONAIS
Possibilita mudar o fluxo de execução do seu código, indicando um caminha a percorrer.
