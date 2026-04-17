using System;

namespace Aula03AnaliseOO
{
    public class Carro : Veiculo
    {
        public int NumeroPortas { get; private set; }

        public Carro(string marca, int portas) : base(marca)
        {
            NumeroPortas = portas;
        }

        public override void Mover()
        {
            Console.WriteLine($"🚗 O carro {Marca} ({NumeroPortas} portas) está acelerando suavemente na estrada.");
        }
    }
}