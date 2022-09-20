using ER4.Interfaces;

namespace ER4.Classes
{   
    //classe abstrata Pessoa "SuperClasse"
    public abstract class Pessoa : IPessoa
    { 
        //atributos da classe Pessoa
        public string? Nome { get; set; }
        public float Rendimento { get; set; }
        public Endereco? Endereco { get; set; }

        public abstract float PagarImposto(float rendimento);
        
    }
} 

//metodos acessores
//get : leitura
//set : alterar
// por padrao esses metodos acessores vem como publico, mas caso necessario colocar privado ou protegido
//