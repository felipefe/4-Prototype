namespace Name
{
    public class Programador : Funcionario
    {
        public string Linguagem {get; set;}

        public Programador(){}
        public Programador(string nome, string linguagem)
        {
            base.Nome = nome;
            Linguagem = linguagem;
        }

        public override Funcionario Clone()
        {
            Funcionario p = (Funcionario)this.MemberwiseClone();
            p.Cargo = (Cargo)Cargo.Clone();
            return p;
        }

    }
}