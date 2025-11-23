using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LinuxCommandsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Linux Commands Viewer ===");
            Console.WriteLine();

            string jsonFileName = "linuxCommands.json";

            // Check if file exists
            if (!File.Exists(jsonFileName))
            {
                Console.WriteLine($"ERROR: Could not find {jsonFileName} in the current folder.");
                Console.WriteLine("Make sure linuxCommands.json is in the same directory as the executable.");
                return;
            }

            try
            {
                // Read JSON file
                string jsonString = File.ReadAllText(jsonFileName);

                // Deserialize JSON into a list of LinuxCommand objects
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                List<LinuxCommand>? commands =
                    JsonSerializer.Deserialize<List<LinuxCommand>>(jsonString, options);

                if (commands == null || commands.Count == 0)
                {
                    Console.WriteLine("No commands found in JSON file.");
                    return;
                }

                Console.WriteLine($"Loaded {commands.Count} Linux commands.");
                Console.WriteLine();

                // Display all commands using the blueprint class method
                foreach (var cmd in commands)
                {
                    cmd.Display();
                }

                Console.WriteLine("End of list. Press ENTER to exit.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading or parsing the JSON file:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
