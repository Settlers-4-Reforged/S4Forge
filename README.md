# S4Forge - A Modding API for Settlers 4
S4Forge is a modding API for Settlers 4.
It allows you to create mods for Settlers 4 in .Net.

## Forge Engines
Forge Engines are independent parts of Forge that can be used to further interact with Settlers 4.
They are not required to use Forge, but they can be used to simplify certain tasks.

To use a Forge Engine, add a reference to the corresponding NuGet package.

- [UX-Engine](https://gitlab.settlers4-hd.com/s4-plugins/modapi/engines/ux-engine/-/blob/main/README.md): The UX-Engine allows you to create custom user interfaces for Settlers 4.
- [GameState-Engine]() (Coming soon): The GameState-Engine allows you easily access and modify the game state of Settlers 4.
- [Multiplayer-Engine]() (Coming soon): A wrapper around the multiplayer API of Settlers 4. Allows for custom network events and more.

## NuGet
S4Forge and all of its engines are available as a NuGet package from a central GitLab NuGet repository.
[Read more](https://gitlab.settlers4-hd.com/s4-plugins/modapi/packages/-/blob/main/README.md)

## How to use
### Creating a mod
To create a mod, create a new .Net Standard 2.0 project and add a reference to S4Forge.
Then, create a class that implements `IPlugin`.

Modify the `csproj` file to change the extension of the output file to `.nasi`:
```xml
<PropertyGroup>
	<!-- ... -->
	<!-- Append the folowing line to the main PropertyGroup: -->
	<TargetExt>.nasi</TargetExt>
</PropertyGroup>

```

### Loading a mod
Forge automatically loads all `.nasi` mods in the `plugins` folder of Settlers 4 based on the priority field specified in their respective `IPlugin` implementations.

#### Using embedded dependencies
If your mod has dependencies, you can embed them in your mod by adding them as embedded resources.
Forge will automatically load them when loading your mod.

## Components of Forge
Forge is split into different sections that handle different parts of the modding API.
Every section has its own readme file that explains how to use it.

- `Forge.Logging`: A centralized logging API.
- `Forge.S4`: The API for accessing, modifying and interacting with Settlers 4
- `Forge.I18n`: A collection of helper classes for handling different languages
- `Forge.Native`: Various helper classes for interacting with native code
- `Forge.UPlay`: A collection of helper classes for interacting with UPlay

## License
S4Forge is licensed under GNU General Public License v3.0.
