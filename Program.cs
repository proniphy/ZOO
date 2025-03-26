using System;
using System.Dynamic;

class Program
{
    static void Main()
    {
        
    }
    public static int GetIntInput(string message) //Function to get Int, also checks for correct input
    { 
        int value; 
        do
        {
            Console.Write(message); 
        }while(!int.TryParse(Console.ReadLine(), out value)||value<0);
        
        return value; 
    }
    public static string GetStringInput(string message) //analog to GetIntInput for Strings.
    { 
        string? value; 
        do
        {
            Console.Write(message);
            value = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(value));
    
    return value;
    }
}