# Gestión de Materiales

## Técnologias
- Net Core 3.1.100 LTS
- Entity Framework Core 3.1
- Visual Studio 2019 16.4
- MySQL 5.7.24
- MySQL Workbench 6.3 CE


## Configuración

### Base de datos
- Abrir el **Workbench**
- Conectarse al servidor de base de datos (local ó remoto por ejemplo win2012)
- Para crear las bases de datos **sgm_usuarios** y **sgm_oficinatecnica** se necesita levantar los respectivos backups de las bases
- Para ello ir al menu **Server** -> **Data Import** 
- Seleccionar la opción **Import from Self-Contained File** y en el botón de los **...** ubicado al final a la derecha, seleccionar el archivo **sgm_usuarios.sql** -> hacer click en el botón **Aceptar** luego hacer click en el botón **Start Import** ubicado en la parte inferior derecha de la pantalla
- Realizar el mismo procedimiento para el archivo **sgc_oficinatecnica.sql**
- Verificar que en la sección **SCHEMAS** aparezcan las bases de datos **sgm_usuarios** y **sgm_oficinatecnica**

### Software
- Abrir el proyecto en **Visual Studio 2017/2019**
- Modificar los **ConnectionStrings** con los datos correspondientes del archivo de configuración **appsettings.json** ubicado en el proyecto **GestionMateriales.Mvc**
- Ejecutar el proyecto **GestionMateriales.Mvc** (CTRL + F5)

**Nota:** ejemplo del **appsettings.json**

```json
  "ConnectionStrings": {
    "sgm_usuarios": "server=SERVER_IP_O_NOMBRE_DOMINIO;database=NOMBRE_BASE_DE_DATOS;user=USUARIO;password=CONTRASEÑA",
    "sgm_oficinatecnica": "server=SERVER_IP_O_NOMBRE_DOMINIO;database=NOMBRE_BASE_DE_DATOS;user=USUARIO;password=CONTRASEÑA"
  },
  "Serilog": {
    "Using": [ "Serilog.Sinks.MySQL", "Serilog.Sinks.File" ],
    "MinimumLevel": "Debug",
    "WriteTo": [
      {
        "Name": "MySQL",
        "Args": {
          "connectionString": "server=SERVER_IP_O_NOMBRE_DOMINIO;database=NOMBRE_BASE_DE_DATOS;user=USUARIO;password=CONTRASEÑA",
          "tableName": "Logs",
          "autoCreateSqlTable": true
        }
      },
      {
        "Name": "File",
        "Args": {
          "path": "Logs/log.txt",
          "rollingInterval": "Day"
        }
      }      
    ]
  },
```

## Publicar

### Build Local

### Deploy Remoto
