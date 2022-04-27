using OpenTK.Graphics.OpenGL;
using CG_Biblioteca;
using System;
using System.Collections.Generic;

namespace gcgcg
{
    internal class PrimitivasGeometricas : ObjetoGeometria
    {

        public PrimitivasGeometricas(char rotulo, Objeto paiRef, List<Ponto4D> listaPontos) : base(rotulo, paiRef)
        {
            this.pontosLista = listaPontos;
        }

        protected override void DesenharObjeto()
        {
            GL.Begin(base.PrimitivaTipo);

            // foreach (Ponto4D pto in this.pontosLista)
            // {
            //     GL.Vertex2(pto.X, pto.Y);
            // }
            GL.Color3(1.0f, 1.0f, 0.0f);
            GL.Vertex2(this.pontosLista[0].X, this.pontosLista[0].Y);
            GL.Color3(0.0f, 1.0f, 1.0f);
            GL.Vertex2(this.pontosLista[1].X, this.pontosLista[1].Y);
            GL.Color3(1.0f, 0.0f, 1.0f);
            GL.Vertex2(this.pontosLista[2].X, this.pontosLista[2].Y);
            GL.Color3(1.0f, 0.0f, 0.0f);
            GL.Vertex2(this.pontosLista[3].X, this.pontosLista[3].Y);


            GL.End();
        }
    }
}