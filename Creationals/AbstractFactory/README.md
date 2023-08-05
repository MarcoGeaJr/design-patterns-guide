# Abstract Factory

Design Patterns (Livro) <br/>
Fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.

Como a imagem abaixo mostra, o client, utilizando uma fábrica abstrata, é capaz de criar uma fábrica concreta, capaz de criar objetos pertencentes a uma família comum.<br/>
![image](https://github.com/MarcoGeaJr/design-patterns-guide/assets/69200078/b804647e-0284-4edb-afa6-6f6d0a90c483)
<p>A imagem acima foi retirada do livro <i>Design Patterns: Elements of Reusable Object-Oriented Software</i></p>

# Estudo de caso
Um sistema deve atender a uma empresa que possui dois e-commerces. Cada um dos e-commerces possui dois tipos de frete: próprio e tercerizado.
Deve-se utilizar uma fábrica abstrata para que seja possivel utilizar um único software que consiga utilizar os dois tipos de frete dos dois e-commerces.

# Implementação

## Products
Para iniciar, temos que definir o nosso Product. No nosso exemplo, o Product é o frete próprio e o frete tercerizado.
Para isso, vamos criar uma interface chamada "IShipping" para definir nosso Abstract Product; e duas classes que representam nosso Concret Product, chamadas OwnerShipping e OutsourceShipping.

[Interface IShipping](/Creationals/AbstractFactory/Abstracts/Product/IShipping.cs)<br/>
![image](https://github.com/MarcoGeaJr/design-patterns-guide/assets/69200078/c53e1ef2-0cb1-430a-adac-1e849f55cc05)


Note que o método "GetShippingPrice" recebe por parâmetro um objeto do tipo "ShippingProduct", que representa as informações, de um produto qualquer, necessárias para calcular o frete.<br/>
[Classe ShippingProduct](/Creationals/AbstractFactory/Models/ShippingProduct.cs)<br/>
![image](https://github.com/MarcoGeaJr/design-patterns-guide/assets/69200078/47d0440e-291c-441f-904f-1234d8824f65)


Para finalizar essa parte, temos que criar nossos dois produtos concretos, de forma que implementem a interface "IShipping".

[Classe OwnerShipping](/Creationals/AbstractFactory/Concretes/Products/OwnerShipping.cs)<br/>
![image](https://github.com/MarcoGeaJr/design-patterns-guide/assets/69200078/5071ffc4-230e-4d47-9391-e09fa1111bd2)


[Classe OutsourceShipping](/Creationals/AbstractFactory/Concretes/Products/OutsourceShipping.cs)<br/>
![image](https://github.com/MarcoGeaJr/design-patterns-guide/assets/69200078/eeb090d8-73b6-4566-8a10-de1a3680bee6)

## Factories
