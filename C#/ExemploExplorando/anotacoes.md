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