using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace cuadradito
{
    class Program
    {
        static void Main(string[] args)
        {
            VentanaGame screen = new VentanaGame(600, 500);
            screen.Title = "Mi Primer Cuadro";
            screen.Run();
        }
    }
}
