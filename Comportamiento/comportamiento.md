# Implementación del Patrón Observer

## Paso a paso

1. Crear la solución y proyectos:
```bash
dotnet new sln -o Comportamiento
cd Comportamiento
dotnet new classlib -o Observer.Domain
dotnet sln add ./Observer.Domain/Observer.Domain.csproj
dotnet new nunit -o Observer.Domain.Tests
dotnet sln add ./Observer.Domain.Tests/Observer.Domain.Tests.csproj
dotnet add ./Observer.Domain.Tests/Observer.Domain.Tests.csproj reference ./Observer.Domain/Observer.Domain.csproj