// See https://aka.ms/new-console-template for more information
using System;
class Students
{
    string[] names = { "James", "John", "Alexander" };
    static void Main(string[] args)
    {
        Students obj = new Students();
        try
        {
            obj.names[4] = "Michael";
        }catch(Exception objException)
        {
            Console.WriteLine("Error: " + objException);
        }
    }
}