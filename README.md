# ****Desafio Técnico Digix****

- [x] Construí a estrutura do desafio utilizando API, pois, acredito que essa seja uma boa forma de gerenciar o cadastro e controle das "Famílias", facilitando assim a integração com outros serviços.
- [x] Para reduzir a quantidade de "if's" e facilitar a manutenção de critérios, utilizei [Strategy Pattern](https://refactoring.guru/pt-br/design-patterns/strategy) com [Dicionários](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.dictionary-2?view=net-5.0) de critérios.
- [x] Para ajudar a identificação do significado de cada código de status da família, utilizei [Enums](https://docs.microsoft.com/pt-br/dotnet/api/system.enum?view=net-5.0).
- [x] Para manter o sistema robusto, estou realizando testes unitários com NUnit.
- [x] Para deixar aberto ao uso de outros [SGBD's](https://www.devmedia.com.br/gerenciamento-de-banco-de-dados-analise-comparativa-de-sgbd-s/30788), implementei o Factory pela “interface” IDatabase.
- [x] Foram utilizados conceitos de OO e SOLID.

## Tecnologias utilizadas

* [Web APS .NET Core](https://docs.microsoft.com/pt-br/visualstudio/ide/quickstart-aspnet-core?view=vs-2019)
* [SQLite](https://docs.microsoft.com/pt-br/dotnet/standard/data/sqlite/?tabs=netcore-cli)
* [NUnit](https://nunit.org/)

