using System;

namespace Aula03AnaliseOO
{
    // Classe base - Herança
    public class Veiculo
    {
        public string Marca { get; private set; }
        public int Velocidade { get; protected set; }

        public Veiculo(string marca)
        {
            Marca = marca;
            Velocidade = 0;
        }

        // Método virtual para permitir polimorfismo
        public virtual void Mover()
        {
            Console.WriteLine($"O veículo {Marca} está se movendo a {Velocidade} km/h.");
        }

        public void Acelerar(int incremento)
        {
            if (incremento > 0)
            {
                Velocidade += incremento;
                Console.WriteLine($"Acelerando... Velocidade atual: {Velocidade} km/h");
            }
        }

        public void Frear(int decremento)
        {
            if (decremento > 0)
            {
                Velocidade = Math.Max(0, Velocidade - decremento);
                Console.WriteLine($"Freando... Velocidade atual: {Velocidade} km/h");
            }
        }
    }
}