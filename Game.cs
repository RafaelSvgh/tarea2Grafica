using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Graphics;
using PGrafica.Controles;

namespace PGrafica;

public class Game : GameWindow
{
    private Camara? camara = null;
    private MouseState _lastMouseState;
    public Game() : base(1000, 900, GraphicsMode.Default, "Tarea 2")
    {

    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        camara = new Camara(Width, Height);
        GL.Enable(EnableCap.DepthTest);
        GL.ClearColor(Color4.Black);


    }

    protected override void OnRenderFrame(FrameEventArgs e)
    {
        base.OnRenderFrame(e);
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        GL.MatrixMode(MatrixMode.Projection);
        GL.LoadMatrix(ref camara!.Proyeccion);
        GL.MatrixMode(MatrixMode.Modelview);
        GL.LoadMatrix(ref camara.Vista);

        Computadora computadora = new Computadora();
        computadora.CPU.Dibujar();
        computadora.Monitor.Dibujar();
        computadora.Teclado.Dibujar();

        SwapBuffers();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        GL.Viewport(0, 0, Width, Height);
        Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.PiOver4, Width / (float)Height, 0.1f, 100f);
        GL.MatrixMode(MatrixMode.Projection);
        GL.LoadMatrix(ref projection);
    }

    protected override void OnUpdateFrame(FrameEventArgs e)
    {
        base.OnUpdateFrame(e);
        camara!.ProcesarMouse(Mouse.GetState(), _lastMouseState, (float)e.Time);
        camara.ActualizarMatrices(Width, Height);
        _lastMouseState = Mouse.GetState();
    }

}
