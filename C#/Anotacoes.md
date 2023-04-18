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

# OPERADORES LÓGICOS
# OPERADOR OR (PIPE, ||)
Verdadeiro de ao menos uma das confições for verdadeira

# OPERADOR AND (E, &&)
Verdadeiro se as todas as condições são verdadeiras

# OPERADOR NOT (!) 
Nega a operação (inverte)

# OPERADORES ARTIMÉTICOS E CLASSE MATH
# Potência
public void Potencia(int x, int y){
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }

//Definindo 4 casas decimais
{Math.Round(coseno, 4)};

# ESTRUTURAS DE REPETIÇÃO (LAÇOS)
for (inicia a variavel; condicão; incrementa a variavel){
}

variavel de controle
contador
while(condicão){

	contador++;
}

Environment.Exit(0);//Sair do programa
Console.Clear(); //Limpa a tela

# ARRAY E LISTAS
Armazena valores do mesmo tipo, com um tamanho fixo
int [] array = new int[4];
string [] array = {"jan", "feb"};

int[] arrayInteiros = new int[3];
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

for(int i = 0; i < arrayInteiros.Length; i++){
    Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");
}

REDIMENSIONANDO UM ARRAY

# LISTAS
