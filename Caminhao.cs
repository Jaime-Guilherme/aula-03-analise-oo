using System;

namespace Aula03AnaliseOO
{
    public class Caminhao : Veiculo
    {
        public int CapacidadeCarga { get; private set; }

        public Caminhao(string marca, int carga) : base(marca)
        {
            CapacidadeCarga = carga;
        }

        public override void Mover()
        {
            Console.WriteLine($"🚚 O caminhão {Marca} ({CapacidadeCarga} toneladas) está transportando carga pesada.");
        }
    }
}