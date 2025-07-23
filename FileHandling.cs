using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the full file path: ");
        string filePath = Console.ReadLine();

        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("\nFile content:\n");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The file does not exist.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: You do not have permission to access the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}