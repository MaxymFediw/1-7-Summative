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
            Console.WriteLine("Write Rock, Paper, or Scissors when the prompt that says Rock, Paper, Scissors, Shoot is shown.");
            Console.WriteLine("If you tie, You do not Gain Nor Lose any money.");
            Console.WriteLine("If You Win, your cash will multiply by 3.2, AND you'll get your bet back! If you guess incorrectly, you will lose your     bet.");
            Console.WriteLine("If you run out of money, it's Game Over.");
            Console.WriteLine("Let's get started!");

            money = 100;
            

            //rock = 1
            //paper = 2
            //Scissors = 3
            

            while (!done) 
            {
               

                Console.WriteLine("You have " + money + " dollars.");
                Console.WriteLine("How much do you want to bet?");
                Double.TryParse(Console.ReadLine(), out bet);

                money -= bet;
                
                randomPlay = generator.Next(1, 4);

                if (bet <= 0) 
                {

                    Console.WriteLine("You think your funny? $1.");
                    bet = 1;
                }

                //if (bet > money) 
                //{
                //    Console.WriteLine("Nuh uh, can't do that. ALL IN!");
                //    bet = money;
                //}
                
                // As you can see above, I did have a system for a max amount the player could bet, but after multiple attempts to troubleshoot, it did not work, and messed up the numbers, God knows how.
               
                Console.WriteLine("Rock, Paper, Scissors, Shoot!");
                play = Console.ReadLine().ToLower();
                Console.WriteLine();

                

                if (play == "rock" && randomPlay == 3) 
                {
                    Console.WriteLine("Nice one! Rock Beats Scissors. You gained " + (bet * 3.2).ToString("C"), " on top of your origional bet!");
                     money += (bet * 3.2);
                }

                if (play == "rock" && randomPlay == 1) 
                {
                    Console.WriteLine("Oh, A Tie! You still have " + bet.ToString("C"), ".");
                    money += bet;
                }

                if (play == "rock" && randomPlay == 2) 
                {
                    Console.WriteLine("Oh, You lose! You lost " + (bet).ToString("C"), ".");
                     money -= bet;
                }

                if (play == "paper" && randomPlay == 3) 
                {
                    Console.WriteLine("Oh, You lose! You lost " + (bet).ToString("C"), ".");
                    money -= bet;
                }

                if (play == "paper" && randomPlay == 1)
                {
                    Console.WriteLine("Nice one! Paper beats Rock! You gained " + (bet * 3.2).ToString("C"), " on top of your origional bet!");
                    money += (bet * 3.2);
                }

                if (play == "paper" && randomPlay == 2)
                {
                    Console.WriteLine("Oh, A Tie! You still have " + bet.ToString("C"), ".");
                    money += bet;
                }

                if (play == "scissors" && randomPlay == 3)
                {
                    Console.WriteLine("Oh, A Tie! You still have " + bet.ToString("C"), ".");
                    money += bet;
                }

                if (play == "scissors" && randomPlay == 1)
                {
                    Console.WriteLine("Oh, You Lose! You lost " + (bet).ToString("C"), ".");
                    money -= bet;
                }

                if (play == "scissors" && randomPlay == 2)
                {
                    Console.WriteLine("Nice one! Scissors beats Paper! You gained " + (bet * 3.2).ToString("C"), " on top of your origional bate!");
                    money += (bet * 3.2);
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
                    Console.WriteLine("Ok, Goodbye. All winnings have been added to you bank account.");
                    done = true;
              
                }

                if (money <= 0)
                {
                    Console.WriteLine("You are out of money. Deposit more, or go home, you bum.");
                    done = true;
                }
            }

            
        }
    }
}
