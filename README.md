# Design Patterns (Padrões de projeto)

## Proposta

Esse repositório tem como intenção documentar um resumo sobre os mais diversos padrões de projetos, inclusive e especialmente, os padrões elencados pelo GoF. Para cada design pattern, há uma breve explicação sobre sua proposta e exemplos de implementação.
Os exemplos serão escritos em C# utilizando a plataforma .NET.


## Definição

Design Patterns (Padrões de Projeto) são soluções práticas e reutilizáveis para problemas comuns que surgem durante o processo de desenvolvimento de software. Eles são soluções testadas e comprovadas que fornecem abordagens estruturadas para resolver desafios específicos de design de software. Não são códigos prontos ou bibliotecas específicas, mas sim descrições de como organizar classes e objetos para resolver determinados problemas. Eles ajudam os desenvolvedores a comunicar ideias de design entre si e fornecem um vocabulário comum para discutir soluções de forma mais abstrata.

Eles são divididos em três categorias principais:

1. Padrões de Criação (Creational Patterns): Lidam com a forma de criação de objetos, permitindo maior flexibilidade ao instanciar classes.
2. Padrões Estruturais (Structural Patterns): Descrevem como as classes e objetos são combinados para formar estruturas maiores.
3. Padrões Comportamentais (Behavioral Patterns): Tratam da comunicação e colaboração entre objetos, focando no comportamento do software.

Em suma, os design patters são um meio de estruturar seu código de forma a desenvolver softwares de forma flexível, ao aplicar padrões testados pelo mercado há décadas, e fornecer aos desenvolvedores uma linguagem comum entre os componentes de um sistema.

## Atenção!
Uma das coisas mais comuns quando aprendemos padrões de projetos é querer aplicá-los em todo e qualquer lugar. CUIDADO! Isso é um dos maiores erros que você pode cometer.
Os padrões, são chamados dessa forma, pois apareceram repetidamente na história do desenvolvimento de software. Porém, para que a aplicação deles seja eficiente, é necessário que o contexto do código não só diga, mas que ele GRITE, que cabe a utilização de um design pattern ali.
Caso isso não aconteça, NÃO UTILIZE, pois você terá mais malefícios do que benefícios.
Mentenha em mente: os padrões de projetos são uma solução para algum problema, e não, uma solução que está a procura de um problema.

## Os padrões

### Creatinoal
Segundo [refactoring.guru](https://refactoring.guru/)
Os padrões criacionais fornecem vários mecanismos de criação de objetos, que aumentam a flexibilidade e reutilização de código já existente.

São eles:
- [Factory Method]
- [Abstract Factory](/Creationals/AbstractFactory/README.md)
- [Builder]
- [Prototype]
- [Singleton]

### Structural
Segundo [refactoring.guru](https://refactoring.guru/)
Os padrões estruturais explicam como montar objetos e classes em estruturas maiores mas ainda mantendo essas estruturas flexíveis e eficientes.

São eles:
- [Adapter]
- [Bridge]
- [Composite]
- [Decorator]
- [Facade]
- [Flyweight]
- [Proxy]

### Behavioral
Segundo [refactoring.guru](https://refactoring.guru/)
Padrões comportamentais são voltados aos algoritmos e a designação de responsabilidades entre objetos.

São eles:
- [Chain of Responsability]
- [Command]
- [Iterator]
- [Mediator]
- [Memento]
- [Observer]
- [State]
- [Strategy]
- [Template Method]
- [Visitor]

## Referências
- Design Patterns: Elements od Reusable Object-Oriented Software
- [Refatoring.guru](https://refactoring.guru/pt-br/design-patterns)
