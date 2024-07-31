# Desafio Técnico Padawans

Este projeto foi desenvolvido como parte de um desafio técnico, utilizando **.NET Core** para construir uma aplicação que consome dados de uma API externa.

## Tecnologias Utilizadas

- **.NET Core**: Framework principal para o desenvolvimento da aplicação.

## Descrição do Projeto

A aplicação consiste na construção de três telas principais que consomem dados da API [JSONPlaceholder](https://jsonplaceholder.typicode.com/), um serviço de API REST fictício para testes e prototipagem. As telas implementadas são:

1. **Postagens**
   - Exibe uma lista de postagens, incluindo título e conteúdo.
   - Permite visualizar detalhes de cada postagem.

2. **Álbuns**
   - Exibe uma lista de álbuns de fotos.
   - Permite visualizar as fotos associadas a cada álbum.

3. **To-Dos**
   - Exibe uma lista de tarefas a serem feitas (to-dos).
   - Permite marcar as tarefas como concluídas ou não concluídas.

## Como Executar o Projeto

1. Clone este repositório para sua máquina local.
2. Navegue até a pasta do projeto.
3. Execute o comando `dotnet restore` para restaurar as dependências.
4. Execute o comando `dotnet run` para iniciar o servidor.
5. Acesse a aplicação em `http://localhost:5000` (ou na porta configurada).

## Contribuição

Contribuições são bem-vindas! Para contribuir, siga estas etapas:

1. Faça um fork deste repositório.
2. Crie uma nova branch para a sua feature (`git checkout -b feature/nova-feature`).
3. Commit suas mudanças (`git commit -m 'Adicionar nova feature'`).
4. Envie para a branch (`git push origin feature/nova-feature`).
5. Abra um Pull Request para revisão.

