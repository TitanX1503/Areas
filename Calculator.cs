using System;

namespace Areas
{
    class Calculator
    {
         // Triangulo
       public static string TrianArea(int Base, int Altura) { 
           
           int rAreaTriangulo = (Base * Altura) / 2;

           return rAreaTriangulo.ToString();
       }
       

       // Cuadrado
       public static string CuadArea(int lado1)
       {
           int AreaCuadrado = lado1 * lado1;
           return AreaCuadrado.ToString();
       }

       // Rectangulo
       public static string RectArea(int lado1, int lado2)
       {
           int AreaRectangulo = lado1 * lado2;
           return AreaRectangulo.ToString();
       }
    }
}
