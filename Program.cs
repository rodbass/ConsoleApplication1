using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var @this = new Program();
            try
            {
                @this.Test();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("\n\n\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        void Test()
        {
        }
    }
}
