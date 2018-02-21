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
        Colision miCol = new Colision();
        cuadro cuadrito = new cuadro();
        cuadro cuadroDer = new cuadro();

        punto primerDer = new punto(0,5);
        punto segundoDer = new punto(1, 9);

        punto primer = new punto(0, 0);
        punto segundo = new punto(1, 1);
     
         

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
            miCol.Col(primer, primerDer, primerDer);

            segundo.x = primer.x + 1;
            segundoDer.x = primerDer.x + 1;
            cuadroDer.Imprime(primerDer, segundoDer);
            cuadrito.Imprime(primer, segundo);
            this.SwapBuffers();
        }
    }
}
