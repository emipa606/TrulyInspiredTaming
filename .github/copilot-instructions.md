# GitHub Copilot Instructions for Truly Inspired Taming (Continued)

## Mod Overview and Purpose

The Truly Inspired Taming (Continued) mod allows RimWorld colonists with an "Inspired Taming" mood effect to tame animals that exceed their current skill level. This provides greater flexibility in gameplay by expanding the range of animals that players can tame based on the mood-based inspiration rather than merely the colonist skills. The mod includes configurable settings allowing players to customize how much their colonists' taming abilities are boosted beyond their actual skill level.

## Key Features and Systems

- **Taming Flexibility**: Inspired taming allows colonists to tame animals beyond their skill level.
- **Configurable Settings**: Three different boost options including:
  - Tame any animal.
  - Boost by a percentage.
  - Boost by levels.
- **Game Compatibility**: The mod can be safely added or removed from save files and placed anywhere in the mod list following Harmony. No known incompatibilities with other mods.
- **Non-Intrusive**: Does not alter the colonist's actual Animals skill level, allowing for a clean integration.

## Coding Patterns and Conventions

- **Code Structure**: This mod is divided into four C# source files, each handling different aspects of the mod's functionality. Maintain separation of concerns by organizing related functionalities into clear and distinct files.
- **Naming Conventions**: Follow C# conventions for naming types, methods, and variables—use PascalCase for types and methods, and camelCase for variables.
- **Documentation**: Add XML documentation comments to public methods and classes, describing their purpose and any parameters or return values.

## XML Integration

- **Manifest and Metadata**: The `About.xml` and `Manifest.xml` files provide metadata for the mod, such as the mod's PackageId, author information, and description.
- **Version Control**: Ensure these XML files are kept up-to-date with mod version changes or when updating metadata such as supported game versions.

## Harmony Patching

- **Patch Structure**: The mod utilizes Harmony for its ability to modify the existing game methods. In the file `HarmonyPatches.cs`, patches are applied to only extend the existing functionality without altering the original game operations.
- **Postfix Method**: A postfix method is used in `WorkGiver_InteractAnimal_CanInteractWithAnimal.cs` to allow custom logic after the original method is called, specifically adding the skill-boosting behavior for inspired taming.

## Suggestions for Copilot

To enhance the utility of GitHub Copilot while developing or maintaining this mod, consider the following suggestions:

- **Utilize Copilot for Code Suggestions**: Let Copilot help generate code snippets for patches, UI elements in `DoSettingsWindowContents`, or other repetitive tasks.
- **Test Coverage Recommendations**: Generate unit test structures to validate new or existing functionality.
- **Documentation Generation**: Use Copilot to assist in writing inline documentation and keeping it consistent across the codebase.
- **Automated Refactoring**: Leverage Copilot to suggest efficient refactorings for existing code to improve code readability and maintainability.

By following these guidelines and utilizing Copilot's capabilities, you can maintain a clean, efficient codebase that enhances the modding experience for both developers and players.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

