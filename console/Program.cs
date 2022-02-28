using System;

namespace CalculateArea
{

    public class Program
    {
        
        public static void Main(string[] args)
        {
            
            var square = new Square(5.0f);
            System.Console.WriteLine( square.GetArea() ); 

        }       

    }
}
