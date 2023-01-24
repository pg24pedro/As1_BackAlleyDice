using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;



namespace As1_BackAlleyDice
{
    internal class Program
    {
        //rollDice takes care of generating the 3 random numbers and returns them as a sinlge list
        static List<int> rollDice()
        {
           
            Random rnd = new Random();
            List<int> playerDices = new List<int>();

            for (int i = 0; i < 3;)
            {
                int roll = rnd.Next(1, 7);
                playerDices.Add(roll);
                i++;
            }

            return playerDices;
        }

        //Prints Welcome Message
        static void printWelcome()
        {
            Console.WriteLine("██     ██ ███████ ██       ██████  ██████  ███    ███ ███████     ████████  ██████                                     ");
            Console.WriteLine("██     ██ ██      ██      ██      ██    ██ ████  ████ ██             ██    ██    ██                                    ");
            Console.WriteLine("██  █  ██ █████   ██      ██      ██    ██ ██ ████ ██ █████          ██    ██    ██                                   ");
            Console.WriteLine("██ ███ ██ ██      ██      ██      ██    ██ ██  ██  ██ ██             ██    ██    ██     ");
            Console.WriteLine(" ███ ███  ███████ ███████  ██████  ██████  ██      ██ ███████        ██     ██████      ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("████████ ██   ██ ███████     ██████  ██  ██████ ███████        ██████        ███    ███  █████  ████████ ██  ██████ ");
            Console.WriteLine("   ██    ██   ██ ██          ██   ██ ██ ██      ██            ██    ██       ████  ████ ██   ██    ██    ██ ██       ");
            Console.WriteLine("   ██    ███████ █████       ██   ██ ██ ██      █████   █████ ██    ██ █████ ██ ████ ██ ███████    ██    ██ ██     ");
            Console.WriteLine("   ██    ██   ██ ██          ██   ██ ██ ██      ██            ██    ██       ██  ██  ██ ██   ██    ██    ██ ██       ");
            Console.WriteLine("   ██    ██   ██ ███████     ██████  ██  ██████ ███████        ██████        ██      ██ ██   ██    ██    ██  ██████ ");
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("Bet Types:");
            Console.WriteLine("1. Big           2. Small            3. Odd          4. Even");
            Console.WriteLine("5. All 1s        6. All 2s           7. All 3s       8. All 4s");
            Console.WriteLine("9. All 5s       10. All 6s          11. Double 1s   12. Double 2s");
            Console.WriteLine("13. Double 3s   14. Double 4s       15. Double 5s   16. Double 6s");
            Console.WriteLine("17. Any Triples 18. 4 or 17         19. 5 or 16     20. 6 or 15");
            Console.WriteLine("21. 7 or 14     22. 8 or 13         23. 9 or 12     24. 10 or 11");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            printWelcome();
            bool tst = true;
            int playerMoney = 200;

            while (tst) 
            {
                //Ask the user to enter the type of bet it wants to place
                Console.WriteLine("Type the number of bet you want to place: ");
                string typeOfBetInput = Console.ReadLine();
                int typeOfBet = int.Parse(typeOfBetInput);

                //Ask the player how much money it wants to bet
                Console.WriteLine("Type how much money you'd like to bet: ");
                string sizeOfBetInput = Console.ReadLine();
                int sizeOfBet = int.Parse(sizeOfBetInput);

                //Initialize player's roll as an int list by using the rollDice function. Have one spare list delcaration for testing specific scenarios.
                List<int> playerDices = rollDice();
                //List<int> playerDices = new List<int>() { 6,5,6};

                //Prints the dices you got on rollDice()
                Console.WriteLine(string.Join(",",playerDices));

                //Create a userDiceCheck object in order to use the doCheck function.
                diceCheck userDiceCheck = new diceCheck();
                //Call the doCheck() function which recieves the dice's values, the type of bet and the size of the bet
                //It returns the profit (or loss) of the player as an integer and prints the game messages.
                int betResult = userDiceCheck.doCheck(playerDices, typeOfBet, sizeOfBet);

                playerMoney += betResult;
                Console.WriteLine("You have {0} money remaining....", playerMoney);

                //---------------------------------------------------TO-DO-------------------------------------------------------
                //---------------------------------------------------------------------------------------------------------------
                //---------------------------------------------------------------------------------------------------------------

                //State and check total balance from the user and deduce or sum the money he is winning/loosing on the bet

                //Try again loop breaker:
                Console.WriteLine("Want to try again: ");
                string userIn = Console.ReadLine();
                if (userIn.ToUpper() != "Y")
                { 
                    tst = false;
                }
            }

        }
    }
}
