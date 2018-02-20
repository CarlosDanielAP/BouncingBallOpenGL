using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace cuadradito
{
    class VentanaGame : GameWindow
    {
        
        cuadro cuadrito = new cuadro();
        punto primer = new punto(0, 0);
        punto segundo = new punto(1, 1);
        bool col=false;
         

        public VentanaGame(int ancho, int alto): base (ancho,alto)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.LoadIdentity();
            GL.MatrixMode(MatrixMode.Projection);
            GL.Ortho(0, 10, 0, 10, -1, 1);
            
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.ClearColor(0.5f, 0.5f, 1f, 1f);

        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            
            base.OnRenderFrame(e);

if(!col){

    primer.x += 0.5f;
            if (primer.x >= 10)
            {
                col = true;
                
            }

}

            if (col)
            {
                primer.x -= 0.5;

                if (primer.x <= 0)
                {
                    col = false;

                }
            }




            
          

            


            

         



          
                      segundo.x = primer.x + 1;


                    cuadrito.Imprime(primer, segundo);
                    
                      this.SwapBuffers();
                    
                   
                   

                    
                
               
               
               
     
            
        }
    }
}
