//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
        
        Circulo circulo = new Circulo(2, Color.FromArgb(213, 50, 17, 200));
        Console.WriteLine(circulo);
         Console.WriteLine($"-Area: {circulo.GetArea():0.00}");;

        Rectangulo rectangulo = new Rectangulo(7, 10, Color.FromArgb(231, 82, 65, 147));
        Console.WriteLine(rectangulo);
         Console.WriteLine($"-Area: {rectangulo.GetArea():0.00}");;

        Triangulo triangulo = new Triangulo(9, Color.FromArgb(210, 232, 10, 10));
        Console.WriteLine(triangulo);
         Console.WriteLine($"-Area: {triangulo.GetArea():0.00}");;

        Console.WriteLine("Modificando un valor de cada figura...");
        circulo.Radio = 6;
        rectangulo.Ancho = 20;
        triangulo.Lado = 8;

        Console.WriteLine(circulo);
        
        Console.WriteLine(rectangulo);
       
        Console.WriteLine(triangulo);
         Circulo circulo2 = new Circulo(3, Color.FromArgb(255, 50, 17, 200));
        Rectangulo rectangulo2 = new Rectangulo(5, 8, Color.FromArgb(255, 89, 65, 147));
        Triangulo triangulo2 = new Triangulo(4, Color.FromArgb(255, 255, 10, 10));

        
        Console.WriteLine("Creando lista de figuras...");
        List<Figura> figuras = new List<Figura>
        {
            circulo,
            circulo2,
            rectangulo,
            rectangulo2,
            triangulo,
            triangulo2
        };

        
        foreach (Figura figura in figuras)
        {
            Console.WriteLine(figura);
            Console.WriteLine($"-Area: {figura.GetArea():0.00}");;
            
        }


  }

}