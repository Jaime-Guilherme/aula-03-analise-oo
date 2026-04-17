using System;

namespace Aula03AnaliseOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TESTES INTERATIVOS - HERANÇA E POLIMORFISMO - AULA 3 ===\n");

            // Criando os veículos
            Carro carro = new Carro("Toyota Corolla", 4);
            Moto moto = new Moto("Honda CB500");
            Caminhao caminhao = new Caminhao("Volvo FH", 25);

            int opcao = 0;

            while (opcao != 9)
            {
                Console.WriteLine("\n--- MENU DE TESTES ---");
                Console.WriteLine("1. Mostrar movimento de todos os veículos (Polimorfismo)");
                Console.WriteLine("2. Acelerar Carro");
                Console.WriteLine("3. Acelerar Moto");
                Console.WriteLine("4. Acelerar Caminhão");
                Console.WriteLine("5. Frear Carro");
                Console.WriteLine("6. Frear Moto");
                Console.WriteLine("7. Frear Caminhão");
                Console.WriteLine("8. Moto dar Grau");
                Console.WriteLine("9. Sair");
                Console.Write("\nEscolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = 0;
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\n=== DEMONSTRAÇÃO DE POLIMORFISMO ===");
                        Veiculo[] veiculos = { carro, moto, caminhao };
                        foreach (var v in veiculos)
                        {
                            v.Mover();
                        }
                        break;

                    case 2:
                        Console.Write("Quantos km/h quer acelerar o carro? ");
                        if (int.TryParse(Console.ReadLine(), out int acelCarro))
                            carro.Acelerar(acelCarro);
                        carro.Mover();
                        break;

                    case 3:
                        Console.Write("Quantos km/h quer acelerar a moto? ");
                        if (int.TryParse(Console.ReadLine(), out int acelMoto))
                            moto.Acelerar(acelMoto);
                        moto.Mover();
                        break;

                    case 4:
                        Console.Write("Quantos km/h quer acelerar o caminhão? ");
                        if (int.TryParse(Console.ReadLine(), out int acelCaminhao))
                            caminhao.Acelerar(acelCaminhao);
                        caminhao.Mover();
                        break;

                    case 5:
                        Console.Write("Quantos km/h quer frear o carro? ");
                        if (int.TryParse(Console.ReadLine(), out int frearCarro))
                            carro.Frear(frearCarro);
                        break;

                    case 6:
                        Console.Write("Quantos km/h quer frear a moto? ");
                        if (int.TryParse(Console.ReadLine(), out int frearMoto))
                            moto.Frear(frearMoto);
                        break;

                    case 7:
                        Console.Write("Quantos km/h quer frear o caminhão? ");
                        if (int.TryParse(Console.ReadLine(), out int frearCaminhao))
                            caminhao.Frear(frearCaminhao);
                        break;

                    case 8:
                        moto.DarGrau();
                        break;

                    case 9:
                        Console.WriteLine("Finalizando os testes...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            Console.WriteLine("\n=== FIM DO PROGRAMA ===");
            Console.ReadKey();
        }
    }
}