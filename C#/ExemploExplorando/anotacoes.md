# BODY EXPRESSIONS
get => _nome.ToUpper(); //para pequenas validações

# MODIFICADORES DE ACESSO
public - qualquer um pode acessar
private - só permite acessar dentro da própria classe

# MÉTODOS
Bloco de codigo que contém uma série de instruções;
Pode ser reaproveitado em diversos lugares;


# Exemplo lista (coleção)
public List<Pessoa> Alunos { get; set; }
# Adcionando alunos na lista
 public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

# CONSTRUTORES
Permite que o programador defina valores padrão, limite a instanciação e grave códigos flexíveis e fáceis de ler.
Todo construtor leva o mesmo nome da sua classe
Não tem retorno

# CONCATENAÇÃO DE STRINGS
string texto = "Nº " + (count+1) + " - " + Alunos[count].NomeCompleto;

# INTERPOLAÇÃO DE STRINGS
string texto = $"Nº {count+1} - {Alunos[count].NomeCompleto}";

# FORMATANDO VALORES MONETÁRIOS
decimal valorMonetario = 82.40M;
Console.WriteLine($"{valorMonetario:c}"); -> retorna R$ 82,40
:C -> indica a moeda corrente configurada no computador

# Alterando a localização do código
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");//Para dólar

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //para dólar

Console.WriteLine(valorMonetario.ToString("C1"));//uma casa decimal
Console.WriteLine(valorMonetario.ToString("C2"));//duas casa decimal
Console.WriteLine(valorMonetario.ToString("N2"));//duas casa decimal, sem o R$

# PORCENTAGEM
double porcentangem = .3421;
Console.WriteLine(porcentangem.ToString("P")); -> retorna 34,21%

# NUMEROS
int numero = 12345678;
Console.WriteLine(numero.ToString("##-##-####")); -> retorna 12-34-5678

# DATAS
DateTime data = DateTime.Now;//data e hora atual do computador

Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm"));
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

# EXCEÇÕES - EXCEPTIONS
Ajudam a lidar com situações excepcionais ou inesperadas que ocorrem quando o programa for executado
try{
    tente fazer algo
}catch(Exception e){
    fazer um tratamento
    Se der errado, mostrar o erro
}

# COLEÇÕES - FILA (QUEUE)
FIFO - First in, first out
fila.Enqueue(2);//adciona o numero 2  à fila
fila.Dequeue(); //remove o primeiro numero que entrou na fila

# COLEÇÕES - PILHA (STACK)
LIFO - Last in, first out

# COLEÇÕES - DICTIONARY
Armazena valores unicos sem uma ordem específica

Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");