# 🎯 Guess The Number — Jogo de Adivinhação em C#

Este projeto é um jogo de adivinhação via console onde a máquina escolhe um número secreto, e o usuário tenta descobrir qual é.  
Inclui níveis de dificuldade, limite de tentativas, validação de entradas e opção de jogar novamente.

Este projeto foi originalmente disponibilizado pela **Trybe**, porém esta versão foi **refatorada, reorganizada e convertida** em uma aplicação **executável de console (.NET 6)**.  
Foram realizados ajustes estruturais, correções de fluxo e melhorias para torná-lo um projeto C# funcional de ponta a ponta.

---

## 🚀 Como rodar localmente

### 📌 Requisitos

- **.NET 6 SDK** instalado  
Verifique com:
```bash
dotnet --version
```

---

### 📥 Clonar o repositório

```bash
git clone https://github.com/d4n13ln13ls3n/guessTheNumber.git
```

---

## 📁 Estrutura de pastas

```text
guessTheNumber/
│
├── src/
│   └── guessing-number/
│       ├── GuessNumber.cs
│       ├── Program.cs
│       ├── guessing-number.csproj
│       └── ...outros arquivos
│
├── .gitignore
├── README.md
└── trybe.yml
```

---

## ▶️ Executar o jogo

Entrar na pasta do projeto:

```bash
cd guessTheNumber/src/guessing-number
```

Restaurar dependências:

```bash
dotnet restore
```

Executar:

```bash
dotnet run
```

---

## 📝 Sobre o projeto original da Trybe

Este repositório foi baseado em um exercício de lógica e C# proposto pela **Trybe**.  
A estrutura original utilizava um projeto do tipo *class library* e não era executável.

Esta versão inclui:

- Conversão para **projeto console executável (.NET 6)**
- Reorganização completa dos arquivos em classes separadas
- Correções de lógica e de fluxo do jogo
- Ajustes no system loop e validação de entradas
- Implementação da opção de jogar novamente
- Estrutura funcional pronta para evolução futura

---
