namespace Name
{
    public abstract class Funcionario
    {
        public string Nome {get; set;}
        public Cargo Cargo {get; set;}

        public abstract Funcionario Clone();

        public Funcionario(){}
        public Funcionario(string nome, Cargo cargo)
        {
            this.Nome = nome;
            this.Cargo = cargo;
        }
    }



    public class Cargo
    {
        public string Nome {get; set;}

        public Cargo(){}
        public Cargo(string nome) => Nome = nome;

        public object Clone()
        {
            return (Cargo)this.MemberwiseClone();
        }
    }
}