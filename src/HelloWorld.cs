using System;

public class HelloWorld
{
    public static void printMessage()
    {
        Console.WriteLine("This is a simple C# class that can be cloned and used \n" +
            "by the user to learn more about GitHub. This same program is \n" +
            "available in multiple different languages to give a good idea\n" +
            "of how repositories work. Please refer to the README.md file in \n" +
            "this repo to learn more about adding this to your OWN GitHub\n" +
            "and how to eventually showcase your own code!");
    }

    static void Main(string[] args) 
    {
        Console.WriteLine("Hello World!");                                     
        Console.WriteLine("Press the enter key to continue...");               

        string input = Console.ReadLine();                                      

        while (!string.IsNullOrEmpty(input))                                    
        {
            Console.WriteLine("Incorrect input. Please just press enter!");    
            input = Console.ReadLine();                                         
        }
        
        printMessage();                                                         
    }
}
