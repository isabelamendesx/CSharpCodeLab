# C# Code Lab
Repositório de estudos realizados em C# durante o curso Back End C# da Ada Tech

## Lógica de Programação

### Conceitos Iniciais

`Tipagem Estática:`

C# é uma linguagem fortemente tipada, o que significa que o tipo de uma variável é verificado em tempo de compilação. Isso ajuda a detectar erros de tipo antes da execução do programa, proporcionando maior segurança e robustez ao código.
Compilação:

`Linguagem compilada:`
Significa que o código-fonte é traduzido para código de máquina ou código intermediário (IL - Intermediate Language) durante o processo de compilação. O código intermediário é executado na Máquina Virtual do CLR (Common Language Runtime), que é parte do ambiente .NET.

`Código Gerenciado:`

C# faz parte do ecossistema .NET, onde o código é executado no ambiente gerenciado pelo CLR. O CLR oferece recursos como coleta de lixo automática, tratamento de exceções e verificação de tipo em tempo de execução. Isso facilita o desenvolvimento e a manutenção de software, tornando-o mais seguro e menos suscetível a problemas de gerenciamento de memória.

`C# vs .NET`
O C# (c sharp) é uma linguagem de programação orientada a objetos criada pela Microsoft e tem como base as linguagens em C, o que traz uma similaridade entre as
linguagem. Já o .NET (ou DotNet) é uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de sistemas e aplicações. Todo e qualquer código gerado para .NET pode ser executado em qualquer dispositivo que possua um framework de tal plataforma.

`Solution vs Project`

No Visual Studio, uma "solution" (solução) é um contêiner que pode incluir vários "projects" (projetos). Vamos entender a diferença entre eles:

*Project:*
- Um projeto é uma unidade básica de trabalho no Visual Studio.
- Contém todos os arquivos e configurações necessários para compilar e construir um produto de software.

*Solution:*
- Uma solução é um contêiner para um ou mais projetos.
- Pode incluir projetos diferentes, como um projeto de aplicativo e uma biblioteca de suporte, fornecendo um escopo mais amplo

Em resumo, uma solução é usada para organizar e coordenar vários projetos relacionados, enquanto um projeto é a unidade individual de trabalho que contém os arquivos e configurações necessários para construir um componente específico do software.

`Namespace e Using`

*Namespace:*
Um namespace é um contêiner que organiza e fornece um escopo para um conjunto de tipos (classes, interfaces, delegados, etc.). Ele evita conflitos de nomes, permitindo que você use o mesmo nome para tipos diferentes, desde que estejam em namespaces diferentes. Por exemplo, a classe Console está no namespace System, e seu nome completo é System.Console. 

*Using:*
Quando você escreve using nome-do-namespace;, está informando ao compilador que você planeja usar tipos desse namespace no código. Isso permite que você use apenas o nome do tipo, em vez do nome completo, tornando o código mais conciso.
Por exemplo, o namespace System contém muitas classes fundamentais em C#, como Console, String, etc. Quando você usamos "using System" podemos escrever apenas Console, ao invés de System.Console.


### Estrutura Básica de um programa em C#

```csharp
using System;
 
class Hello
{
    static void Main()
    {
        Console.WriteLine("Hello, World");
    }
}
```


