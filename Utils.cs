using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGrafica;

public static class Utils
{
    public static Objeto CrearBloque3D(List<Vertice> vertices, Color4 color)
    {
        if (vertices.Count != 8)
        {
            throw new ArgumentException("Se requieren exactamente 8 vértices.");
        }

        var caras = new List<Cara>
        {
            new([vertices[0], vertices[1], vertices[2], vertices[3]]),
            new([vertices[4], vertices[5], vertices[6], vertices[7]]),
            new([vertices[0], vertices[1], vertices[5], vertices[4]]),
            new([vertices[3], vertices[2], vertices[6], vertices[7]]),
            new([vertices[0], vertices[3], vertices[7], vertices[4]]),
            new([vertices[1], vertices[2], vertices[6], vertices[5]]),
        };
        return new Objeto(caras, color);
    }
}
