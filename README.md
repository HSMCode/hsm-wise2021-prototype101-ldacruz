# Project Prototype 101

This is the course repository to check on some basics of C# with **Unity 2020.3.x**.
Use the different scenes described below to check on basic C# methods and principles used with Unity. 
Note, that most of the code is written to be easier to read and to make use of coding basics to help you understand and build up on each other.


## Summary

  - [Getting Started](#getting-started)
  - [Scenes and Methods](#scenes-and-methods)
  - [Prerequisites](#prerequisites)
  - [Run](#run)
  - [Deployment](#deployment)


## Getting Started

Open the project folder with Unity 2020.3.x.
Navigate to the various scenes found at `/Assets/Scenes/`.
Refer to `Scenes and Methods` for details on what to find in each scene.


## Scenes and Methods

### Prototype099
This demonstrates the use of prefabs, prefab varients and nested prefabs with tree and forest prefabs.
You can use the play mode, but all prefabs will remain static.

### Prototype100
This scenes demonstrates C# basics, such as: 
- Debug.Log 
- Variables (int,float,string)
- Arrays
- Random.Range
- Input of Keyboard
- if-else statements
- Movement of GameObjects (Translation)
- **Dice** (as an example to use the above basics)

### Prototype101
This scenes demonstrates C# basics and Unity basics, such as: 
- Reload Scenes with Unity's SceneManager
- Input of Keyboard to move Player (jump)
- Instantiation of GameObjects (StoneSpawner)
- Collision and Destruction of 3D GameObjects (Destroyer)
- Automatically Spawn 3D GameObjects with InvokeRepeating (StoneSpawnerAutomatic)
- Custom Methods (spawningObjects()/invokingObjects())
- Coroutines with while-loops (CouroutineGate)
- Coroutines with for-loop (CouroutineSimple)

Use the keys shown on the UI to test the scripts.


### Prerequisites

    Unity 2020.3.21f1
    

## Run

    Open one scene from the Scenes/ folder.
    Press `Play` in Unity Editor


## Deployment

...


## Acknowledgments

  - Version Control is awesome.
