using System;

namespace Miniculc;

interface ILogger
{
    void Event(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Event: " + message + Environment.NewLine);
        Console.ForegroundColor = ConsoleColor.White;
    }
    void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Error: " + message + Environment.NewLine);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

class Logger : ILogger
{

}

