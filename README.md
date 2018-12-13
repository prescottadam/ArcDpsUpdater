# ArcDpsUpdater
Simple executable to update ArcDPS for GW2

## Instructions

1. Download zip file from binaries
2. Unzip
3. Run the exe

## Usage

The executable downloads the latest d3d9.dll from `https://www.deltaconnected.com/arcdps/x64/d3d9.dll` and 
saves it to the default target path, `C:\Program Files\Guild Wars 2\bin64\d3d9.dll`.

Target path can be changed by using the `target` switch:
`ArcDpsUpdater.exe --path="c:\my\custom\path\bin64\d3d9.dll"`
