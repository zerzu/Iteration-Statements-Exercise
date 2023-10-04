namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 - DONE!
        static void NumberPrinter()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time - DONE!

        static void NumbersByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not - DONE!

        public static bool EqualorNot(int firstInt, int secondInt)
        {
            var intTest = firstInt == secondInt ? true : false;

            Console.WriteLine(intTest);

                return (intTest);
        }
        //Write a method to check whether a given number is even or odd -DONE!

        public static void EvenOdd()
        {
            Console.WriteLine("Please enter a whole number");

            var numberToCheck = Convert.ToInt32(Console.ReadLine());

            var evenOddCheck = numberToCheck % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine(evenOddCheck);
        }

        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative()
        {
            Console.WriteLine("Please enter a number");

            var isItPosOrNeg = Convert.ToInt32(Console.ReadLine());

            var posOrNeg = isItPosOrNeg > 0 ? "positive" : "negative";

            Console.WriteLine(posOrNeg);
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge - DONE!
        //Parse()
        // TODO I will come back to this later
        // TryParse()
        public static void VoterAge()
        {
            Console.WriteLine("How old are you?");

            var userAge = Convert.ToInt32(Console.ReadLine());

            var ageCheck = userAge >= 18 ? "You can vote!" : "Sorry you're not old enough.";

            Console.WriteLine(ageCheck);
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10 - DONE!

        public static void IntegerRange()
        {
            Console.WriteLine("Please enter a number between -10 and 10");

            var toTen = Convert.ToInt32(Console.ReadLine());

            var betweenTheTens = toTen >= -10 && toTen <= 10 ? true : false;

            Console.WriteLine(betweenTheTens);
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer - DONE!

        public static void IntegerMultiples()
        {
            Console.WriteLine("Please enter a whole number");

            var numberToMultiply = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 12;  i++)
            {
                var product = numberToMultiply * i;

                Console.WriteLine(product);
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            NumberPrinter();

            NumbersByThree();

            Console.WriteLine("Please enter an integer");
            var userInt1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another integer");
            var userInt2 = Convert.ToInt32(Console.ReadLine());

            EqualorNot(userInt1, userInt2);

            EvenOdd();

            PositiveOrNegative();

            VoterAge();

            IntegerRange();

            IntegerMultiples();


        }
    }
}
