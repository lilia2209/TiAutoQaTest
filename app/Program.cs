using System;
namespace app
{
    class Program
    {
        static void Main(string[] args){

            Console.WriteLine("Enter coordinate x of dot A: ");
            int ax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A: ");
            int ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot B: ");
            int bx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B: ");
            int by = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot C: ");
            int cx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C: ");
            int cy = Convert.ToInt32(Console.ReadLine());

            double ab = Math.Sqrt((Math.Pow((bx-ax),2))+(Math.Pow((by-ay),2)));
            double ac = Math.Sqrt((Math.Pow((cx - ax), 2)) + (Math.Pow((cy - ay), 2)));
            double bc = Math.Sqrt((Math.Pow((cx - bx), 2)) + (Math.Pow((cy - by), 2)));
            
            Console.WriteLine($"Lenght of AB is: {ab}");
            Console.WriteLine($"Lenght of BC is: {bc}");
            Console.WriteLine($"Lenght of AC is: {ac}");

            if((ab == ac) && (ac == bc)){
                Console.WriteLine("Triangle IS Equilateral");
            }else{
                Console.WriteLine("Triangle IS NOT Equilateral");
            }

            if((ab == ac) || (ab == bc) || (ac == bc)){
               Console.WriteLine("Triangle IS Isosceles");
            }else{
                Console.WriteLine("Triangle IS NOT Isosceles");
            }

            double vx1 = bx - ax;
            double vx2 = cx - ax;
            double vy1 = by - ay;
            double vy2 = cy - ay;
            double result = (vx1*vx2)+(vy1*vy2);

            if(result==0){
               Console.WriteLine("Triangle IS Right");
            }else{
                Console.WriteLine("Triangle IS NOT Right");
            }
            
            double perimeter = ab + ac + bc;

            Console.WriteLine($"Perimeter: {perimeter}");

            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");

            for(int i = 0;i <= perimeter; i+=2){
                Console.WriteLine(i);
            }

        }
        
    }
    
}