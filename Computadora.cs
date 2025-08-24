using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGrafica;

public class Computadora 
{
    public Objeto Teclado { get; set; }
    public Objeto Monitor { get; set; }
    public Objeto CPU { get; set; }

    public Computadora()
    {

        this.Teclado =

                Utils.CrearBloque3D(
                [
                    new Vertice(-0.45f, -0.55f, 0.4f),
                    new Vertice(0.35f, -0.55f, 0.4f),
                    new Vertice(0.35f, -0.6f, 0.4f),
                    new Vertice(-0.45f, -0.6f, 0.4f),
                    new Vertice(-0.45f, -0.55f, 0.15f),
                    new Vertice(0.35f, -0.55f, 0.15f),
                    new Vertice(0.35f, -0.6f, 0.15f),
                    new Vertice(-0.45f, -0.6f, 0.15f),
                ], Color4.Blue);

        this.Monitor =
                Utils.CrearBloque3D(
                [
                    new Vertice(-0.45f, 0.25f, 0.0f),
                    new Vertice(0.35f, 0.25f, 0.0f),
                    new Vertice(0.35f, -0.45f, 0.0f),
                    new Vertice(-0.45f, -0.45f, 0.0f),
                    new Vertice(-0.45f, 0.25f, -0.1f),
                    new Vertice(0.35f, 0.25f, -0.1f),
                    new Vertice(0.35f, -0.45f, -0.1f),
                    new Vertice(-0.45f, -0.45f, -0.1f),
                ], Color4.Blue);


        this.CPU =
                Utils.CrearBloque3D(
                [
                    new Vertice(-0.9f, 0.6f, 0.5f),
                    new Vertice(-0.6f, 0.6f, 0.5f),
                    new Vertice(-0.6f, -0.6f, 0.5f),
                    new Vertice(-0.9f, -0.6f, 0.5f),
                    new Vertice(-0.9f, 0.6f, -0.4f),
                    new Vertice(-0.6f, 0.6f, -0.4f),
                    new Vertice(-0.6f, -0.6f, -0.4f),
                    new Vertice(-0.9f, -0.6f, -0.4f),
                ], Color4.Gray);
    }
}
