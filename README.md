# C# — Estudos e Exercícios

![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![Sem dependências](https://img.shields.io/badge/depend%C3%AAncias-nenhuma-success?style=flat-square)

Repositório com meus estudos de **C#**, organizado por tópico e seguindo a ordem em que fui aprendendo cada assunto. Cada pasta é um projeto .NET independente, correspondente a uma etapa do curso.

Todo o código é escrito à mão, sem bibliotecas externas — o foco aqui é a base da linguagem: sintaxe, estrutura de um programa .NET, tipos e lógica de programação.

## Tecnologias

- C# / .NET 10
- Apenas a biblioteca padrão — sem dependências externas

## Como rodar

Cada pasta é um projeto executável. Para compilar e rodar:

```bash
cd 01-Estrutura-Basica-Namespaces
dotnet run
```

Também é possível abrir o arquivo `.slnx` diretamente no Visual Studio e executar com `F5`.

## Estrutura

Os projetos estão numerados na ordem de aprendizado:

| Projeto | Tópico |
| --- | --- |
| [`01-Estrutura-Basica-Namespaces/`](01-Estrutura-Basica-Namespaces/) | Estrutura básica de um programa C#, `namespace`, diretiva `using`, `Console.Write` / `WriteLine` e interpolação de strings |
| [`02-Variaveis/`](02-Variaveis/) | Variáveis, tipos de dados, conversão de tipos e leitura com `Console.ReadLine` |
| [`03-Operadores-Aritmeticos/`](03-Operadores-Aritmeticos/) | Operadores aritméticos — soma, subtração, multiplicação, divisão e resto |
| [`04-Operadores-Atribuicao-Incremento-Decremento/`](04-Operadores-Atribuicao-Incremento-Decremento/) | Operadores de atribuição (`+=`, `-=`, `*=`, `/=`) e incremento / decremento |
| [`05-Estruturas-Decisao-Condicional-Simples-Composta/`](05-Estruturas-Decisao-Condicional-Simples-Composta/) | Estruturas de decisão — condicional simples (`if`) e composta (`if` / `else`) |
| [`06-Revisao-Geral/`](06-Revisao-Geral/) | Revisão geral — exercícios combinando entrada de dados, operadores e condicionais |
| [`07-Estruturas-Decisao-Condicional-Aninhadas/`](07-Estruturas-Decisao-Condicional-Aninhadas/) | Condicionais aninhadas — `if` dentro de `if` e encadeamento com `else if` |
| [`08-Declaracao-Condicional-Switch/`](08-Declaracao-Condicional-Switch/) | Declaração condicional `switch` — `case`, `break` e `default` |

Dentro de cada projeto:

- `Program.cs` — ponto de entrada (`Main`), que chama cada exercício em sequência
- `Exercicios.cs` — as classes de exercício do tópico, cada uma com seu método `Executar()`

## Convenções

- **Pastas de projeto** numeradas com dois dígitos (`01`, `02`...) para manter a ordem correta na listagem.
- **Classes e arquivos** em `PascalCase`, seguindo as convenções oficiais de C#.
- Cada exercício é uma classe própria com um método `Executar()`, mantendo o `Main` limpo e legível.

## Outros repositórios de estudo

| Repositório | Conteúdo |
| --- | --- |
| [java-estudos](https://github.com/Math2710/java-estudos) | Fundamentos de Java e orientação a objetos |
| [python-estudos](https://github.com/Math2710/python-estudos) | Fundamentos de Python — tipos, operadores e laços |
| [html-estudos](https://github.com/Math2710/html-estudos) | HTML5 semântico — estrutura, tabelas, formulários e mídia |
| [css-estudos](https://github.com/Math2710/css-estudos) | CSS — cores, tipografia, layout e componentes |

## Autor

**Matheus Westphal** — estudante de Engenharia de Software, em formação para desenvolvimento back-end com Java, Spring e SQL.

[![LinkedIn](https://img.shields.io/badge/LinkedIn-matheus--westphal-0A66C2?style=flat-square&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/matheus-westphal-65a264201)
[![GitHub](https://img.shields.io/badge/GitHub-Math2710-181717?style=flat-square&logo=github&logoColor=white)](https://github.com/Math2710)

---

Repositório em constante atualização, conforme avanço nos estudos.
