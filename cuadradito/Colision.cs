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
    class Colision
    {
        bool choque = false;
        public void Col(punto player,punto paredDer,punto paredIzq)
        {
            if (!choque)
            {
                player.x += 0.5f;
                if (player.x >= paredDer.x)
                {
                    choque = true;
                }
            }
            if (choque)
            {
                player.x -= 0.5;
                if (player.x <= paredIzq.x)
                {
                    choque = false;
                }
            }

        }
    }
}
