# unity-junior-player-control-prototype-1

## Screenshots


https://github.com/user-attachments/assets/1d7062b3-28e0-4297-9c16-d9d36218da87


https://github.com/user-attachments/assets/df7cc852-4128-454d-85e9-d90b8e9c751f



## Table of Contents
1. [Description](#description)
2. [Installation](#installation)
3. [Run](#run)
4. [Credits](#credits)
5. [Contributing](#contributing)
6. [License](#license)

## Description

This prototype is part of the Junior Programmer Pathway from Unity Learn. Its purpose is to teach the fundamentals of player control through scripting in C#.
Each prototype includes:
- A Learning section that guides you through building core features step by step. Later, you can complete bonus challenges categorized from easy to expert
- A Challenge section where you're given a broken or incomplete project to fix and extend, testing your understanding and problem-solving skills.

### Purpose

The objective of this prototype is to create two simple games:

- **Vehicle Game** : Control a ground vehicle and navigate through obstacles.
- **Plane Game** : Control an aircraft.

#### Bonus Features (for Vehicle Game) :
- Built obstacle pyramids using crates.
- Added oncoming vehicles as moving obstacles.
- Implemented a camera switcher (top-down and driver view).
- Created local multiplayer functionality.

#### Fixing problems (For Plane game) : 
- The plane is going too fast -> Slow the plane down to a manageable speed.
- The plane is tilting automatically -> Make the plane tilt only if the user presses the 'Z' or 'S'.
- The camera is in front of the plane -> Reposition it so it’s beside the plane.
- The camera is not following the plane -> Make the camera follow the plane.
- The plane’s propeller does not spin -> Create a script that spins the plane’s propeller.

## Controls

**Vehicle Game** (Player 1)
| **Key** | **Action**         |
|:-------:|--------------------|
| `W`     | Move forward       |
| `S`     | Move backward      |
| `A`     | Turn left          |
| `D`     | Turn right         |
| `T`     | Switch camera view |
| `R`     | Restart game       |

**Vehicle Game** (Player 2)
| **Key** | **Action**         |
|:-------:|--------------------|
| `↑`     | Move forward       |
| `↓`     | Move backward      |
| `←`     | Turn left          |
| `→`     | Turn right         |

**Plane Game**
| **Key** | **Action**         |
|:-------:|--------------------|
| `W`     | Pitch up		   |
| `S`     | Pitch down     	   |

### Technologies used

- **Unity** – Version 6000.0.47f1
- **C#** – Used for gameplay scripting
  
### Challenges and Future Features

One of the main challenges in this project was learning how to work with multiple cameras to support a simple local multiplayer experience. It involved managing camera views, player input separation, and screen space.

## Installation

You can download pre-built releases for your supported operating system from the GitHub Releases page. Available builds include:
- macOS
- Windows
- Linux

Alternatively, you can play the game directly in your browser via Unity Play by following the provided link.

## Run

To run the program, simply double-click the executable file for your operating system.

### MacOS

Unzip and open the .app file.

### Windows

Unzip and double-click the .exe file.

### Linux

```bash
chmod +x Vehicle_game.x86_64
./Vehicle_game.x86_64
```

### Web

Play on [browser](https://vpekdas.github.io/unity-junior-player-control-prototype-1/)

## Credits

This project is based on the Unity **Junior Programmer Pathway** by Unity Learn.
Many thanks to the instructors for their excellent step-by-step video tutorials and guidance.

## Contributing

To report issues, please create an issue here:  [issue tracker](https://github.com/Vpekdas/unity-junior-player-control-prototype-1/issues).

If you'd like to contribute, please follow the steps outlined in [CONTRIBUTING.md](CONTRIBUTING.md).

## License

This project is licensed under the [MIT License](LICENSE).
