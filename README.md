# SolarHub

SolarHub é um sistema desktop desenvolvido em C# (Windows Forms) com banco de dados Oracle, que simula a gestão de uma rede de energia solar residencial. O sistema permite ao usuário monitorar e controlar painéis solares, itens no grid de energia e o estado da bateria.

## Grupo
- Leonardo Viotti Bonini
    - RM551716
- Eduardo Araujo de Andrade Junior
    - RM99758

## Video Pitch Explicativo

[Link do youtube]()

## Funcionalidades

- Login de usuário com autenticação no banco Oracle.
- Gerenciamento de painéis solares:
  - Adicionar e remover painéis solares.
  - Visualizar quantidade de painéis.
  - Verificar energia gerada pelos painéis no dia.
- Gerenciamento do grid de energia:
  - Adicionar e remover itens no grid (dispositivos conectados).
  - Definir prioridade e voltagem dos itens.
  - Verificar quantidade de itens ativos.
- Gerenciamento de bateria:
  - Ligar e desligar a bateria.
  - Verificar capacidade, energia armazenada e estado atual (ligado/desligado).
- Dashboard de monitoramento:
  - Quantidade de itens no grid.
  - Quantidade de painéis solares.
  - Energia gerada no dia.
  - Energia restante na bateria.

## Estrutura do Projeto

SolarHub/  
├── SolarHub.Estrutura.Model/ - Modelos (Entidades)  
├── SolarHub.Estrutura.Repository/ - Acesso e manipulação do banco (Repository)  
├── SolarHub.Estrutura.Controller/ - Regras de negócio (Controller)  
├── SolarHub.Estrutura.UI/ - Interface gráfica (Windows Forms)  

## Tecnologias Utilizadas

- C# (Windows Forms)
- Oracle Database (Conexão via Oracle.ManagedDataAccess)
- Arquitetura em camadas (Model, Repository, Controller, UI)

## Banco de Dados

- SolarhubUsers - Usuários
- SolarhubSolarPanel - Painéis solares
- SolarhubGridItem - Itens do grid de energia
- SolarhubBateria - Bateria

## Logins de Acesso

- Leonardo - 200398  
- Adm - 123

*README Gerado por IA*
