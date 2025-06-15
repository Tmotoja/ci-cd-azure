# ci-cd-azure

To repozytorium służy do nauki automatyzacji procesów CI/CD z wykorzystaniem GitHub Actions, aplikacji internetowej opartej na platformie .NET oraz środowiska chmurowego Microsoft Azure. Projekt demonstruje, jak zintegrować te technologie w celu efektywnego wdrażania i zarządzania aplikacjami w chmurze.

## Technologie użyte w projekcie

- **.NET 8.0**: Platforma do budowy aplikacji internetowych.
- **GitHub Actions**: Narzędzie do automatyzacji procesów CI/CD.
- **Microsoft Azure**: Środowisko chmurowe do hostowania aplikacji.
- **ASP.NET Core MVC**: Wzorzec projektowy używany do tworzenia aplikacji internetowych.
- **Kestrel**: Wbudowany serwer sieciowy dla aplikacji ASP.NET Core.

## Funkcjonalności projektu

- Automatyczne budowanie i testowanie aplikacji przy użyciu GitHub Actions.
- Wdrażanie aplikacji na platformę Azure App Service.
- Obsługa HTTPS i konfiguracja routingu w aplikacji ASP.NET Core.
- Przykładowa aplikacja z kontrolerem i widokami.

## Jak uruchomić projekt lokalnie?

1. **Zainstaluj wymagane narzędzia**:
   - [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
   - Git

2. **Sklonuj repozytorium**:
   ```bash
   git clone https://github.com/your-username/ci-cd-azure.git
   cd ci-cd-azure/MeritoWebApp
   ```

3. **Przywróć zależności**:
   ```bash
   dotnet restore
   ```

4. **Uruchom aplikację**:
   ```bash
   dotnet run
   ```

5. **Otwórz przeglądarkę** i przejdź pod adres:
   ```
   https://localhost:5001
   ```

## Jak skonfigurować CI/CD?

1. **GitHub Actions**:
   - W repozytorium znajduje się plik `.github/workflows/ci-cd.yml`, który definiuje proces budowania, testowania i wdrażania aplikacji.

2. **Microsoft Azure**:
   - Skonfiguruj Azure App Service i połącz je z repozytorium GitHub.
   - Upewnij się, że masz zainstalowane narzędzie [Azure CLI](https://learn.microsoft.com/en-us/cli/azure/install-azure-cli).

3. **Wdrażanie**:
   - Po zatwierdzeniu zmian w głównej gałęzi repozytorium, GitHub Actions automatycznie wdroży aplikację na Azure.

## Struktura projektu

- `MeritoWebApp/`: Główna aplikacja ASP.NET Core.
- `.github/workflows/`: Konfiguracja GitHub Actions.
- `README.md`: Dokumentacja projektu.

## Wymagania systemowe

- System operacyjny: Windows, macOS lub Linux
- .NET SDK 8.0 lub nowszy
- Konto Microsoft Azure

## Przydatne zasoby

Aby lepiej zrozumieć technologie użyte w tym projekcie, zapoznaj się z poniższymi materiałami:

- [Dokumentacja .NET](https://learn.microsoft.com/en-us/dotnet/)
- [GitHub Actions Documentation](https://docs.github.com/en/actions)
- [Microsoft Azure Documentation](https://learn.microsoft.com/en-us/azure/)
- [ASP.NET Core Documentation](https://learn.microsoft.com/en-us/aspnet/core/)
- [Kestrel Web Server Overview](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel)

Te zasoby pomogą Ci zgłębić wiedzę na temat budowy, testowania i wdrażania aplikacji w środowisku chmurowym.

## Autorzy

Projekt został stworzony w celach edukacyjnych przez Tmotoja. Jeśli masz pytania, smialo skontaktuj sie przez mail suwak-obwinienie.9n@icloud.com.
