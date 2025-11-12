# 💪 BlazorBeFit

> Twój osobisty asystent treningowy w technologii Blazor

![Blazor](https://img.shields.io/badge/Blazor-512BD4?style=for-the-badge&logo=blazor&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![SQLite](https://img.shields.io/badge/SQLite-07405E?style=for-the-badge&logo=sqlite&logoColor=white)

## 📋 Opis projektu

BlazorBeFit to aplikacja webowa stworzona w **ASP.NET Core Blazor**, która umożliwia śledzenie postępów treningowych na siłowni. Aplikacja wykorzystuje **Entity Framework Core** z bazą danych **SQLite** oraz **ASP.NET Core Identity** do zarządzania użytkownikami i autoryzacji.

## ✨ Funkcjonalności

### 🔐 System Użytkowników
- **Publiczna rejestracja** - każdy może utworzyć konto użytkownika
- **System ról** - Administrator i User
- **Bezpieczne logowanie** - ASP.NET Core Identity
- **Panel administracyjny** - tworzenie użytkowników i administratorów

### 🏋️ Zarządzanie Treningami
- **Typy ćwiczeń** - baza ćwiczeń siłowych (tylko dla administratorów)
- **Sesje treningowe** - planowanie i śledzenie treningów z datą/czasem rozpoczęcia i zakończenia
- **Wpisy treningowe** - szczegółowe zapisy: obciążenie, serie, powtórzenia
- **Walidacja danych** - kontrola poprawności wprowadzanych danych

### 📊 Funkcje dodatkowe
- **Responsywny interfejs** - Bootstrap 5
- **Ikony** - Bootstrap Icons

## 🛠️ Technologie

- **ASP.NET Core Blazor 9.0** (Interactive Server)
- **Entity Framework Core 9.0**
- **SQLite** - lokalna baza danych
- **ASP.NET Core Identity** - uwierzytelnianie i autoryzacja
- **Bootstrap 5** - interfejs użytkownika
- **Bootstrap Icons** - ikony

## 📦 Wymagania

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Przeglądarka internetowa (Chrome, Edge, Firefox)

## 🚀 Instalacja i uruchomienie

1. **Sklonuj repozytorium:**
```bash
git clone https://github.com/vienox/BlazorBeFit.git
cd BlazorBeFit/BlazorBeFit
```

2. **Przywróć pakiety NuGet:**
```bash
dotnet restore
```

3. **Uruchom aplikację:**
```bash
dotnet run
```

4. **Otwórz przeglądarkę:**
```
http://localhost:5059
```

## 👤 Domyślne konto administratora

Po pierwszym uruchomieniu aplikacja automatycznie tworzy konto administratora:

- **Email:** `admin@befit.pl`
- **Hasło:** `Admin123!`

## 📁 Struktura projektu

```
BlazorBeFit/
├── Components/
│   ├── Account/              # Komponenty uwierzytelniania
│   ├── Layout/               # Layout aplikacji (NavMenu, MainLayout)
│   └── Pages/                # Strony Blazor
│       ├── Home.razor        # Strona główna
│       ├── Login.razor       # Logowanie
│       ├── Signup.razor      # Rejestracja publiczna
│       ├── Register.razor    # Rejestracja przez admina
│       ├── ExerciseTypes.razor
│       ├── TrainingSessions.razor
│       └── TrainingEntries.razor
├── Data/
│   └── ApplicationDbContext.cs  # Kontekst EF Core
├── Models/
│   ├── ExerciseType.cs       # Model typu ćwiczenia
│   ├── TrainingSession.cs    # Model sesji treningowej
│   └── TrainingEntry.cs      # Model wpisu treningowego
├── Migrations/               # Migracje Entity Framework
├── wwwroot/                  # Pliki statyczne
├── app.db                    # Baza danych SQLite
└── Program.cs                # Konfiguracja aplikacji
```

## 🗄️ Modele danych

### ExerciseType (Typ ćwiczenia)
- `Id` - identyfikator
- `Name` - nazwa (2-100 znaków)

### TrainingSession (Sesja treningowa)
- `Id` - identyfikator
- `Start` - data i czas rozpoczęcia
- `End` - data i czas zakończenia
- Walidacja: data rozpoczęcia nie może być późniejsza niż zakończenia

### TrainingEntry (Wpis treningowy)
- `Id` - identyfikator
- `ExerciseTypeId` - FK do typu ćwiczenia
- `TrainingSessionId` - FK do sesji treningowej
- `Weight` - obciążenie (0-1000 kg)
- `Sets` - liczba serii (1-100)
- `Repetitions` - liczba powtórzeń (0-1000)

## 🔑 Role użytkowników

### Administrator
- Pełny dostęp do aplikacji
- Zarządzanie typami ćwiczeń (CRUD)
- Tworzenie nowych użytkowników i administratorów
- Wszystkie funkcje użytkownika

### User (Użytkownik)
- Tworzenie i edycja sesji treningowych
- Tworzenie i edycja wpisów treningowych
- Brak dostępu do zarządzania typami ćwiczeń

## 🎨 Interfejs

Aplikacja posiada nowoczesny, responsywny interfejs z:
- Gradientowym hero section
- Kartami funkcjonalności z animacjami hover
- Sekcją statystyk
- Adaptacyjnym menu (różne widoki dla ról)
- Bootstrap Icons

## 🔧 Konfiguracja

Plik `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "DataSource=app.db;Cache=Shared"
  }
}
```

## 📝 Licencja

Ten projekt został stworzony w celach edukacyjnych.

## 👨‍💻 Autor

[vienox](https://github.com/vienox)

## 🤝 Współpraca

Zgłaszanie błędów i sugestie mile widziane! Otwórz Issue lub Pull Request.

---

**Zbudowane z ❤️ używając Blazor i .NET 9.0**
