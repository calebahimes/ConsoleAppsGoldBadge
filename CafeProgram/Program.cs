using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                CafeProgramUI.Run();
			}
			catch (Exception e)
			{
                Console.WriteLine(e.Message);
			}
        }
    }
}
