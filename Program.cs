using System;

namespace RandomNumber

{
    class GussMyNumber
    {
       public static int SelectNumber = 0;
       public static Random random = new Random();
        public static bool GameOver = false;

        static void Main(string[] args)
        {
            SelectNumber = random.Next(0, 1000);
            int userNumber = 0;

            do
            {
                Console.WriteLine("Choose a number between 1 and 1000: ");
                userNumber = Convert.ToInt32(Console.ReadLine());
                GuessNumber(userNumber); 
            }

            while (GameOver == false);
            Console.ReadLine(); 
        }

        public static void GuessNumber(int userNumber)
        {
            int playAgain = 0; 
            if (userNumber < SelectNumber)
                Console.WriteLine("Too low. Try again" );
            else if (userNumber > SelectNumber)
                Console.WriteLine("Too high. Try again");
            else
            {
                Console.WriteLine("You got the right number! Press 1 to play again or 2 to quit");
                playAgain = Convert.ToInt32(Console.ReadLine()); 

                while (playAgain != 1 && playAgain != 2)
                {
                    Console.WriteLine("Please select only  1 to play again or 2 to qyit");
                    playAgain = Convert.ToInt32(Console.ReadLine()); 

                }
                if (playAgain.Equals(2))
                    GameOver = true;
                else
                    SelectNumber = random.Next(0, 1000); 
            }
        }
        
    }
}

        
    