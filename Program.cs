using System.Security.Cryptography;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int playerPoints = 0;

            Console.WriteLine("Welcome to game 21!!");
            Console.WriteLine("Do u want to throw the dice or stop?");
            
            Random rand = new Random();
          


            String answer = Console.ReadLine();

            while (answer != "stop")
            {
                int randomNumber = rand.Next(1, 6);

                playerPoints += randomNumber;
                Console.WriteLine("Player has:");
                Console.WriteLine(playerPoints);
                Console.WriteLine("Player tossed:");                
                Console.WriteLine(randomNumber);
                answer = Console.ReadLine();
                {


                }
            }

            int dealerPoints = 0;
            while (dealerPoints < 17)
            {

                int RandomNumber = rand.Next(1, 6);

                dealerPoints += RandomNumber;
                Console.WriteLine("Dealer has:");
                Console.WriteLine(dealerPoints);
                Console.WriteLine("Dealer tossed:");
                Console.WriteLine(RandomNumber);
            }

            if (playerPoints > 21)
                Console.WriteLine("u lose");

            {

            }

        }
    }
}
