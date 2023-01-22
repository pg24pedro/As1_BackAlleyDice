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

        static void diceCheck(List<int> playerDices, int typeOfBet) 
        { 
            
            int checkSum = playerDices.Sum();
            Console.WriteLine("Dice sum: {0}", checkSum);
            if (typeOfBet == 1)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    Console.WriteLine("You Loose! You Got Tripples");
                }
                else if (checkSum >= 11 && checkSum <= 17)
                {
                    Console.WriteLine("You Won!");
                }
                else
                {
                    Console.WriteLine("You loose");
                }
            }

            else if (typeOfBet == 2)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    Console.WriteLine("You Loose! You Got Tripples");
                }
                else if (checkSum >= 4 && checkSum <= 10)
                {
                    Console.WriteLine("You Won!");
                }
                else
                {
                    Console.WriteLine("You loose");
                }
            }

            else if (typeOfBet == 3)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    Console.WriteLine("You Loose! You Got Tripples");
                }
                else if (checkSum % 2 == 0)
                {
                    Console.WriteLine("You Won!");
                }
                else
                {
                    Console.WriteLine("You loose");
                }
            }

            else if (typeOfBet == 4)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    Console.WriteLine("You Loose! You Got Tripples");
                }
                else if (checkSum % 2 == 1)
                {
                    Console.WriteLine("You Won!");
                }
                else
                {
                    Console.WriteLine("You loose");
                }
            }

            else if (typeOfBet == 5)
            {
                if (playerDices.TrueForAll(x => x.Equals(1)))
                {
                    Console.WriteLine("You Win! You Got Tripples of 1");
                }

                else
                {
                    Console.WriteLine("You loose");
                }
            }

            else if (typeOfBet == 6)
            {
                if (playerDices.TrueForAll(x => x.Equals(2)))
                {
                    Console.WriteLine("You Win! You Got Tripples of 2");
                }

                else
                {
                    Console.WriteLine("You loose");
                }
            }

            else if (typeOfBet == 7)
            {
                if (playerDices.TrueForAll(x => x.Equals(3)))
                {
                    Console.WriteLine("You Win! You Got Tripples of 3");
                }

                else
                {
                    Console.WriteLine("You loose");
                }
            }

            else if (typeOfBet == 8)
            {
                if (playerDices.TrueForAll(x => x.Equals(4)))
                {
                    Console.WriteLine("You Win! You Got Tripples of 4");
                }

                else
                {
                    Console.WriteLine("You loose");
                }
            }

            else if (typeOfBet == 9)
            {
                if (playerDices.TrueForAll(x => x.Equals(5)))
                {
                    Console.WriteLine("You Win! You Got Tripples of 5");
                }

                else
                {
                    Console.WriteLine("You loose");
                }
            }

            else if (typeOfBet == 10)
            {
                if (playerDices.TrueForAll(x => x.Equals(6)))
                {
                    Console.WriteLine("You Win! You Got Tripples of 6");
                }

                else
                {
                    Console.WriteLine("You loose");
                }
            }

            else if (typeOfBet == 11)
            {
                if ((playerDices.Count(x => x == 1)) == 2)
                {
                    Console.WriteLine("You Win! You Got Doubles of 1");
                }

                else
                {
                    Console.WriteLine("You loose");
                }
            }

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
            while (tst) 
            {
                //Ask the user to enter the type of bet it wants to place
                Console.WriteLine("Type the number of bet you want to place: ");
                string typeOfBetInput = Console.ReadLine();
                int typeOfBet = int.Parse(typeOfBetInput);

                //Initialize player's roll as an int list by using the rollDice function
                List<int> playerDices = rollDice();
                
                //Checker for testing specific scenarios on the diceCheck() function
                //List<int> playerDices = new List<int>() {6, 1, 1 };
                
                //Prints the dices you got on rollDice()
                Console.WriteLine(string.Join(",",playerDices));
                
                //diceCheck validates if the values that were rolled satisfy the type of bet the user placed
                diceCheck(playerDices, typeOfBet);


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
