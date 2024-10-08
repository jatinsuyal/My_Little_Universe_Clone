# Project Documentation for My Little Universe Prototype

## Overview
This project is a prototype inspired by *My Little Universe*, focusing on core mechanics like player control, resource collection, combat, area unlocking, and a save/load system. The project is modular, designed for scalability, and is implemented in Unity.

### Key Features
- **Player Control & Camera Follow**: Smooth player movement with a mobile-friendly camera that tracks player position.
- **Resource Collection System**: Collection of multiple resources (e.g., wood, stone) with customizable properties.
- **Area Unlocking Mechanic**: Unlock new areas after collecting required resources.
- **Combat System**: Player interaction with enemies and objects using weapons.
- **Save and Load System**: Persistent player progress, including resources and unlocked areas.

## Core Game Mechanics
1. **Player Movement & Camera**
   - `PlayerMovement`: Controls player movement.
   - `MobileCameraFollow`: Handles camera behavior for mobile platforms.

2. **Resource Collection**
   - `ResourceBase`: Base class for resources.
   - `Tree`: Wood resource implementation.
   - `Stone`: Stone resource implementation.
   - `ResourceUI`: Updates the player's resource count in the UI.

3. **Combat System**
   - `PerformCombat`: Manages player combat mechanics.
   - `WeaponInteraction`: Handles interactions between weapons and objects, including hit detection.

4. **Area Unlocking**
   - `AreaUnlocker`: Unlocks new areas based on resource collection.
   - `GameControl`: Manages game logic and ensures unlocked areas persist.

5. **Save and Load**
   - `GameSaveManager`: Handles saving and loading player progress.
   - `PlayerInventory`: Stores collected resources.
   - `GameSaveData`: Contains data about player progress for saving and loading.

## Architecture and Design Decisions
The project is built using a modular architecture to promote scalability and ease of maintenance. Each core mechanic is encapsulated within its own class, allowing developers to modify or extend specific systems without affecting others. This design choice was made to facilitate collaborative development and future enhancements.

## Instructions for Adding New Resources or Areas
### Adding New Resources
To add new resources to the game:

1. **Create a New Script**:
   - Create a new script that inherits from `ResourceBase`.
   - Implement the necessary properties and methods for the new resource.

2. **Define the Resource Type**:
   - Modify the `ResourceType` class to include your new resource. This makes it recognizable within the game.

3. **Update the UI**:
   - Modify the `ResourceUI` script to account for the new resource type, ensuring that the player's resource count reflects the addition.

### Adding New Areas
To add new unlockable areas:

1. **Extend the AreaUnlocker Class**:
   - Create a new class that extends `AreaUnlocker`.
   - Define the conditions for unlocking the new area based on resource collection.

2. **Attach the New Area**:
   - Integrate the new area into the game world by modifying the `GameControl` script. Ensure it references the new area for unlocking.

3. **Save Progress**:
   - Ensure that the new area's unlock status is saved by updating the `GameSaveManager`. This allows player progress to persist across sessions.

## Project Setup and Instructions
### Running in Unity
1. Open the project in Unity (version 2021.3 or higher).
2. Press Play in the Unity Editor.

### Building APK
1. Go to `File > Build Settings`.
2. Select Android as the platform.
3. Include required scenes and build the APK.

## Future Improvements
- **Visual Enhancements**: Add animations and particle effects for resource collection and area unlocking.
- **Expanded Combat**: Introduce advanced enemy AI and combat mechanics.
- **New Resources**: Expand the game with new resource types (e.g., gold, diamonds).
- **Sound Design**: Implement background music and interaction sound effects.

## Conclusion
This prototype demonstrates modular and scalable mechanics such as player control, resource collection, combat, and area unlocking. The system is designed for easy expansion with new features or content, ensuring a smooth development process for future iterations.
