/* Assignment 2.1.1
Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system). Write overloaded methods with logic and give choice to user to call different methods :
a. Add(int num1, int num2)
b. Add(decimal num1, decimal num2, decimal num3)
c. Multiply(float num1, float num2)
d. Multiply( float num1, float num2, float num3)
Declare these methods as public and static.
*/

namespace Assignment2_1_2
{
    public class Maths
    {
        // Overloaded Add methods
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }

        // Overloaded Multiply methods
        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float Multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }

        static void Main(string[] args)
        {
            // Example usage
            Console.WriteLine("Add(int, int): " + Maths.Add(5, 10)); // Output: 15
            Console.WriteLine("Add(decimal, decimal, decimal): " + Maths.Add(5.5m, 10.2m, 3.3m)); // Output: 19.0
            Console.WriteLine("Multiply(float, float): " + Maths.Multiply(2.5f, 4.0f)); // Output: 10.0
            Console.WriteLine("Multiply(float, float, float): " + Maths.Multiply(2.0f, 3.0f, 4.0f)); // Output: 24.0
        }
    }
}