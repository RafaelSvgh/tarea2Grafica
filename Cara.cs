using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGrafica;

public class Cara
{
    public List<Vertice> Vertices { get; set; }
    public Color4 Color { get; set; } = Color4.White;
     
    public Cara()
    {
        Vertices = new List<Vertice>();
    }
    public Cara(List<Vertice> vertices)
    {
        this.Vertices = vertices;
    }

    public void AddVertices( Vertice vertice)
    {
        Vertices.Add(vertice);
    }

    public void Dibujar()
    {
        GL.Begin(PrimitiveType.LineLoop);
        GL.Color4(Color);
        foreach (var vertice in Vertices)
        {
            GL.Vertex3(vertice.X, vertice.Y, vertice.Z);
        }
        GL.End();
    }

    

}
