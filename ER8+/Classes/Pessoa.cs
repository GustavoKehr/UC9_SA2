using ER4.Interfaces;

namespace ER4.Classes
{   
    public abstract class Pessoa : IPessoa
    { 
        public string Nome { get; set; }
        public float Rendimento { get; set; }
        public Endereco Endereco { get; set; }

        public abstract float PagarImposto(float rendimento);
        
    }
} 
