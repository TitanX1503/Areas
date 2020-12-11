using System;
using NUnit.Framework;

namespace P6___Areas
{
    // Agregar atributo para indicar que es una clase con pruebas
    [TestFixture]
    class UnitTests
    {
        [Test]
        [TestCase(TestName = "Se debe calcular de correcta el area de algunos triangulos")]
        public void CalcularAreaTriangulo()
        {
            //5*5/2= 12.5 -> 12
            Triangulo triangulo = new Triangulo(5,5);
            Assert.That(triangulo.CalcularArea(), Is.EqualTo(12));

            // Con numeros menores a 0 da 0 y escribe "Error"
            Triangulo triangulo1 = new Triangulo(8,-2);
            Assert.That(triangulo1.CalcularArea(), Is.EqualTo(0));


        }


        [Test]
        [TestCase(TestName = "Se debe calcular de correcta el area de algunos cuadrados")]
        public void CalcularAreaCuadrado()
        {
            //3*3 = 9
            Cuadrado cuadrado = new Cuadrado(3);
            Assert.That(cuadrado.CalcularArea(), Is.EqualTo(9));

            Cuadrado cuadrado1 = new Cuadrado(-5);
            Assert.That(cuadrado1.CalcularArea(), Is.EqualTo(0));

            //50*50 = 2500
            Cuadrado cuadrado3 = new Cuadrado(50);
            Assert.That(cuadrado3.CalcularArea(), Is.EqualTo(2500));
        }

        [Test]
        [TestCase(TestName = "Se debe calcular de correcta el area de algunos rectangulos")]
        public void CalcularAreaRectangulo()
        {
            //9*21 = 189
            Rectangulo rectangulo = new Rectangulo(9,21);
            Assert.That(rectangulo.CalcularArea(), Is.EqualTo(189));

            //80*20 = 1600
            Rectangulo rectangulo1 = new Rectangulo(80,20);
            Assert.That(rectangulo1.CalcularArea(), Is.EqualTo(1600));

            Rectangulo rectangulo2 = new Rectangulo(0,0);
            Assert.That(rectangulo2.CalcularArea(), Is.EqualTo(0));
        }

        
    }
}
