namespace Name
{
    public class Engenheiro : Funcionario
    {
        public string Especialidade {get; set;}

        public Engenheiro(){}
        public Engenheiro(string nome, string especialidade)
        {
            base.Nome = nome;
            Especialidade = especialidade;
        }

        public override Funcionario Clone()
        {
            Funcionario engenheiro = (Funcionario)this.MemberwiseClone();
            engenheiro.Cargo = (Cargo)Cargo.Clone();
            return engenheiro;
        }
    }
}