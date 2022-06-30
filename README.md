# Nome do Projeto 

**BusinessApi**

# Descrição

A seguinte API foi desenvolvida como solução para um desafio técnico, proposto a avaliar habilidades envolvidas na criação de um serviço Rest em .Net. O desafio envolve a implementação de funcionalidades que devem girar em torno dos domínios `Customers` e `Orders`. 
As funcionalidades são expostas em dois Controllers principais, respectivos ao domínio, com endpoints específicos.
Como solução para persistencia, foi utilizado SQLite no modo in-memory, facilitando integrações de dados.


# Detalhes e Definições do Projeto

## :hammer: Check-List de Desenvolvimento

<strong>Desenvolvimento</strong>

- [x] Domínio
- [x] Desenvolvimento
- [x] Integração com banco de dados
- [x] Testes Unitários

## Recursos Disponíveis na API

### Customer

- `Cria um novo Customer`: `[POST] /api/v1/Customer`
	Contrato: {
	  "name": string,
	  "email": string
	}

- `Retorna todos os Customers criados`: `[GET] /api/v1/Customer`

- `Busca um Customer por Id`: `[GET] /api/v1/Customer/{id}`

- `Busca um Customer por Nome`: `[GET] /api/v1/Customer/{name}`

### Order

- `Cria um novo Order atrelado ao customerId informado no PATH`: `[POST] /api/v1/Order/{id}`
	Contrato: {
	  "price": decimal,
	  "status": enum
	}

- `Cria um novo Order atrelado ao nome do Costumer informado`: `[POST] /api/v1/Order/{name}`
	Contrato: {
	  "price": decimal,
	  "status": enum
	}

- `Atualiza o status de um Order baseado no orderId informado`: `[PATCH] /api/v1/Order/{orderId}`
	Contrato: {
	  "status": enum
	}

## Estrutura relacional

A seguinte estrutura foi criada para o domínio:

CUSTOMERS <br>
customerId	- int		- chave primária autoincrementada <br>
name		- string	- unique <br>
email		- string <br>

ORDERS <br>
orderId		- int		- chave primária autoincrementada <br>
customerId	- int		- foreign key apontada para CUSTOMERS.(customerId) <br>
price		- decimal <br>
createdAt	- string <br>
status		- int <br>

## Técnicas e tecnologias utilizadas

- ``.Net Core 3.1``
- ``Mediator``
- ``TDD``
- ``Clean Architecture with CQRS``

### Bibliotecas Públicas

- ``Dapper``												``Version: 2.0.123``
- ``MediatR``												``Version: 10.0.1``
- ``MediatR.Extensions.Microsoft.DependencyInjection``		``Version: 10.0.1``
- ``Microsoft.Data.Sqlite``									``Version: 5.0.17``
- ``Microsoft.Extensions.Configuration.Abstractions``		``Version: 6.0.0``
- ``Microsoft.Extensions.DependencyInjection.Abstractions``	``Version: 6.0.0``
- ``Shouldly``                                              ``Version: 4.0.3``
- ``Swashbuckle.AspNetCore``								``Version: 6.3.1``
- ``Swashbuckle.AspNetCore.Filters``						``Version: 7.0.3``
- ``xunit``                                                 ``Version: 2.4.1``
- ``xunit.runner.visualstudio``                             ``Version: 2.4.3``

# Desenvolvido Por
**Rodrigo Pinto**
