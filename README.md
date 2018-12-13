# ArcDpsUpdater
Simple executable to update ArcDPS for GW2

## Instructions

1. Download zip file from [binaries](https://github.com/prescottadam/ArcDpsUpdater/tree/master/binaries)
2. Unzip to where you want it to live
3. (optional) Create a shortcut in a convenient location
4. Run it

## Usage

The executable downloads the latest d3d9.dll from `https://www.deltaconnected.com/arcdps/x64/d3d9.dll` and 
saves it to the default target path, `C:\Program Files\Guild Wars 2\bin64\d3d9.dll`.

Target path can be changed by using the `target` switch:
`ArcDpsUpdater.exe --target="c:\my\custom\path\bin64\d3d9.dll"`
