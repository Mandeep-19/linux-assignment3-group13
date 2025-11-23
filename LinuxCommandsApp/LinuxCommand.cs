using System;

namespace LinuxCommandsApp
{
    // Blueprint class
    public class LinuxCommand
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Syntax { get; set; }
        public string Description { get; set; }
        public string Example { get; set; }
        public string DangerLevel { get; set; }

        // Method to display one command nicely
        public void Display()
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"Command     : {Name}");
            Console.WriteLine($"Category    : {Category}");
            Console.WriteLine($"Syntax      : {Syntax}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Example     : {Example}");
            Console.WriteLine($"Danger Level: {DangerLevel}");
            Console.WriteLine("====================================");
            Console.WriteLine();
        }
    }
}
