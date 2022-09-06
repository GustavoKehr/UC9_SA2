namespace ER2.Classes
{   
    //classe abstrata Pessoa "SuperClasse"
    public abstract class Pessoa
    { 
        //atributos da classe Pessoa
        public string? Nome { get; set; }
        public float Rendimento { get; set; }
        public string? Endereco { get; set; }
        
    }
}

//metodos acessores
//get : leitura
//set : alterar
// por padrao esses metodos acessores vem como publico, mas caso necessario colocar privado ou protegido