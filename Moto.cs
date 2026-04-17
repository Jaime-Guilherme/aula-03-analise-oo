using System;

namespace Aula03AnaliseOO
{
    public class Moto : Veiculo
    {
        public bool TemCarona { get; private set; }

        public Moto(string marca) : base(marca)
        {
            TemCarona = false;
        }

        public override void Mover()
        {
            Console.WriteLine($"🏍️  A moto {Marca} está cortando o vento em alta velocidade!");
        }

        public void DarGrau()
        {
            Console.WriteLine($"🤘 A moto {Marca} deu um grauuu!!!");
        }
    }
}