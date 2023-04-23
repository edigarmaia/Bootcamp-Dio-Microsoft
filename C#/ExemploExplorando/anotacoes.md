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