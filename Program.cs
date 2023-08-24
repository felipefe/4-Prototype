namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo();

            //Exercicio
            Programador programador = new Programador();
            programador.Nome = "Felipe";
            programador.Linguagem = "C#";
            programador.Cargo = new Cargo("Pleno");

            Programador p1 = (Programador)programador.Clone();
            p1.Nome = "Lucian"; 

            Console.WriteLine($"{p1.Nome} - {p1.Linguagem} - {p1.Cargo.Nome}");

        }

        private static void Exemplo()
        {
            //Modelo
            var soldier = new Soldier { Nome = "Felipe", Poder = "Força", ObjAtaque = new ObjetoAtaque("Arma")};
            
            //Clones
            var s1 = (Soldier)soldier.Clone();
            s1.Nome = "Potter";
            s1.ObjAtaque.Nome = "Faca";

            var s2 = (Soldier)soldier.Clone();
            s2.Nome = "Harry";
            s1.ObjAtaque.Nome = "Pedra";

            Console.WriteLine($"{s1.Nome} ---> {s1.Poder} ---> Ataca com: {s1.ObjAtaque.Nome}");
            Console.WriteLine($"{s2.Nome} ---> {s2.Poder} ---> Ataca com: {s2.ObjAtaque.Nome}");
        }
    }
}