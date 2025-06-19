# Armário 42 🌌

🌠 `CURSO` - Análise e Desenvolvimento de Sistemas (ADS)

🌠 `DISCIPLINA` - Projeto: Desenvolvimento de uma Aplicação Interativa - Turma 08 - Grupo 1

🌠 `SEMESTRE` - Eixo 2 - 2025/1

O projeto em desenvolvimento é um **site de vitrine facilitadora para comércio de itens de cosplay, criado para conectar cosplayers que desejam vender ou adquirir peças**, acessórios e fantasias. Um espaço dedicado à comunidade que aprecia a cultura geek, facilitando o acesso e centralizando o comércio de itens exclusivos e importados de cosplays.

<img align="center" alt="logo-default" height="150" width="350" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t8-armario-42/blob/docs/docs/img/logo-default.png">

Escolhemos o nome **"Armário 42"** inspirado em duas ideias familiares para o público-alvo: 

**"Armário"** porque se remete à sensação de um espaço aconchegante e pessoal, e **"42"**, fazendo referência ao icônico número do *Guia do Mochileiro das Galáxias*, conhecido popularmente como "a resposta para a vida, o universo e tudo mais" na cultura geek. 🚀

## Integrantes

| [<img src="https://avatars.githubusercontent.com/u/147204305?v=4" width=115><br><sub>Alexandre Laguardia</sub>](https://github.com/AleeLaguardia) | [<img src="https://avatars.githubusercontent.com/u/108065159?s=400&u=efa4135ce3bd398a8e5d001d2b3c8b1632d20f2c&v=4" width=115><br><sub>Aliane Amaral</sub>](https://github.com/AlianeAmaral) | [<img src="https://avatars.githubusercontent.com/u/166177284?v=4" width=115><br><sub>Deuslano Veloso</sub>](https://github.com/Deuslano) | [<img src="https://avatars.githubusercontent.com/u/71663023?v=4" width=115><br><sub>Lucas Santos</sub>](https://github.com/Lucassantos-coder) | [<img src="https://avatars.githubusercontent.com/u/204406954?v=4" width=115><br><sub>Murilo Rezende</sub>](https://github.com/murilopuc2025) |
| :---: | :---: | :---: | :---: | :---: |

## Orientador

* Prof. Neil Paiva Tizzo

# Documentação

<ol>
<li><a href="docs/01-Documentação de Contexto.md"> Documentação de Contexto</a></li>
<li><a href="docs/02-Especificação do Projeto.md"> Especificação do Projeto</a></li>
<li><a href="docs/03-Metodologia.md"> Metodologia</a></li>
<li><a href="docs/04-Projeto de Interface.md"> Projeto de Interface</a></li>
<li><a href="docs/05-Arquitetura da Solução.md"> Arquitetura da Solução</a></li>
<li><a href="docs/06-Template Padrão da Aplicação.md"> Template Padrão da Aplicação</a></li>
<li><a href="docs/07-Programação de Funcionalidades.md"> Programação de Funcionalidades</a></li>
<li><a href="docs/08-Plano de Testes de Software.md"> Plano de Testes de Software</a></li>
<li><a href="docs/09-Registro de Testes de Software.md"> Registro de Testes de Software</a></li>
<li><a href="docs/10-Plano de Testes de Usabilidade.md"> Plano de Testes de Usabilidade</a></li>
<li><a href="docs/11-Registro de Testes de Usabilidade.md"> Registro de Testes de Usabilidade</a></li>
<li><a href="docs/12-Apresentação do Projeto.md"> Apresentação do Projeto</a></li>
<li><a href="docs/13-Referências.md"> Referências</a></li>
</ol>

# Código

<li><a href="src/README.md"> Código Fonte</a></li>

--- 

# Instruções de Utilização

**Link da Hospedagem:** http://armario42-app.azurewebsites.net/

Foram realizadas tentativas de hospedagem no link: https://pmv-ads-2025-1-e2-proj-int-t8-armario-42.onrender.com/ mas este não possibilitava o deploy em .NET, por isso foi retornado novamente para o link no Azure, que foi ajustado após essa troca e está funcionando com sucesso conforme instruções abaixo:

## 🚀 Requisitos

Antes de começar, você precisará ter instalado em sua máquina:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Git](https://git-scm.com/downloads)
- [Docker](https://www.docker.com/products/docker-desktop/) (opcional)

## 🔧 Configuração do Ambiente

### 1. Banco de Dados

1. Instale o PostgreSQL em sua máquina
2. Crie um banco de dados chamado `armario42`:
   ```sql
   CREATE DATABASE armario42;
   ```
3. Crie um usuário (ou use o padrão `postgres`):
   ```sql
   CREATE USER seu_usuario WITH PASSWORD 'sua_senha';
   GRANT ALL PRIVILEGES ON DATABASE armario42 TO seu_usuario;
   ```

### 2. Configuração do Projeto

1. Clone o repositório:
   ```bash
   git clone [url-do-repositorio]
   cd pmv-ads-2025-1-e2-proj-int-t8-armario-42
   ```

2. Configure o arquivo `src/Armario42/appsettings.Development.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Port=5432;Database=armario42;Username=seu_usuario;Password=sua_senha"
     }
   }
   ```

## 🏃‍♂️ Executando o Projeto

### Método 1: Execução Local

1. Entre na pasta do projeto:
   ```bash
   cd src/Armario42
   ```

2. Restaure as dependências:
   ```bash
   dotnet restore
   ```

3. Execute as migrations do banco de dados:
   ```bash
   dotnet ef database update
   ```

4. Inicie o projeto:
   ```bash
   dotnet run
   ```

5. Acesse o projeto em: `https://localhost:5001` ou `http://localhost:5000`

### Método 2: Usando Docker

1. Na pasta raiz do projeto, execute:
   ```bash
   docker build -t armario42 .
   ```

2. Execute o container:
   ```bash
   docker run -p 8080:8080 armario42
   ```

3. Acesse o projeto em: `http://localhost:8080`

## 📦 Estrutura do Projeto

```
src/
  └── Armario42/
      ├── Controllers/     # Controladores da aplicação
      ├── Models/         # Modelos de dados
      ├── Views/          # Views da aplicação
      ├── wwwroot/        # Arquivos estáticos
      └── Program.cs      # Ponto de entrada da aplicação
```

## 🔍 Troubleshooting

### Problemas comuns e soluções:

1. **Erro de conexão com o banco de dados**
   - Verifique se o PostgreSQL está rodando
   - Confirme se as credenciais no `appsettings.Development.json` estão corretas
   - Verifique se o banco de dados `armario42` existe

2. **Erro ao executar migrations**
   - Certifique-se de que o Entity Framework Core Tools está instalado:
     ```bash
     dotnet tool install --global dotnet-ef
     ```

3. **Erro ao executar o projeto**
   - Verifique se o .NET 8.0 SDK está instalado:
     ```bash
     dotnet --version
     ```
   - Limpe a solução e reconstrua:
     ```bash
     dotnet clean
     dotnet build
     ```

## 🤝 Contribuindo

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📝 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 📞 Suporte

Em caso de dúvidas ou problemas, abra uma issue no repositório do projeto.
