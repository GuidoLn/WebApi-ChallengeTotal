# WebApi-ChallengeTotal

Bienvenido al repositorio de WebApi-ChallengeTota, una API RESTful construida con .NET Core. Esta API le permitirá interactuar con la base de datos ScriptDB.

## Requisitos previos

Antes de comenzar, asegúrese de tener instalado lo siguiente en su máquina:

1. [.NET Core SDK](https://dotnet.microsoft.com/download) (versión 3.1 o superior)
2. [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads) (Express, Developer o cualquier otra edición)

## Pasos para levantar la aplicación

1. **Clonar el repositorio**

   Abra una terminal y ejecute el siguiente comando para clonar el repositorio de WebApi-ChallengeTota: git clone https://github.com/GuidoLn/WebApi-ChallengeTotal.git
   
  
2. **Configurar la cadena de conexión a la base de datos**

Navegue hasta el archivo `appsettings.json`, dentro de `appsettings.Development.json` en el directorio raíz del proyecto. Modifique la cadena de conexión `DefaultConnection` en la sección `ConnectionStrings` para que apunte a su instancia de SQL Server:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=nombre_de_instancia;Database=ScriptDB;User Id=usuario;Password=contraseña;"
}

**Ejecutar el script de la base de datos**

Abra SQL Server Management Studio (SSMS) y conéctese a su instancia de SQL Server. Abra el archivo ScriptDB.sql ubicado en la carpeta Database del repositorio clonado y ejecute el script para crear la base de datos y las tablas necesarias.

**Restaurar paquetes NuGet y compilar la solución**

Vuelva a la terminal y navegue hasta el directorio del proyecto clonado. Ejecute los siguientes comandos para restaurar los paquetes NuGet:

cd WebApi-ChallengeTota
dotnet restore


**Ejecutar la aplicación**

Ejecute la aplicacion mediante Visual Studio 2022, haciendo click secundario en el proyecto y eligiendo la opcion "Depurar, iniciar depuracion"


Una vez que la aplicación esté en ejecución, puede acceder a la API a través de la dirección https://localhost:"puerto"/.

**Documentación de la API**

Puede encontrar la documentación de la API y probar los diferentes endpoints utilizando Swagger. Navegue a https://localhost:"puerto"/swagger en su navegador web después de iniciar la aplicación.

¡Felicitaciones! Ahora tiene la aplicación WebApi-ChallengeTota en ejecución y está listo para interactuar con la base de datos ScriptDB.

