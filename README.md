# 🎮 Sistema de Cadastro e Biblioteca de Jogos

Um sistema em console interativo desenvolvido em **C#** para gerenciar o perfil de um gamer, validar a compra de novos títulos com base no saldo disponível, organizar uma biblioteca de jogos existentes e gerar estatísticas financeiras e de tempo de jogo.

## 🚀 Funcionalidades

*   **Cadastro de Perfil:** Registro de dados do cliente (Nome, Nickname, Plataforma principal, Ano de adesão e Saldo disponível).
*   **Simulador de Compra:** 
    *   Valida se a plataforma do jogo é compatível com a do cliente.
    *   Verifica se o saldo é suficiente ou calcula o valor restante necessário.
*   **Gerenciamento de Biblioteca:** Criação de uma lista personalizada com os jogos que o usuário já possui.
*   **Análise Financeira:** Calcula o total gasto em jogos, a média de preço por compra e identifica o título mais caro.
*   **Métricas de Gameplay:** Registra as horas jogadas por título, calcula o tempo total de jogo, aponta o jogo mais jogado e o menos jogado ("jogo encostado").

## 🛠️ Tecnologias Utilizadas

*   **Linguagem:** C# (.NET Core / .NET Console Application)
*   **Recursos aplicados:** Vetores (`arrays`), Laços de repetição (`for`), Condicionais compostas (`if/else`) e funções de agregação LINQ (`.Max()`).

## 💻 Como Executar o Projeto

1. Certifique-se de ter o [.NET SDK](https://microsoft.com) instalado em sua máquina.
2. Clone o repositório ou copie o código fonte para o seu ambiente local.
3. Abra o terminal na pasta do projeto e execute o comando:
   ```bash
   dotnet run
   ```
4. Siga as instruções exibidas no console para inserir os dados.

## 👥 Desenvolvedores

Este projeto foi construído colaborativamente por:
*   José Henrique
*   Fábio Gomes
*   Lucas Santos
*   Nicolas Kronemberger
*   Washington Willian
