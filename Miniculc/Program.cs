using System;

namespace Miniculc;
class Program
{
    static void Main()
    {
        Culc culc = new Culc();
        Console.WriteLine(((ICulc)culc).Culc(((IInput)culc).GetInput()));
        Console.ReadKey();
    }
}