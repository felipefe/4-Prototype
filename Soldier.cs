namespace Name
{
    public class Soldier : ICloneable
    {

        public string Nome {get; set;}
        public string Poder {get; set;}
        public ObjetoAtaque ObjAtaque {get; set;}

        public Soldier(){}
        public Soldier(Soldier c){
            Nome = c.Nome;
            Poder = c.Poder;
        }

        public object Clone()
        {
            var soldado = (Soldier)this.MemberwiseClone();
            soldado.ObjAtaque = (ObjetoAtaque)ObjAtaque.Clone();
            return soldado;
        }
    }


    public class ObjetoAtaque
    {
        public string Nome {get; set;}

        public ObjetoAtaque(string nome){
            Nome = nome;
        }

        public object Clone()
        {
            return (ObjetoAtaque)this.MemberwiseClone();
        }
    }
}