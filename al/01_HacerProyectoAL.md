## Requisitos

- **Docker** con contenedores de Windows
- Extension de VSCode '**AL Language extension for Microsoft Dynamics 365 Business Central**'
- Usar **ultima version** de Business Central
- Claves: `admin - P@ssw0rd`

## Iniciar un nuevo proyecto AL

- `ctrl+shift+p` -> Abrir la paleta de comandos
- `Al: Go!` -> Iniciar un nuevo proyecto
- Editar `launch.json`

```al
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": "WDTU Radio Station DAM2B 25/26",       // Nombre de mi proyecto
            "request": "launch",                        
            "type": "al",                               
            "environmentType": "OnPrem",
            "server": "http://bcjoyfedam2b2526",            // Esta es la url del endpoint
            "serverInstance": "BC",                         // Nombre de mi instacia de BC
            "authentication": "UserPassword",               // Tipo de autenticacion (Windows, Userpassword, etc...)
            "startupObjectId": 22,                          // Es el objeto que aparece al publicar mi proyecto 
            "startupObjectType": "Page",                    // Es el tipo de objeto que aparece al publicar
            "breakOnError": "All",
            "launchBrowser": true,
            "enableLongRunningSqlStatements": true,
            "enableSqlInformationDebugger": true,
            "tenant": "default",
            "usePublicURLFromServer": false,
            "schemaUpdateMode": "ForceSync"                 // Esta propiedad me permite modificar la estructura de la base de datos. Se salta la advertencia
        }
    ]
}
```
- Editar `app.json`
```al
{
  "id": "82d835e4-2246-4848-a9ea-50b6274f017b",
  "name": "WDTU-DAM2B-25-26",
  "publisher": "DAM2B",
  "version": "1.0.0.0",
  "brief": "",
  "description": "",
  "privacyStatement": "",
  "EULA": "",
  "help": "",
  "url": "",
  "logo": "",
  "dependencies": [],
  "screenshots": [],
  "platform": "1.0.0.0",
  "application": "24.0.0.0",
  "idRanges": [
    {
      "from": 50100,
      "to": 50249
    }
  ],
  "resourceExposurePolicy": {
    "allowDebugging": true,
    "allowDownloadingSource": true,
    "includeSourceInSymbolFile": true
  },
  "runtime": "16.0",
  "features": [
    "NoImplicitWith"
  ]
}
```
- `Al: Download Symbols` -> Descargamos los simbolos necesarios para publicar
- `Al: Publishing without debbuging` -> Publicamos el **Proyecto**

## Pasos a seguir

- Crear una carpeta llamada `src`
- Dentro de `src` crea las subcarpetas:
    - `pages`
    - `reports`
    - `tables`
- Para crear una pagina escribimos `tpage`
- Para crear un report escribimos `treport`
- Para crear una tabla escribimos `ttable`