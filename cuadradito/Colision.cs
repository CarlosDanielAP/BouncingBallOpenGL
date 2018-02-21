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
                player.x += 0.1;
                if (player.x >= paredDer.x&& player.y + paredDer.y >= -1 && player.y + paredDer.y <= 1)
                {
                  
                
                        choque = true;
                    
                }
            }
            if (choque)
            {
                player.x -= 0.1;
                if (player.x <= paredIzq.x)
                {
                    choque = false;
                }
            }

        }
    }
}
