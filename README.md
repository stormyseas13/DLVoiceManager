# DLVoiceManager
Modifed and further improved version of the "DLsite GameManager0.3.3". A Windows application that helps you sort, rename and keep track of games, manga and voice works from Dlsite.

I only spend time on this project to learn C#. So don't expect much. 
### **All credit to the previous maker and modders.**
### **Previosly built by Lux and thereafter futher modifyed by Phantasmx.**
#### These are the things that I've improved so far:
- I changed the name and version number to keep it separate from the REAL modded versions
- 64-bit version (In my experience it's much faster than the 32-bit version)
- Cleaned up the project with the use of nuget packages
- Updated componetes to latest versions e.g. .NET 4.8 Framework, objectlistview, SQLite.
- Fixed so category and tags displays correctly with the new dlsite website.

## How to run
1. Download the latest [Release]()
2. Extract the archive and then simply run the GameManager.exe

## Build from source
1. Download the latest stable [Release]() or download the latest source code from the main [Branch]() (May not work correctly).
2. Extract the archive.
3. Open ".\src\GameManager.sln" in visual studio (Only tested on Visual Studio 2022 and 2019).
4. Select which platform you want to use it for under "solution platform" (default 64-bit).
5. Build the GameManager Solution, Build --> Build Solution.
6. The compiled binaries and other dependencies will appear in .\GameManager\bin\PLATFORM\Release


## About
- The main UI consist of WindowsForms and ObjectListView, the logic consist of the project "GameManager"
- The program depends on three 3rd-party binaries called Objectlistview, System.Data.SQLite.dll and SQLite.Interop.dll (which is a .NET provider for SQLite)
- Coded in C#, built on .NET Framework 4.8 and supports both 32-bit and 64-bit mode.
