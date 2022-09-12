using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        //I have no idea what this is
        public int Width { get; set; }
        public int Height { get; set; }
        public Snake()
        { //Width and height you get it
            Width = 100;
            Height = 28;
        }

        //draw the canvas?
        public void drawCanvas()
        {
            Console.Clear();
            //dessa for loops är det som gör boxen. t.ex. det här är top raden
            for(int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");
            }
            //och detta bottom delen osv
            for(int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, Height);
                Console.Write("/");
            }

            for(int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("-");
            }

            for(int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(Width, i);
                Console.Write("-");
            }
        }

    }
}
