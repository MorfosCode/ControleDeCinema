# Controle de Cinema

Com a necessidade de gerenciar melhor as vendas de ingressos do Cinema de Lages, foi proposto pelo dono do Cinema o
Sr. João do Nascimento, a criação de um sistema que auxilia no controle das vendas dos ingressos para os clientes que
desejam assistir os filmes e comer aquela pipoca nos finais de semana.

A equipe do Cinema deseja otimizar o controle de um conjunto de salas e agilizar o processo de venda dos ingressos aos
clientes. Atualmente, a equipe utiliza formulários de papel para armazenar as informações dos ingressos que já foram
vendidos e ainda os ingressos que estão disponíveis, como também as capacidades das salas.

---

## Requisitos Funcionais:

- Deve ser possível registrar e alterar informações das salas, como capcidade e número de assentos disponíveis;
- Deve ser possível registrar no acervo do cinema os filmes, com informações do título e duração;
- Um filme pode ser exibido em salas e horários diferentes;
- Uma sessão tem um número máximo de ingressos colocados a venda, sendo determinado pela capacidade da sala;
- A venda dos ingressos é realizada por funcionários e pode ser ingresso inteiro ou meio ingresso;
- Não deve ser possível realizar a venda de um ingresso para uma sessão encerrada;
- Deve permitir a visualização das sessões do dia agrupados por filme, tanto as em andamento
quanto aquelas ainda por serem iniciadas;
- Atendendo à solicitação de um cliente, o funcionário deverá efetuar a venda de um ou mais ingressos, obedecendo à
capacidade máxima de cada sala;
- O Sistema de Controle de Cinema deve possuir um módulo de cadastro, onde serão mantidas, no mínimo, as sessões. Este
módulo deve permitir a consulta, inclusão, alteração e remoção de sessões;
- O sistema deve apresentar os detalhes das sessões, mostrando as poltronas disponíveis e já vendidas.

---

## Requisitos Não Funcionais:

**Ambiente**
- A aplicação poderá ser acessada a partir de um navegador de internet (browser).

**Persistência das informações**
- Os dados devem ser salvos e recuperados em banco de dados utilizando ORM.

**Arquitetural**
- Deve-se trabalhar utilizando o modelo de camadas.

**Qualidade**
- Deve-se criar testes automatizados para os componentes da aplicação;
- Deve-se criar a documentação do projeto, prototipos, diagramas e README.

---

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

---

## Como Usar

#### Clone o Repositório
```
git clone https://github.com/MorfosCode/controle-cinema.git
```

#### Navegue até a pasta raiz da solução
```
cd controle-cinema
```

#### Restaure as dependências
```
dotnet restore
```

#### Navegue até a pasta do projeto
```
cd ControleCinema.WebApp
```

#### Execute o projeto
```
dotnet run
```

