# Three-in-One Game

CSX4615 Final Exam (Take Home). Three Unity games from class combined into one project, with a Main Menu and an In-Game Menu.

**Unity version:** 6000.5.3f1

## Games
| Game | Scene | Controls |
|---|---|---|
| Driving | `Assets/Scenes/Prototype 1` | Arrow keys / WASD to drive and steer |
| Flying | `Assets/Challenge 1/Challenge 1` | Up / Down arrows to pitch the plane |
| Sumo | `Assets/Challenge 4/Challenge 4` | Arrow keys to move, Space for turbo |

## Menus
- **Main Menu** (`Assets/Scenes/MainMenu`): choose Driving, Flying or Sumo, or Exit.
- **In-Game Menu**: press **Esc** in any game to pause, then choose Resume, Restart or Back to Main Menu.

Scripts are in `Assets/Menu`: `MainMenu.cs` and `PauseMenu.cs`. The pause menu is a prefab (`Assets/Menu/PauseCanvas`) placed in all three game scenes.

## How to run
1. Open the project in Unity Hub with Unity 6000.5.3f1.
2. Open `Assets/Scenes/MainMenu` and press Play.
