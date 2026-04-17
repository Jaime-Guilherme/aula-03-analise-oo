# Aula 3 - Herança e Polimorfismo
**Disciplina:** Análise Orientada a Objetos  
**Aluno:** Jaime Guilherme  
**Data:** 16/04/2026

---

## 🎯 Objetivo da Aula

Aplicar os conceitos de **Herança** e **Polimorfismo** por meio de uma hierarquia de classes de veículos (`Veiculo`, `Carro`, `Moto` e `Caminhao`), demonstrando na prática os pilares da Programação Orientada a Objetos.

O projeto inclui um **menu interativo** completo para que o professor possa realizar testes dinâmicos das funcionalidades, facilitando a avaliação dos conceitos ensinados.

---

## 📚 Conceitos Aplicados

| Conceito            | Como foi implementado no projeto |
|---------------------|----------------------------------|
| **Herança**         | Classe `Veiculo` como base para `Carro`, `Moto` e `Caminhao`, reutilizando atributos e métodos |
| **Polimorfismo**    | Método `Mover()` sobrescrito em cada subclasse com comportamentos específicos |
| **Sobrescrita**     | Uso de `virtual` na classe base e `override` nas classes derivadas |
| **Encapsulamento**  | Propriedades com `private set` e `protected` para controle de acesso |
| **Abstração**       | Classe base define o contrato comum para todos os veículos |

---

## 🛠️ Tecnologias e Ferramentas

- **Linguagem:** C#
- **Framework:** .NET 10.0 (Console Application)
- **IDE:** Visual Studio Code
- **Versionamento:** Git + GitHub
- **Padrão de Projeto:** Console interativo com menu

---

## 📁 Estrutura do Projeto
Aula 03 Analise OO/
├── Program.cs                  ← Menu interativo principal
├── Veiculo.cs                  ← Classe base (Herança)
├── Carro.cs
├── Moto.cs
├── Caminhao.cs
├── Aula 03 Analise OO.csproj
├── Aula 03 Analise OO.sln
├── .gitignore
└── README.md
---

## 🚀 Como Executar

1. Abra o terminal na pasta do projeto
2. Restaure as dependências (se necessário):
   ```bash
   dotnet restore
3. Execute o projeto:
dotnet run

✨ Funcionalidades do Menu Interativo
O programa possui um menu interativo com as seguintes opções para facilitar os testes:

Mostrar movimento de todos os veículos (Demonstração de Polimorfismo)
Acelerar Carro
Acelerar Moto
Acelerar Caminhão
Frear Carro
Frear Moto
Frear Caminhão
Moto dar Grau (método específico da classe Moto)
Sair

Essa interface permite ao professor testar em tempo real os conceitos de herança, sobrescrita e polimorfismo de forma prática e didática.

🔍 Exemplo de Polimorfismo
No menu (opção 1), é criado um array de Veiculo e chamado o método Mover() em cada objeto. Mesmo sendo do mesmo tipo de referência, cada veículo executa sua própria implementação — isso é Polimorfismo.

📖 Referências Bibliográficas

Alura — Curso C# parte 3: entendendo herança e interface (Polimorfismo via herança)
DevMedia — Artigos: "Herança em .NET" e "Conceitos e Exemplos de Polimorfismo na Programação Orientada a Objetos"
Microsoft Docs — Herança e Polimorfismo em C#


✅ Conclusão
Este projeto demonstra de forma clara e prática a aplicação de Herança (reutilização de código) e Polimorfismo (flexibilidade de comportamento).
A utilização de um menu interativo torna a avaliação mais dinâmica, permitindo que diferentes cenários sejam testados facilmente.
O código segue as boas práticas de Orientação a Objetos ensinadas em sala, preparando o terreno para os próximos pilares (Abstração e Interfaces) nas próximas aulas.
"O polimorfismo permite que o mesmo comando produza efeitos diferentes em objetos distintos, tornando os sistemas mais flexíveis e extensíveis."