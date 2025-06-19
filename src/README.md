# Instruções de Utilização

**Link da Hospedagem:** http://armario42-app.azurewebsites.net/

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
