using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            bool finished = false;
            Snake canvas = new Snake();

            while (!finished)
            {
                canvas.drawCanvas();
                Console.Read();
            }

        }
    }
}
