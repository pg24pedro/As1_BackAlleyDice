using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As1_BackAlleyDice
{
    internal class diceCheck
    {
        
        public diceCheck(List<int> playerDices, int typeOfBet, int sizeOfBet) {
        
            List<int> mPlayerDices = playerDices;
            int mtypeOfBet = typeOfBet;
            int mSizeOfBet = sizeOfBet;
        }
       public int doCheck(List<int> playerDices, int typeOfBet, int sizeOfBet)
        {

            int checkSum = playerDices.Sum();
            Console.WriteLine("Dice sum: {0}", checkSum);
            if (typeOfBet == 1)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    Console.WriteLine("You Loose! You Got Tripples");
                    sizeOfBet = -sizeOfBet;
                    
                }
                else if (checkSum >= 11 && checkSum <= 17)
                {
                    Console.WriteLine("You Won!");
                }
                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 2)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    Console.WriteLine("You Loose! You Got Tripples");
                    sizeOfBet = -sizeOfBet;
                }
                else if (checkSum >= 4 && checkSum <= 10)
                {
                    Console.WriteLine("You Won!");
                }
                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 3)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    Console.WriteLine("You Loose! You Got Tripples");
                    sizeOfBet = -sizeOfBet;
                }
                else if (checkSum % 2 == 0)
                {
                    Console.WriteLine("You Won!");
                }
                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 4)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    Console.WriteLine("You Loose! You Got Tripples");
                    sizeOfBet = -sizeOfBet;
                }
                else if (checkSum % 2 == 1)
                {
                    Console.WriteLine("You Won!");
                }
                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 5)
            {
                if (playerDices.TrueForAll(x => x.Equals(1)))
                {
                    Console.WriteLine("You Win! You Got Tripples of 1");
                    sizeOfBet = sizeOfBet*180 + sizeOfBet;
                }

                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet; 
                }
            }

            else if (typeOfBet == 6)
            {
                if (playerDices.TrueForAll(x => x.Equals(2)))
                {
                    Console.WriteLine("You Win! You Got Tripples of 2");
                    sizeOfBet = sizeOfBet * 180 + sizeOfBet;
                }

                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 7)
            {
                if (playerDices.TrueForAll(x => x.Equals(3)))
                {
                    Console.WriteLine("You Win! You Got Tripples of 3");
                    sizeOfBet = sizeOfBet * 180 + sizeOfBet;
                }

                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 8)
            {
                if (playerDices.TrueForAll(x => x.Equals(4)))
                {
                    Console.WriteLine("You Win! You Got Tripples of 4");
                    sizeOfBet = sizeOfBet * 180 + sizeOfBet;
                }

                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 9)
            {
                if (playerDices.TrueForAll(x => x.Equals(5)))
                {
                    Console.WriteLine("You Win! You Got Tripples of 5");
                    sizeOfBet = sizeOfBet * 180 + sizeOfBet ;
                }

                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 10)
            {
                if (playerDices.TrueForAll(x => x.Equals(6)))
                {
                    Console.WriteLine("You Win! You Got Tripples of 6");
                    sizeOfBet = sizeOfBet * 180 + sizeOfBet;
                }

                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 11)
            {
                if ((playerDices.Count(x => x == 1)) == 2)
                {
                    Console.WriteLine("You Win! You Got Doubles of 1");
                    sizeOfBet = sizeOfBet * 10 + sizeOfBet;
                }

                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 12)
            {
                if ((playerDices.Count(x => x == 2)) == 2)
                {
                    Console.WriteLine("You Win! You Got Doubles of 2");
                    sizeOfBet = sizeOfBet * 10 + sizeOfBet;
                }

                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 13)
            {
                if ((playerDices.Count(x => x == 3)) == 2)
                {
                    Console.WriteLine("You Win! You Got Doubles of 3");
                    sizeOfBet = sizeOfBet * 10 + sizeOfBet;
                }

                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 14)
            {
                if ((playerDices.Count(x => x == 4)) == 2)
                {
                    Console.WriteLine("You Win! You Got Doubles of 4");
                    sizeOfBet = sizeOfBet * 10 + sizeOfBet;
                }

                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 15)
            {
                if ((playerDices.Count(x => x == 5)) == 2)
                {
                    Console.WriteLine("You Win! You Got Doubles of 5");
                    sizeOfBet = sizeOfBet * 10 + sizeOfBet;
                }

                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 16)
            {
                if ((playerDices.Count(x => x == 6)) == 2)
                {
                    Console.WriteLine("You Win! You Got Doubles of 6");
                    sizeOfBet = sizeOfBet * 10 + sizeOfBet;
                }

                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 17)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    Console.WriteLine("You Win! You got Tripples of {0}", playerDices[0]);
                    sizeOfBet = sizeOfBet * 30 + sizeOfBet;
                }
                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 18)
            {
                if (playerDices.Sum() == 4 || playerDices.Sum() == 17)
                {
                    Console.WriteLine("You Win! You got {0}", playerDices.Sum());
                    sizeOfBet = sizeOfBet * 60 + sizeOfBet;
                }
                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 19)
            {
                if (playerDices.Sum() == 5 || playerDices.Sum() == 16)
                {
                    Console.WriteLine("You Win! You got {0}", playerDices.Sum());
                    sizeOfBet = sizeOfBet * 30 + sizeOfBet;
                }
                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 20)
            {
                if (playerDices.Sum() == 6 || playerDices.Sum() == 15)
                {
                    Console.WriteLine("You Win! You got {0}", playerDices.Sum());
                    sizeOfBet = sizeOfBet * 18 + sizeOfBet;
                }
                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 21)
            {
                if (playerDices.Sum() == 7 || playerDices.Sum() == 14)
                {
                    Console.WriteLine("You Win! You got {0}", playerDices.Sum());
                    sizeOfBet = sizeOfBet * 12 + sizeOfBet;
                }
                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 22)
            {
                if (playerDices.Sum() == 8 || playerDices.Sum() == 13)
                {
                    Console.WriteLine("You Win! You got {0}", playerDices.Sum());
                    sizeOfBet = sizeOfBet * 8 + sizeOfBet;
                }
                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 23)
            {
                if (playerDices.Sum() == 9 || playerDices.Sum() == 12)
                {
                    Console.WriteLine("You Win! You got {0}", playerDices.Sum());
                    sizeOfBet = sizeOfBet * 7 + sizeOfBet;
                }
                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 24)
            {
                if (playerDices.Sum() == 10 || playerDices.Sum() == 11)
                {
                    Console.WriteLine("You Win! You got {0}", playerDices.Sum());
                    sizeOfBet = sizeOfBet * 6 + sizeOfBet;
                }
                else
                {
                    Console.WriteLine("You loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            return sizeOfBet;

        }

    }
}
