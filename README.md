# gestionaYoutube-dl
Interfaz gráfica para la descarga de ficheros escrito en Visual Basic (.NET Framework) mediante herramientas externas. Permite la descarga de múltiples archivos.
## Requisitos

* Necesario .Net Framework 4.5 o posterior
*  Permitir a la aplicación escribir en ciertas rutas (solo Windows 10 y dependiendo de la ruta en la que guardar los ficheros debido a la protección anti-ransomware)
*  [YoutubeDl](https://youtube-dl.org/) y [ffmpeg](https://ffmpeg.org/) (los descarga el programa ~~automáticamente~~ (bug en revisión)). Se pueden descargar manualmente desde el [menú de configuración](#descargaFicheros)

## Interfaz principal
La interfaz se compone de una cuadrícula (dataGridView) de una sola columna y tantas filas como archivos se deseen descargar (se generan automáticamente). 
También dispone de un menú de configuración y un manual de ayuda.

El programa permite escoger entre descargar únicamente el audio o el audio y vídeo (en un solo archivo, por ello es necesario el uso de _ffmpeg_)

![image](https://user-images.githubusercontent.com/51420640/109304714-f0e76700-783c-11eb-9692-349d53d46ce1.png)

## Menú de configuración
Permite escoger las siguientes opciones: 
1. Generar logs: guarda el log devuelto por el programa de descarga (youtubedl)
2. Actualizaciones automáticas (sin funcionalidad por el momento)
3. Cambiar la ruta de las descargas
4. Localizar ejecutables: por el momento no tiene funcionalidad. Permitirá especificar la carpeta que contiene los ficheros necesarios (ffmpeg y youtubedl)
<a name="descargaFicheros"></a>
5. Descargar ficheros: permite descargar los ficheros de nuevo


![image](https://user-images.githubusercontent.com/51420640/109304906-3efc6a80-783d-11eb-9d6d-38f8edd0c05e.png)

## Menú de ayuda 
Muestra un pdf con un breve manual que explica cómo manejar el programa.

![image](https://user-images.githubusercontent.com/51420640/109305265-c21dc080-783d-11eb-9538-f9fbdafb5e7d.png)

## Sobre las descargas
El programa es únicamente una forma de facilitar el uso de [_youtubedl_](https://youtube-dl.org/) y [_ffmpeg_](https://ffmpeg.org/) para los usuarios que no tienen conocimientos mediante una interfaz gráfica simple (VB .Net Windows Forms). 

El listado de las web desde las que permite descargar se puede encontrar [aquí](https://github.com/ytdl-org/youtube-dl/blob/master/docs/supportedsites.md).

# Tareas pendientes
1. Corregir las descargas automáticas (primera vez que se ejecuta el programa)
2. Añadir actualizaciones automáticas
3. Permitir cambiar la carpeta con los ejecutables necesarios
4. Permitir mútiples descargas de manera simultánea
5. Mejorar el rendimiento (descargar el hilo principal)
6. Permitir cancelar la descarga de un una url o todas a la vez

## Built With
 [Visual Studio 2019 Community Edition](https://visualstudio.microsoft.com/es/downloads/) - IDE utilizado

## Agradecimientos
- A mi padre, por darme la idea
- A todos mis compañeros de trabajo y especialmente, a Jose Luis
