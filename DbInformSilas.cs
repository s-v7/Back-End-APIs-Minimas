namespace InformacoesSilasVasconcelos.DB;
//Defininco Classess
 public record Pessoa
 {
  	public int id {get; set;}
  	public string ? nome {get; set;}
  	public int    ? idade {get; set;}
  	public string ? cidadeNatal {get; set;}
  	public string ? cidadeOndeReside {get; set;}
  	public string ? github {get; set;}
  	public string ? linkedIn {get; set;}
  	public string ? objetivos {get; set;}
  	public string ? educacao {get; set;}
  	public string ? experienciasProfissionais {get; set;}
  	public string ? conhecimentosHabilidades {get; set;}
  	public string ? cursosDeQualificacao {get; set;}
  	public string ? idiomas {get; set;}
	public string ? contato {get; set;}
  }

//Definindo uma Class Pessoa

   public class PessoaDB
 {
   private static List<Pessoa> pessoas = new List<Pessoa>()
   {
     new Pessoa{ id=7, nome="Silas Vasconcelos Cruz", idade=32, cidadeNatal="Simplício Mendes - PI", 
                cidadeOndeReside="Florianópolis -SC", github="https://github.com/s-v7", 
                linkedIn="hhtps://s0", objetivos="Em busca de novos desafios, empresa que tendem a produzir novos Software", 
                educacao="Ensio Médio Completo", experienciasProfissionais="...", conhecimentosHabilidades="...+s1", 
                cursosDeQualificacao="...+s2", idiomas="...+sn-1", contato="+55(047)-9-9691-9951" },
   };

   public static List<Pessoa> getPessoa()
   {
     return pessoas;
   }

   public static Pessoa ? getPessoa(int id)
   {
     return pessoas.SingleOrDefault(pessoa => pessoa.id == id);
   }

   public static Pessoa createPessoa(Pessoa pessoa)
   {
     pessoas .Add(pessoa);
     return pessoa;
   }
//Método Atualizar Objeto
   public static Pessoa updatePessoa(Pessoa update)
   {
     pessoas = pessoas.Select(pessoa =>
     {
       if (pessoa.id == update.id)
       {
         pessoa.nome  = update.nome ;
       }
       return pessoa;
     }).ToList();
     return update;
   }
//Método remover Objeto
   public static void removePessoa(int id)
   {
     pessoas = pessoas.FindAll(pessoa => pessoa.id != id).ToList();
   }
 }