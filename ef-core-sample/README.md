# Script com EF Core

O `dotnet-script` utiliza uma versão antiga do `Microsoft.Extensions.DependencyInjection`, então para executar programas que usam o `dotnet-ef` é preciso executar conforme abaixo.

```Shell
dotnet script --isolated-load-context main.csx 
```

# Referências

https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli

https://github.com/filipw/dotnet-script/issues/641