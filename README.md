# Gæt et tal

(Example project in Danish for teaching C# fundamentals, used as part of Danish non-profit organization [Coding Pirates](https://codingpirates.dk/in-english))

Simpelt eksempel projekt for introduktion til C#

## Påkrævede værktøjer

Enten

* Visual Studio Community: https://visualstudio.microsoft.com/vs/community

eller

* .NET SDK: https://dotnet.microsoft.com/en-us/download/dotnet/7.0
* F.eks. Visual Studio Code: https://code.visualstudio.com/download

## Kom i gang

Visual Studio Community:

 * Opret et nyt C# projekt

Visual Studio Code:

* Kør følgende fra kommandolinje:
  ```
  mkdir GuessANumber
  cd GuessANumber
  dotnet new console
  ```

Du kan nu åbne `Program.cs` filen i Visual Studio Code

## Kør spillet

Visual Studio Community:

* Tryk F5 eller afspil knappen

Visual Studio Code:

* Kør følgende fra kommandolinje
  ```
  dotnet run
  ```

## Fremgangsmåde

1. Opret projektet og kør. Skulle gerne skrive "Hello, World!"
1. Implementer `GuessANumberGame` klasse og `WriteWelcomeMessage()` metode
   - Forklar lidt om klasser
1. `FindSecretNumber()` metode, med tilhørende `secretNumber` variabel og `Max` konstant
   - Forklar om metoder, variable og scope
1. `GetUserGuess()` metode
   - Metode der returnerer værdi
   - Skriv værdien ud, inden vi går videre
1. Resten af programmet, med `do {} while` løkke indtil man har gættet tallet.
