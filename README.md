# Desafio Challenge SPA

## Passos para executar

Subir o banco com Docker

```docker run --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=SQLl6820@" -p 1433:1433 -d mcr.microsoft.com/mssql/server```

Executar as migrations da API CLI
```> dotnet ef database update```

Executar a api
```> dotnet run```

Executar o Front no CLI
```> ng serve```
