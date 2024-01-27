README

# Bus Control

![Venha conhecer o projeto Bus Control.](OIG.jpeg)

O projeto Bus Control fornece uma API RESTful para gerenciar dados de ônibus. A API permite que os usuários obtenham, criem, atualizem e excluam dados de ônibus.

## Funcionalidades Principais

O objetivo principal do projeto é realizar o controle tanto de quantos passageiros embarcaram durante aquela viagem sendo que há uma média e se ficar abaixo, sofrerá punicção.

- Ônibus: Informações sobre os ônibus, como número, modelo, marca e capacidade.
- Motoristas: Informações sobre os motoristas, como nome, idade e licença de motorista.
- Rotas: Informações sobre as rotas, como origem, destino e número de paradas.
- Passageiros: Informações sobre os passageiros, como nome, idade e endereço.

## Ferramentas utilizadas
O projeto BusControl.API utiliza as seguintes ferramentas e tecnologias:

- Testes:
XUnit: Framework de testes unitários para .NET.
MSTest: Framework de testes unitários da Microsoft.

- Banco de dados: Entity Framework Core: Framework de mapeamento objeto-relacional para .NET.

- API: ASP.NET Core: Framework web para .NET.

- Swagger: Ferramenta de documentação de APIs RESTful.

- Injeção de dependência: Autofac: Framework de injeção de dependência para .NET.

Os testes unitários cobrem as funcionalidades da API, incluindo a validação de dados, o tratamento de erros e o desempenho.

O banco de dados utilizado é o Microsoft SQL Server. 

O Entity Framework Core é usado para mapear os objetos da API para as tabelas do banco de dados.

A API é implementada usando o ASP.NET Core. O Swagger é usado para documentar as rotas e os métodos da API.

A injeção de dependência é usada para desacoplar os componentes da API. O Autofac é o framework de injeção de dependência utilizado.


### Segurança

Não foi pensado em segurança para esse projeto


## Estrutura do Projeto

O projeto está dividido em duas partes interligadas:

- **BusControl.API:** Inicialização da aplicação e ponto de entrada da API.

A API fornece as seguintes rotas:

/buses: Obtém uma lista de todos os ônibus.
/buses/{id}: Obtém um ônibus específico com base no ID.
/buses: Cria um novo ônibus.
/buses/{id}: Atualiza um ônibus existente.
/buses/{id}: Exclui um ônibus existente.
/drivers: Obtém uma lista de todos os motoristas.

/drivers/{id}: Obtém um motorista específico com base no ID.
/drivers: Cria um novo motorista.
/drivers/{id}: Atualiza um motorista existente.
/drivers/{id}: Exclui um motorista existente.
/routes: Obtém uma lista de todas as rotas.

/routes/{id}: Obtém uma rota específica com base no ID.
/routes: Cria uma nova rota.
/routes/{id}: Atualiza uma rota existente.
/routes/{id}: Exclui uma rota existente.
/passengers: Obtém uma lista de todos os passageiros.

/passengers/{id}: Obtém um passageiro específico com base no ID.
/passengers: Cria um novo passageiro.
/passengers/{id}: Atualiza um passageiro existente.
/passengers/{id}: Exclui um passageiro existente.
Para usar a API, você pode usar uma ferramenta como o Postman ou o Insomnia para enviar solicitações HTTP à API.


- **BusControl.Test:** Camada de testes.
Aqui estão alguns exemplos de testes que podem ser realizados:

Teste de validação de dados:
Testa se os dados enviados à API são válidos.
Por exemplo, um teste pode verificar se o número do ônibus é um número inteiro positivo.

Teste de tratamento de erros:
Testa se a API trata os erros corretamente.
Por exemplo, um teste pode verificar se a API retorna um código de erro quando é enviado um número de ônibus inválido.

Teste de desempenho:
Testa o desempenho da API.
Por exemplo, um teste pode verificar quanto tempo leva para a API retornar uma lista de todos os ônibus.


### Nomenclatura

Todos os componentes, incluindo nomes de classes, projetos, tabelas e propriedades, foram nomeados em inglês, seguindo as melhores práticas de programação.


## Feedback

Sinta-se à vontade para explorar e dar feedback através de elogios, sugestões e críticas.


## Como Contribuir

Se você deseja contribuir para o desenvolvimento deste projeto, siga as etapas abaixo:

### Relatando Problemas

Se encontrar algum problema ou tiver sugestões de melhorias, por favor, abra uma "Issue". Antes de criar uma nova "Issue", verifique se o problema já não foi relatado por outra pessoa.

### Contribuindo com Código

Se você deseja contribuir com código, siga estas etapas:

1. Fork do repositório.
2. Crie uma nova branch para suas alterações: `git checkout -b nome-da-sua-branch`.
3. Faça as alterações desejadas e faça commit: `git commit -m "Descrição das alterações"`.
4. Faça push para a sua branch: `git push origin nome-da-sua-branch`.
5. Abra um Pull Request (PR) com uma descrição clara das alterações propostas.

Agradeço antecipadamente por suas contribuições!

## Estrelas

Peço encarecidamente, se puder, dar estrela para que o projeto fique em destaque e mostre as outras pessoas.