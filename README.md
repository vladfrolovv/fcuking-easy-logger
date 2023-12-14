# Fcuking Easy Logger
<b>Stop Drowning in Logs!</b> :angry:

Are you tired of sifting through monotonous grey unorganized logs messages, trying to find the one you need? Do headaches from managing collections and objects logging plague your development process?

<b>Introducing Fcuking Easy Logger:</b> Your Unity Console Logs Savior!

Forget complex configurations and multi-line code. <b>Fcuking Easy Logger is a daring, simple and yet powerful solution</b> for you to output collections, matrices, simple messages, and even complex data structures with just a single line of code!

<p align="center">
  <video src="https://github.com/vladfrolovv/fcuking-easy-logger/assets/94003248/c977cc61-6ff0-4ba5-8859-f1e0bfdd9187" width="400"/>
</p>

## Installation
1. Download latest .unitypackage plugin version in [Installs/version](https://github.com/vladfrolovv/fcuking-easy-logger/blob/vfrolov/demo-client/Installs/fez-logger-0.0.1.unitypackage).
2. Drag and drop the package you just downloaded into desired folder (I suggest Plugins folder, so you project will stay organized).
3. Enjoy using tools I've described below :kiss: <br>

## Usage

:pencil2: <b>Replace standard Debug.Log() with this guy:</b>
```
LoggingUtilities.Log($"I am from Ez Logger. Look at my golden edges", LogColor.gold);
```
>[!NOTE]
>You can skip color selecting step in every available method, It will replace desired color with simple white


:black_nib: <b>Use him to output every known collection:</b>
```
LoggingUtilities.LogCollection($"Easy logging for List:", collection, LogColor.gold);
```
 <br>

:triangular_ruler: <b>Matrices now aren't big deal for Debugging</b>
```
LoggingUtilities.LogMatrix($"Hey! I'm matrix", matrix, LogColor.chartreuse);
```
<br>

:book: <b>Even Hexagonal matrices aren't a big deal for Fcuking Easy Logger. Now you can easily develop your hexagonal strategies :D</b>
```
LoggingUtilities.LogHexagonalMatrix($"Easy Hex logging for Matrix:", hexMatrix, LogColor.tomato);
```
<br>

## Afterward
>[!IMPORTANT]
>Hope you enjoy using Fcuking Easy Logger as much as I enjoyed creating it. It's gonna make your Unity dev life a whole lot less... complicated. </br>
>Fcuking Easy Logger is just getting started, and I need your help to make it even fcuking awesome. Share your feedback and let's build something truly badass.
