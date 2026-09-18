[![Discord](https://discord.com/api/guilds/1537046465195548734/widget.png?style=shield)](https://discord.gg/aJ6JwG7H2w)
# MOsu

osu! practice ruleset with unique mods and local PP tracking.

[![Watch the video](https://img.youtube.com/vi/nWBAsAGQIVM/maxresdefault.jpg)](https://youtu.be/nWBAsAGQIVM)


## Features

- **Local PP** — (with local profiles)
<img width="480" height="270" alt="local_pp" src="https://github.com/user-attachments/assets/1b28e698-62bc-4afb-bd9b-4a4d25ff8478" />


- **Skip breaks** — button to skip break sections
<img width="480" height="270" alt="breakskip" src="https://github.com/user-attachments/assets/c101455e-afa9-4346-8d84-13feed11c573" />

- **ModRandomV2** — like random but you can increase the distances between objects, separate for aim and stream (configured by divisor)
  - Make any map an aim practice map
  - Make any map a stream practice map

<img width="480" height="270" alt="modrandomv2" src="https://github.com/user-attachments/assets/8835337a-2be6-4409-b744-894bcc6b6763" />

- **ModCircleGen** — generate a long stream practice map from any map (or you can do 32x 16x triples etc...)

<img width="480" height="270" alt="modcirclegen" src="https://github.com/user-attachments/assets/b7cd81e9-044d-487f-b585-69a1eab1764e" />

- **Miss Challenge** — fail if your miss count exceeds a configurable limit (1–100). Option to auto-set from your best local score for the beatmap, matching by active mods (DT rate, AR/CS).
<img width="507" height="201" alt="image" src="https://github.com/user-attachments/assets/3fdb43d6-b7e9-44d1-83ec-4d300b7e6786" />


- **Merged mods** — includes [NoSliding](https://github.com/ppy/osu/pull/22067) and [SpacingAdjust](https://github.com/ppy/osu/pull/18559)
<img width="480" height="270" alt="nosliding" src="https://github.com/user-attachments/assets/7b0aee7f-8fa5-4ef4-8039-01af0bc10450" />
<img width="480" height="270" alt="spacingadjust" src="https://github.com/user-attachments/assets/e7d3c1b8-cfc9-4a2e-abd3-a6ffb6c394e5" />

- **Live star rating** — HUD element showing cumulative star rating as you play, updating in real-time (like pp counter)
<img width="480" height="784" alt="livestarrating" src="https://github.com/user-attachments/assets/4b0821d8-2c3a-4dff-bc96-999a8147f346" />

- Mod preset import/export — share presets via JSON files
- Collection import/export — back up and share beatmap collections
  



<img width="480" height="703" alt="importexport" src="https://github.com/user-attachments/assets/ea4bcd71-e92b-44df-ab2a-0c61219d3387" />





- Chat mod sharing — right-click a chat line to send current mods, right-click a message to apply them, or type /md or /mods to send and click the link to apply.
<img width="749" height="359" alt="image" src="https://github.com/user-attachments/assets/545c2144-1ad1-4958-ab46-42f9550991d6" />

- Suggested songs at the expanded score view.
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/ac1c1909-a4e9-49eb-84fc-a2f12ca4c02f" />


## Install

1. Navigate to osu!lazer's data directory: Settings → General → **Open osu! folder**
2. Might want to backup client.realm just in case
3. Copy `osu.Game.Rulesets.MOsu.dll` into the `rulesets` folder
4. Restart osu!lazer

### Download

Get the latest `.dll` from the [Releases](https://github.com/p2d0/mosu/releases) page.

## Build

```sh
dotnet build osu.Game.Rulesets.MOsu/osu.Game.Rulesets.MOsu.csproj -c Release
```

Requires .NET 8.0 SDK.
