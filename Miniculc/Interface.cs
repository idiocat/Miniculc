using System;
using System.Runtime.InteropServices;

namespace Miniculc;

interface ICulc { int Culc(List<int> nums) => nums.Sum(); }

interface IInput
{
    List<int> GetInput()
    {
        ILogger logger = new Logger();
        List<int> nums = [];
        int i = 0;
        while (true)
        {
            try
            {
                Console.Write("Number {0} (0 to stop): ", i + 1);
                int numb = int.Parse(Console.ReadLine());
                if (numb == 0) { break; }
                nums.Add(numb);
                i++;
                logger.Event("Number added.");
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                continue;
            }
        }
        return nums;
    }
}