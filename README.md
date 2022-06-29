# Nome do Projeto 

**BusinessApi**

# Descri��o

A seguinte API foi desenvolvida como solu��o para um desafio t�cnico, proposto a avaliar habilidades envolvidas na cria��o de um servi�o Rest em .Net. O desafio envolve a implementa��o de funcionalidades que devem girar em torno dos dom�nios `Customers` e `Orders`. 
As funcionalidades s�o expostas em dois Controllers principais, respectivos ao dom�nio, com endpoints espec�ficos.
Como solu��o para persistencia, foi utilizado SQLite no modo in-memory, facilitando integra��es de dados.


# Detalhes e Defini��es do Projeto

## :hammer: Check-List de Desenvolvimento

<strong>Desenvolvimento</strong>

- [x] Dom�nio
- [x] Desenvolvimento
- [x] Estrutura Relacional
- [x] Testes Unit�rios

## Recursos Dispon�veis na API

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

A seguinte estrutura foi criada para o dom�nio:

CUSTOMERS
---------
customerId	- int		- chave prim�ria autoincrementada
name		- string	- unique
email		- string

ORDERS
------
orderId		- int		- chave prim�ria autoincrementada
customerId	- int		- foreign key apontada para CUSTOMERS.customerId
price		- decimal
createdAt	- string
status		- int

## T�cnicas e tecnologias utilizadas

- ``.Net Core 3.1``
- ``Mediator``
- ``TDD``
- ``Clean Architecture with CQRS``

### Bibliotecas P�blicas

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