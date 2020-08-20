# NUnit-Training in C#
---

### Neues Projekt hinzufügen:
#### 0. Gänzlich neues Projekt(Solution) anlegen
````cmd
mkdir <project-directory>
cd <project-directory>
dotnet new sln
````

#### 1. Unterordner für die Source-Dateien erstellen
````cmd
mkdir <directory>
````

#### 2. Sourceprojekt-ClassLibrary erstellen
````cmd
cd <directory>
dotnet new classlib
````

#### 3. ClassLibrary zur Sloution hinzufügen
````cmd
cd ..
dotnet sln add <directory>/<directory>.csproj
````

#### 4. Ordner für Tests erstellen (konventionell: <directory>.Tests)
````cmd
mkdir <directory>.Tests
````

#### 5. NUnit im Testordner anlegen
````cmd
cd <directory>.Tests
dotnet new nunit
````

#### 6. ClassLibrary als Abhängigkeit hinzufügen
````cmd
dotnet add reference ../<directory>/<directory>.csproj
````

#### 7. Test zur Solution hinzufügen
````cmd
dotnet sln add ./<directory>.Tests.csproj
````

