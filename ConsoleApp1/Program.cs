using System;

class Program
{
    static void Main()
    {

        String PlayAgain = "y";
        Random RandonNumGenerator = new Random();
        do
        {
            Console.WriteLine("Your Roll");
            //  int FirstNumber = int.Parse(Console.ReadLine());
            //  int SecondNumber = int.Parse(Console.ReadLine());
            int MyRoll1 = RandonNumGenerator.Next(1, 7);
            int MyRoll2 = RandonNumGenerator.Next(1, 7);
            // string a = Console.ReadLine();
            //string b = Convert.ToInt32(Console.ReadLine();
            //  Console.WriteLine("You rolled a  " + FirstNumber + " and a " + SecondNumber);
            Console.WriteLine("You rolled a  " + MyRoll1 + " and a " + MyRoll2);

            //   int MyTotal = (FirstNumber + SecondNumber);
            int MyTotal = (MyRoll1 + MyRoll2);
            Console.WriteLine("Total is " + MyTotal);

            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.WriteLine("Computer's Roll");

            int ComputerRoll1 = RandonNumGenerator.Next(1, 7);
            int ComputerRoll2 = RandonNumGenerator.Next(1, 7);
            int ComputerTotal = ComputerRoll1 + ComputerRoll2;
            Console.WriteLine("Computer rolled a  " + ComputerRoll1 + " and a  " + ComputerRoll2);
            Console.WriteLine("Total is " + ComputerTotal);
            if (MyTotal < ComputerTotal)
            {
                Console.WriteLine(" You LOST :( ");
            }
            else if (MyTotal == ComputerTotal)
            {
                Console.WriteLine("it is a Draw");
            }
            else
            {
                Console.WriteLine("You Won :)");
            }



            Console.WriteLine("Play again ? y or n ");

            PlayAgain = Console.ReadLine();






        } while (PlayAgain != "n");

        Environment.Exit(0);



    }
}


