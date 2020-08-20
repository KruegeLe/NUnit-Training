# NUnit-Training in C#
---

### Neues Projekt hinzufügen:
#### 1. Projekt(Solution)-Ordner anlegen
````cmd
mkdir <project-directory>
cd <project-directory>
dotnet new sln
````

#### 2. Unterordner für die Source-Dateien erstellen
````cmd
cd <project-directory>
mkdir <directory>
````

#### 3. Sourceprojekt-ClassLibrary erstellen
````cmd
cd <directory>
dotnet new classlib
````

#### 4. ClassLibrary zur Solution hinzufügen
````cmd
cd ..
dotnet sln add <directory>/<directory>.csproj
````

#### 5. Ordner für Tests erstellen (konventionell: <directory>.Tests)
````cmd
mkdir <directory>.Tests
````

#### 6. NUnit im Testordner anlegen
````cmd
cd <directory>.Tests
dotnet new nunit
````

#### 7. ClassLibrary als Abhängigkeit hinzufügen
````cmd
dotnet add reference ../<directory>/<directory>.csproj
````

#### 8. Test zur Solution hinzufügen
````cmd
dotnet sln add ./<directory>.Tests.csproj
````

---


