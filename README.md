# Linux Assignment #3 – Group 13

## Course
COMP2018 – Linux

## Group Information
- **Group #: 13**
- **Members:**
  - Mandeep (200599770)
  - Navneet Kaur (200598728)

## Project Description
This repository contains a .NET 8 C# Console Application that reads a JSON file about Linux commands and displays them in a formatted way. The application loads data from a JSON array, maps it into a C# blueprint class, and prints details in a clean, readable format.

### Main Features
- A JSON file (`linuxCommands.json`) containing an array of Linux command objects.
- A blueprint C# class (`LinuxCommand`) including properties and a `Display()` method.
- A `Program.cs` file that:
  - Reads and loads the JSON data.
  - Deserializes it into a list of `LinuxCommand` objects.
  - Displays each command with syntax, category, description, example, and danger level.

### How to Run

1. Open a terminal inside the `LinuxCommandsApp` folder.
2. Build and run the application:

```bash
dotnet build
dotnet run
