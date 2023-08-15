using System.ComponentModel.DataAnnotations;

namespace Opgave_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your length of the cube: ");
            float length= float.Parse(Console.ReadLine());

            Console.Write("Please enter your width of the cube: ");
            float width = float.Parse(Console.ReadLine());

            Console.Write("Please enter your height of the cube: ");
            float height = float.Parse(Console.ReadLine());

            float volume = length * width * height;
            Console.Write("This is your volume of the cube: " + volume);

            Console.Write("\nHave a great day\n");
        }
    }
}