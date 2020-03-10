---
title: PhantomLimb
revealOptions:
    transition: 'zoom'
    controls: true
---
# Phantom Limb
<!-- .slide: data-background-video="https://cdn.flixel.com/flixel/40znjlquy1t6aux32ycs.hd.mp4" data-background-video-loop="loop" data-background-video-muted -->
---
# ¿Quiénes somos?
<div style="display: flex" class="dark-bg fragment">
    <div style="width:49%">
        <span>Alberto Mareca</span>
    <img style="width: 300px;" src="assets/images/amareca.png" alt="mareca">  
  </div>
  <div style="width:49%">
    <span>Guillermo Sesé</span>
    <img style="width: 300px;" src="assets/images/gsese.png" alt="sese">  
  </div>
</div>
Note: **Estudiantes** del Grado Superior y **trabajadores** de Deloitte.
---
# Nuestro proyecto
<!-- .slide: data-background-video="https://cdn.flixel.com/flixel/yh4hh7nevbdxewyuuxiy.hd.mp4" data-background-video-loop="loop" data-background-video-muted -->
Note: La idea surge de un TFG del área de *fisioterapia* para la **Universidad San Jorge**.
----
## ¿Qué es el miembro fantasma?
<img style="background:none; border:none; box-shadow:none; width: 45%;"
  src="assets/images/miembro_fantasma.jpg" alt="miembro fantasma">
Note: * **Sensación** que tienen **algunos** pacientes al sufrir una amputación.
*  El dolor se manifiesta como **presión, picazón, calambres, quemaduras, choque eléctrico, roces, arañazos, puñaladas** y otros términos difíciles de explicar.
----
## ¿Qué terapia se emplea?
<div style="width: 100%" class="dark-bg fragment">
<img style="background:none; border:none; box-shadow:none; width: 45%;"
  src="https://giant.gfycat.com/SleepyMealyAnnelida.gif" alt="brazo fantasma">
<img style="background:none; border:none; box-shadow:none; width: 45%;"
  src="https://giant.gfycat.com/WeeEagerBonobo.gif" alt="pierna fantasma">
</div>
Note: * Técnica del **espejo**.
* Engañando a las **neuronas espejo** del cerebro. *(Estas neuronas son las que nos permiten __imitar emociones, gestos, etc__)*
----
## ¿Qué hemos hecho?
Note: * La idea es aplicar las **nuevas tecnologías** a una técnica *"tradicional"*. 
* Llevar a un **entorno virtual** el **entorno tradicional**.
* Fomentar la **recuperación** del paciente mediante **juegos**.
---
<h1 style="color: #272822">HERRAMIENTAS</h1>
<!-- .slide: data-background-video="https://cdn.flixel.com/flixel/imw4b2wdt87wnj4h863h.hd.mp4" data-background-video-loop="loop" data-background-video-muted -->
Note: Se van a indicar **dos áreas** de trabajo:
* La **electrónica**
* El **diseño 3D**
----
## Electrónica
<!-- .slide: data-background-video="https://cdn.flixel.com/flixel/ts1p4x68ezcwbofpgaw2.hd.mp4" data-background-video-loop="loop" data-background-video-muted -->
Note: Se engloba en *electrónica* todo aquello relacionado a la **obtención de datos** y tratamiento de estos.
**IMPORTANTE MENCIONAR:** Las **herramientas de software** y elementos utilizados son **todas gratuitas** (o versiones gratuitas de estas)

----
<h3>Sensores MyoWare</h3>
<img style="background:none; border:none; box-shadow:none; width: 500px;"  src="assets/images/sensor.png" alt="sensor">
Note: * De **pequeño tamaño**. 
* Permiten tratar los datos en *crudo*.
* Se les puede introducir cables de electrodos **externos**.
----
<h3>Arduino UNO</h3>
<img style="background:none; border:none; box-shadow:none; width: 500px;" src="assets/images/arduino.png" alt="arduino">
Note: Microcontrolador **muy popular** y de **bajo coste** con entradas/salidas analógicas y digitales.
----
<h3>Lenguaje C</h3>
<img style="background:none; border:none; box-shadow:none; width: 500px; margin-top: -20px;" src="assets/images/lenguaje_C.png" alt="lenguaje C">
Note: **NO** es **C** como tal, sino archivos con extensión **.ino** que están basados en C.
----
<h1 style="color: #272822; text-shadow: -1px -1px 250px #FFF, 1px -1px 250px #FFF, -1px 1px 250px #FFF, 1px 1px 250px #FFF;">
  DISEÑO</h1>
<!-- .slide: data-background-video="https://cdn.flixel.com/flixel/epccdlfutqekbws2yszf.hd.mp4" data-background-video-loop="loop" data-background-video-muted -->
Note: Se engloba en *diseño* todo aquello relacionado con **mostrar información** en pantalla.
----
<h3>Blender</h3>
<img style="background:none; border:none; box-shadow:none; width: 800px;"  src="https://giant.gfycat.com/NastyIcyHind.gif" alt="blender">
Note: Se utilizó para añadir **_cuerpo_ (rig)** al asset 3D que ya se tenía.
----
<h3>Unity</h3>
<img style="background:none; border:none; box-shadow:none; width: 1000px; margin-top: -20px;"  src="assets/images/unity.png" alt="unity">
Note: Motor gráfico. Utilizada *versión personal*.
----
<h3>C#</h3>
<img style="background:none; border:none; box-shadow:none; width: 750px; margin-top: -35px;"  src="assets/images/lenguaje_CSharp.png" alt="lenguaje c#">
Note: Programado con Visual Studio (perteneciente a Microsoft) en su *versión Community*.
---
<h1 style="color: white; text-shadow: -1px -1px 100px #000, 1px -1px 100px #000, -1px 1px 100px #000, 1px 1px 100px #000;">
  FUNCIONAMIENTO</h1>
Note: Se explicará tanto el funcionamiento **electrónico** como el funcionamiento del apartado de **diseño**.
<!-- .slide: data-background-video="https://cdn.flixel.com/flixel/eb8823rs4soz8p6hdmpl.hd.mp4" data-background-video-loop="loop" data-background-video-muted -->
----
## Lectura de datos
<!-- .slide: data-background-video="https://cdn.flixel.com/flixel/7a0iejyutuuc9p8rdss3.hd.mp4" data-background-video-loop="loop" data-background-video-muted -->
----
### Sensor muscular
<img style="background:none; border:none; box-shadow:none; width: 800px;" src="https://giant.gfycat.com/UnkemptPeskyLeopardseal.gif" alt="instrucciones sensor">
Note: * 3 Electrodos: Medio, Fin, Referencia
  * **Medio**: En medio del músculo con la **misma dirección que éste** 
  * **Fin**: Desde el medio **hasta el final con la misma dirección**
  * **Referencia**: En un **hueso o grupo muscular ajeno** a los que se están midiendo
----
### Arduino
<img style="background:none; border:none; box-shadow:none; width: 800px;" src="https://giant.gfycat.com/ShimmeringTimelyCatbird.gif" alt="lectura de datos arduino">
Note: * **Corre** el programa **continuamente** desde que ésta se enciende. 
* **Lee los datos** desde el pin al que se conecta el sensor.
* Los **envía** por el **puerto serie (USB)** al ordenador.
----
### Conexión al PC
<img style="background:none; border:none; box-shadow:none; width: 400px;" src="https://media.giphy.com/media/9s6BcL4XSgzuM/giphy.gif" alt="lectura de datos arduino">
Note: **Conectar el USB** del arduino al ordenador y **lanzar la aplicación**
----
<h2 style="color: white; text-shadow: -1px -1px 125px #000, 1px -1px 125px #000, -1px 1px 125px #000, 1px 1px 125px #000;">
  APLICACIÓN</h2>
<!-- .slide: data-background-video="https://cdn.flixel.com/flixel/esylem7anpznfzxbcul2.hd.mp4" data-background-video-loop="loop" data-background-video-muted -->
----
<table>
  <tr>
    <td style="text-align: center; border: 0;">
      Menú inicial
      <img style="background:none; border:none; box-shadow:none;" src="https://giant.gfycat.com/ConfusedOpenCanine.gif" alt="menú inicial">
    </td>
    <td style="text-align: center; border: 0;">
      Menú ajustes
      <img style="background:none; border:none; box-shadow:none;" src="https://giant.gfycat.com/EnchantedIgnorantGodwit.gif" alt="menú ajustes">
    </td>
  </tr>
  <tr>
    <td style="text-align: center; border: 0;">
      Modo entreno
      <img style="background:none; border:none; box-shadow:none;" src="https://giant.gfycat.com/ComplicatedZestyAnnelid.gif" alt="modo entreno">
    </td>
    <td style="text-align: center; border: 0;">
      Modo libre
      <img style="background:none; border:none; box-shadow:none;" src="https://giant.gfycat.com/LinearPaltryAdeliepenguin.gif" alt="modo libre">
    </td>
  </tr>
</table>
Note: Remarcar que es una aplicación **principalmente** hecha para PC.
El *modo libre* es el *"campo de pruebas"*, se ha centrado el desarrollo en el **apartado visual y práctico del _juego_**.
---
<h1 style="color: white; text-shadow: -1px -1px 800px #000, 1px -1px 800px #000, -1px 1px 800px #000, 1px 1px 800px #000; margin-top: -150px">Conclusiones</h1>
<!-- .slide: data-background-video="https://cdn.flixel.com/flixel/ypaoqdr7wuda8rv3dvia.hd.mp4" data-background-video-loop="loop" data-background-video-muted -->
Note: * Proyecto con ciertas dificultades:
  * Áreas desconocidas: **tema de SALUD**.
  * Ha habido que aprender bastante e informarse: **Electrónica y Diseño**.
  * Se ha sentido falta de comunicación.
---
<h1 style="color: #272822; margin-top: -200px;">¿Dudas?</h1>
<!-- .slide: data-background-video="https://cdn.flixel.com/flixel/5363uhabodwwrzgnq6vx.hd.mp4" data-background-video-loop="loop" data-background-video-muted -->
---
<h2 style="color: white; text-shadow: -1px -1px 25px #000, 1px -1px 25px #000, -1px 1px 25px #000, 1px 1px 25px #000;">MUCHAS GRACIAS</h2>
<img style="background:none; border:none; box-shadow:none;" src="https://media.giphy.com/media/3aRilV33fWkUw/giphy.gif" alt="agradecimiento" >
<div style="position: absolute; right: 20px; top: 450px;">
  <div>Guillermo Sesé
    <span style="font-size: 0.7em; margin-left: 20px;">
      <img style="background:none; border:none; box-shadow:none; width:30px; margin: -8px 0px;" src="assets/images/github.png" alt="github">
      <a style="text-decoration: underline; color: #FFF;" href="https://github.com/ekzGuille/" target="_blank">ekzGuille</a> 
    </span>
  </div>
  <div>Alberto Mareca
    <span style="font-size: 0.7em; margin-left: 20px;">
      <img style="background:none; border:none; box-shadow:none; width:30px; margin: -8px 0px;" src="assets/images/github.png" alt="github">
      <a style="text-decoration: underline; color: #FFF;" href="https://github.com/amareca/" target="_blank">Ag3nte</a> 
    </span>
  </div>
  <div>
    <span style="font-size: 0.7em; margin-left: 20px;">
      <img style="background:none; border:none; box-shadow:none; width:30px; margin: -8px 0px;"
        src="assets/images/github.png" alt="github">
      <a style="text-decoration: underline; color: #FFF;" href="https://github.com/ekzGuille/PhantomLimb-RA" target="_blank">Proyecto en Github</a>
    </span>
  </div>
</div>
<!-- .slide: data-background-video="https://cdn.flixel.com/flixel/6lg4grqag3u8qciyk7p8.hd.mp4" data-background-video-loop="loop" data-background-video-muted -->
