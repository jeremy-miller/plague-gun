# Plague Gun
Plague gun mod for [RimWorld](https://store.steampowered.com/app/294100/RimWorld/),
based on [this guide](https://rimworldwiki.com/wiki/Plague_Gun_(1.1)).


## Software
- [Git for Windows](https://gitforwindows.org/)
- [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/)
    - Install the `.NET desktop development` workload
    - Use default version of .NET (`4.7.2`)
- [VS Code](https://code.visualstudio.com/)
    - Configure Git bash as default terminal shell by adding this to `settings.json`:
    `"terminal.integrated.shell.windows": "C:\\Program Files\\Git\\bin\\bash.exe"`
- [dnSpy](https://github.com/dnSpy/dnSpy)

## Setup
To create a symlink for this mod into the RimWorld `Mods` directory:
`mklink /D "C:/Program Files (x86)/Steam/steamapps/common/RimWorld/Mods/PlagueGun" "C:/Users/jerem/Code/plague-gun/PlagueGun"`
