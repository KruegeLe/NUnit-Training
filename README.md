# NUnit-Training in C#
---

### Neues Projekt hinzufügen:
#### 1. Projekt(Solution)-Ordner anlegen
##### 1.1 Ordner anlegen: 
````cmd
mkdir <project-directory>
````
##### 1.2 In Ordner wechseln: 
````cmd
cd <project-directory>
````   
##### 1.3 Solution erstellen: 
````cmd
dotnet new sln
````

#### 2. Unterordner für die Source-Dateien erstellen
````cmd
mkdir <project-directory>/<directory>
````

#### 3. Sourceprojekt-ClassLibrary erstellen
##### 3.1 In Ordner wechseln: 
````cmd
cd <project-directory>/<directory>
````
##### 3.2 Class Library erstellen: 
````cmd
dotnet new classlib
````

#### 4. ClassLibrary zur Solution hinzufügen
##### 4.1 In Überordner wechseln:
````cmd
cd ..
````
##### 4.2 Projekt zur Solution hinzufügen
````cmd
dotnet sln add <directory>/<directory>.csproj
````

#### 5. Ordner für Tests erstellen (konventionell: \<directory>.Tests)
````cmd
mkdir <directory>.Tests
````

#### 6. NUnit im Testordner anlegen
##### 6.1 In Ordner wechseln: 
````cmd
cd <directory>.Tests
````
##### 6.2 NUnit bereitstellen:
````cmd
dotnet new nunit
````

#### 7. Class Library als Abhängigkeit hinzufügen
````cmd
dotnet add reference ../<directory>/<directory>.csproj
````

#### 8. Test zur Solution hinzufügen
````cmd
dotnet sln add ./<directory>.Tests.csproj
````
---


