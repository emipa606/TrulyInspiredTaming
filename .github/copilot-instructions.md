# Copilot Instructions for RimWorld Modding Project

## Mod Overview and Purpose

The "Truly Inspired Taming" mod is designed for RimWorld, a colony simulation game. This mod aims to enhance the taming experience by providing additional contextual features that reflect the colonists' inspiration levels when interacting with animals. By integrating this mod, players can expect a more dynamic and meaningful interaction system between their colonists and the wildlife of RimWorld.

## Key Features and Systems

- **Boost Settings:** The mod introduces a customizable settings feature where players can adjust parameters related to taming, making the mod adaptable to various playstyles.
- **Enhanced Interaction Logic:** The mod adds new layers of depth to the interaction between colonists and animals, ensuring that in-game dialogues and actions are contextually relevant and affected by the colonists' inspiration levels.
- **Harmony Patching:** Mod uses Harmony to apply patches to the base game methods, allowing for non-destructive modifications and integrations.
  
## Coding Patterns and Conventions

- **Internal Accessibility:** Classes such as `BoostSettings`, `HarmonyPatches`, and `TrulyInspiredTaming` are marked as `internal` to encapsulate their functionality within the assembly, promoting modularity.
- **Consistent Naming:** Classes and methods use PascalCase for denoting types and method names, which is aligned with C# conventions. For example, `BoostSettings` and `WorkGiver_InteractAnimal_CanInteractWithAnimal`.
- **Minimalistic Class Design:** Classes are designed to encapsulate specific functionalities, minimizing dependencies and promoting single responsibility.

## XML Integration

While the C# files summarize the core logic and settings management of the mod, XML integration is often used for defining the patch operations and configuring game elements. The project leverages XML for:

- **Defining Game Elements:** Use XML files to define new objects or configurations within the game. These files interact with the C# logic to apply custom settings.
- **Localized Content:** XML files can also be utilized to manage string content for different languages, allowing the mod to support various localizations seamlessly.
  
## Harmony Patching

Harmony is extensively used in this mod to apply runtime modifications:

- **Patch Initialization:** The static class `HarmonyPatches` is dedicated to applying Harmony patches. This centralized approach ensures that all patches are consistently managed.
- **Non-Destructive Updates:** All patches are designed to be non-destructive, targeting existing methods in the base game to inject additional logic or modify behaviors.

## Suggestions for GitHub Copilot

1. **Automate Configuration Generation:** Use Copilot to generate boilerplate code for creating and saving custom settings files.
2. **Simplify Patch Writing:** Employ Copilot to assist in writing Harmony patches by providing quick templates for postfix and prefix patches.
3. **Expand Localization Support:** Generate XML templates for adding new languages to the mod, ensuring seamless integration with the mod's logic.
4. **Optimize Class Interactions:** Encourage Copilot to suggest design patterns that minimize dependencies and keep classes focused on single responsibilities.
5. **Test Case Creation:** Use Copilot to rapidly prototype unit tests that validate the mod's features and ensure compatibility with game updates.

This instruction file should guide mod developers in effectively utilizing Copilot for enhancing and maintaining the "Truly Inspired Taming" mod.
