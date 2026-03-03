using System.Threading.Tasks.Sources;

namespace _1_7_Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maxym F.
            
            Part1();
        }

        public static void Part1() 
        {
            string play, keepGoing;
            int rock, paper, scissors, randomPlay;
            double money, bet;

            //Play represents what the person played-Rock, Paper, or Scissors.
            
            Random generator = new Random(3);

            bool done = false;

            //Add begining amount of money and such...

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("You got lucky! You won $100 worth of plays. Awesome!");
            Console.WriteLine("Write Rock, Paper, or Scissors when the pompt that sais Rock, Paper, Scissors, Shoot is shown.");
            Console.WriteLine("If you tie, You do not Gain Nor Lose any money.");
            Console.WriteLine("If You Win, your cash will multiply by 3.2. If you lose, your cash will be divided by 3.2.");
            Console.WriteLine("Let's get started!");

            money = 100;
            

            //rock = 1
            //paper = 2
            //Scissors = 3
            

            while (!done) 
            {
                Console.WriteLine("How much do you want to bet?");
                Double.TryParse(Console.ReadLine(), out bet);
               
                //FIX LOSING MONEY-DO NOT DIVIDE CUZ IT WILL NEVER HIT ZERO
                
                randomPlay = generator.Next(1, 4);

                Console.WriteLine("Rock, Paper, Scissors, Shoot!");
                play = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (play == "rock" && randomPlay == 3) 
                {
                    Console.WriteLine("Nice one! Rock Beats Scissors. You now have " + (bet * 3.2).ToString("C"), "!");
                    money += bet;
                }

                if (play == "rock" && randomPlay == 1) 
                {
                    Console.WriteLine("Oh, A Tie! You still have " + bet.ToString("C"), ".");
                    
                }

                if (play == "rock" && randomPlay == 2) 
                {
                    Console.WriteLine("Oh, You lose! You now have " + (bet / 3.2).ToString("C"), ".");
                    money -= bet;
                }

                if (play == "paper" && randomPlay == 3) 
                {
                    Console.WriteLine("Oh, You lose! You now have " + (bet / 3.2).ToString("C"), ".");
                    money -= bet;
                }

                if (play == "paper" && randomPlay == 1)
                {
                    Console.WriteLine("Nice one! Paper beats Rock! You now have " + (bet * 3.2).ToString("C"), ".");
                    money += bet;
                }

                if (play == "paper" && randomPlay == 2)
                {
                    Console.WriteLine("Oh, A Tie! You still have " + bet.ToString("C"), ".");
                }

                if (play == "scissors" && randomPlay == 3)
                {
                    Console.WriteLine("Oh, A Tie! You still have " + bet.ToString("C"), ".");

                }

                if (play == "scissors" && randomPlay == 1)
                {
                    Console.WriteLine("Oh, You Lose! You now have " + (bet / 3.2).ToString("C"), ".");
                    money -= bet;
                }

                if (play == "scissors" && randomPlay == 2)
                {
                    Console.WriteLine("Nice one! Scissors beats Paper! You now have " + (bet * 3.2).ToString("C"), ".");
                    money += bet;
                }

                Console.WriteLine("Would you like to continue playing? Yes or No?");
                keepGoing = Console.ReadLine().ToLower();

                if (keepGoing == "Yes" || keepGoing == "yes") 
                {
                    Console.WriteLine();
                    done = false;
                }

                if (keepGoing == "No" || keepGoing == "no") 
                {
                    Console.WriteLine("Ok, Goodbye.");
                    done = true;
              
                }

                if (money == 0)
                {
                    Console.WriteLine("You are out of money. Deposit more, or go home, you bum.");
                    done = true;
                }
            }

            
        }
    }
}
