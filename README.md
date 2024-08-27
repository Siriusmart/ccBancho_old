# Bancho ClassiCube

My first MCGalaxy plugin, the idea of this plugin is to bring reimplement some functionalities of BanchoBot from osu! to ClassiCube.

## Commands

Commands are ran as chat message (same as the original BanchoBot).

`[square brackets]` represent required arguments, where as `<triangle brackets=0>` represent optional arguments and their default values.

- `!roll <min=1> <max=100>`
- `!coinflip`
- `!help <command>`

Excess arguments are ignored.

## Installation

Download `BanchoBot.dll` from [releases](https://github.com/Siriusmart/ccBancho/releases/), and put it in the plugins folder. After starting the server, run the following command.

- `/pload BanchoBot`

You should see a success message
```
BanchoBot is now online!
```

### Updating

Delete all relevant files `BanchoBot.*` from the plugins folder, and restart the installation process.

### Build from source

~~See usage in [togetherer](https://github.com/Siriusmart/togetherer).~~

```sh
dotnet publish -c Release -o out
```
