using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGrafica;

public class Objeto
{
    public List<Cara> caras { set; get; }

    public Color4 Color { get; set; } = Color4.White;
    public Objeto()
    {
        caras = new List<Cara>();
    }

    public Objeto(List<Cara> caras, Color4 color)
    {
        this.caras = caras;
        this.Color = color;
    }

    public void AddCara(Cara cara)
    {
        caras.Add(cara);
    }

    public void Dibujar()
    {
        foreach (var cara in caras)
        {
            cara.Color = this.Color;
            cara.Dibujar();
        }
    }

}
