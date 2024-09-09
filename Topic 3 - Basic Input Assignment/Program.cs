namespace Topic_3___Basic_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age, currentYear, int1, int2, int3;
            double distance1, distance2, distance3, length1, length2;

            currentYear = DateTime.Now.Year;

            Console.Write("Hey, whats your name? ");
            name = Console.ReadLine();

            Console.Write("How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hello " + name + " you are " + age + " years old and you were born on " + (currentYear - age) + "!");

            Console.WriteLine();

            Console.Write("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Give me three integers:");

            Console.WriteLine();

            Console.Write("What is integer #1: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is integer #2: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is integer #3: ");
            int3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("The sum of the three integers is: " + (int1 + int2 + int3));

            Console.WriteLine();

            Console.Write("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Give me three distances (In Kilometers):");

            Console.WriteLine();

            Console.Write("What is distance #1: ");
            distance1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is distance #2: ");
            distance2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is distance #3: ");
            distance3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("The average of all the distances is: " + Math.Round(((distance1 + distance2 + distance3) / 3), 2));

            Console.WriteLine();

            Console.Write("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Give me two lengths of a right triangle and I will find the length of the hypotenuse");

            Console.WriteLine();

            Console.Write("What is length #1: ");
            length1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is length #2: ");
            length2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("The length of the hypotenuse is: " + (Math.Round(Math.Sqrt(Math.Pow(length1, 2) + Math.Pow(length2, 2)), 2)));
        }
    }
}
