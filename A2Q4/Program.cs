using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q4
{
    class Program
    {

        static void Main(string[] args)
        {
            double vectorALenght;
            double vectorAAngle;
            double vectorBLenght;
            double vectorBAngle;

            double angleDiffrance;
            double dotProduct;

            //Capture the values and assign them to the correct intergers
            Console.WriteLine("Please enter the lenght of vector A -");
            vectorALenght = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the angle of vector A -");
            vectorAAngle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the lenght of vector B -");
            vectorBLenght = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the angle of vector B -");
            vectorBAngle = Convert.ToDouble(Console.ReadLine());


            angleDiffrance = vectorBAngle - vectorAAngle; //calculate the differnace in the angles 


            dotProduct = (vectorALenght * vectorBLenght ) * Math.Cos(DegreeToRadians(angleDiffrance));//using built in cos for the calculation and using a new method to convert degrees to radians.

            Console.WriteLine("The dot product of the values you entered is - {0:F2} ", dotProduct);


        }

        private static double DegreeToRadians(double angleDiffrance)
        {
            return angleDiffrance * Math.PI / 180;
        }
    }
}
