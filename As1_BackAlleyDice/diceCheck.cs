using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As1_BackAlleyDice
{
    internal class diceCheck
    {
        //Function copied here as well so I can print the messages slowly.
        public static void printTxt(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }
            Console.WriteLine();
        }

        //Do check compares the dices with the conditions of each type of bet
        //Inputs the three dices (as a number list), the type of bet and the money the player bet.
        //As output, it returns the result of the bet (the net money amount to be won or loose).
        public int doCheck(List<int> playerDices, int typeOfBet, int sizeOfBet)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            int checkSum = playerDices.Sum();
            Console.WriteLine();
            printTxt("Your dices sum up tooooo: " + checkSum);

            //For the first four types of bet, if succesfull, we return the sifeOfBet as is
            //given the 1 to 1 probability 

            if (typeOfBet == 1)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    printTxt("Aaaah snap, man! You got a tripple, sorry buddy");
                    sizeOfBet = -sizeOfBet;
                    
                }
                else if (checkSum >= 11 && checkSum <= 17)
                { 
                    printTxt("Looks like you won man! KG, give him his TBills...");
                }
                else
                {
                    printTxt("Looks like the God of Rock is not in your behalf today!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 2)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    printTxt("Tripples over here! That doesn't count bro! Sorry");
                    sizeOfBet = -sizeOfBet;
                }
                else if (checkSum >= 4 && checkSum <= 10)
                {
                    printTxt("Niiiiice! Well done buddy");
                    printTxt("*cough* KG, now use the OTHER dices *cough*");
                }
                else
                {
                    printTxt("Sorry compadre! Seems like you loose");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 3)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    printTxt("Looks like triples! Sorry bro!");
                    sizeOfBet = -sizeOfBet;
                }
                else if (checkSum % 2 == 1)
                {
                    printTxt("Whoaaa we have a mage over here! You've won pal!");
                }
                else
                {
                    printTxt("Sorry buddy, no TBills for you...");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 4)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    printTxt("Triples man! No dough for you!");
                    sizeOfBet = -sizeOfBet;
                }
                else if (checkSum % 2 == 0)
                {
                    printTxt("Amazing bro! Keep it up!");
                }
                else
                {
                    printTxt("Sorry man! Just remember you're not loosing, you're donating...");
                    sizeOfBet = -sizeOfBet;
                }
            }

            //For the rest of the bets, if the condition is correct, we return the multiplied
            //amount of money with the odds plus what he originally bet

            else if (typeOfBet == 5)
            { 
                if (playerDices.TrueForAll(x => x.Equals(1)))
                {
                    printTxt("Holly cow man! How did you guessed that? Hmmm.....");
                    sizeOfBet = sizeOfBet*180 + sizeOfBet;
                    //Ej. if he bets 10, he would get 1810 (1800 of the odds + the original 10 he bet).
                }

                else
                {
                    printTxt("That was kind of a stretch man, but no worries! Lets keep playing!");
                    sizeOfBet = -sizeOfBet; 
                }
            }

            else if (typeOfBet == 6)
            {
                if (playerDices.TrueForAll(x => x.Equals(2)))
                {
                    printTxt("Whaaaat? How's that even possible? Okay man, well pay you.... eventually...");
                    sizeOfBet = sizeOfBet * 180 + sizeOfBet;
                }

                else
                {
                    printTxt("It was a hard one my bro! But at least you tried!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 7)
            {
                if (playerDices.TrueForAll(x => x.Equals(3)))
                {
                    printTxt("C'MON KG HOW'S THAT EVEN....");
                    printTxt("I mean....");
                    printTxt("Congrats! hehe .......");
                    sizeOfBet = sizeOfBet * 180 + sizeOfBet;
                }

                else
                {
                    printTxt("Keep it up buddy, eventually you'll win something!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 8)
            {
                if (playerDices.TrueForAll(x => x.Equals(4)))
                {
                    printTxt("WHAT? Hmmm just keep in mind that you are SUPPORTING US alright? You Won");
                    sizeOfBet = sizeOfBet * 180 + sizeOfBet;
                }

                else
                {
                    printTxt("C'mon buddy, it's just a game! Try again!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 9)
            {
                if (playerDices.TrueForAll(x => x.Equals(5)))
                {
                    printTxt("This is imposible! We're you sent by THE MAN or something?");
                    sizeOfBet = sizeOfBet * 180 + sizeOfBet ;
                }

                else
                {
                    printTxt("Don't cry man, there was a 180 to 1 chance you got this right...");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 10)
            {
                if (playerDices.TrueForAll(x => x.Equals(6)))
                {
                    printTxt("So that's the number of the beast! Iron Maiden would be proud bro! If you give back that money, we could get you to meet them!");
                    sizeOfBet = sizeOfBet * 180 + sizeOfBet;
                }

                else
                {
                    printTxt("Looks like you don't have the devil inside bro! Muahaha");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 11)
            {
                if ((playerDices.Count(x => x == 1)) == 2)
                {
                    printTxt("Nicely done my young rock apprentice. Lets roll again!");
                    sizeOfBet = sizeOfBet * 10 + sizeOfBet;
                }

                else
                {
                    printTxt("You can always try again, unluky one!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 12)
            {
                if ((playerDices.Count(x => x == 2)) == 2)
                {
                    printTxt("Hmmm nice bro! Now we owe you some money :D");
                    sizeOfBet = sizeOfBet * 10 + sizeOfBet;
                }

                else
                {
                    printTxt("Just be patience my bro! You'll eventually get one right!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 13)
            {
                if ((playerDices.Count(x => x == 3)) == 2)
                {
                    printTxt("Doubles of 3! Great job mah man!");
                    sizeOfBet = sizeOfBet * 10 + sizeOfBet;
                }

                else
                {
                    printTxt("C'mon man! You can do this!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 14)
            {
                if ((playerDices.Count(x => x == 4)) == 2)
                {
                    printTxt("Iiiish, you got it! You're awesome!");
                    printTxt("*cough* prepare to bail KG *cough*");
                    sizeOfBet = sizeOfBet * 10 + sizeOfBet;
                }

                else
                {
                    printTxt("You're getting there man! You'll get one right... Eventually...");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 15)
            {
                if ((playerDices.Count(x => x == 5)) == 2)
                {
                    printTxt("Aaaaand those are two 5s! Nicely done compadre!");
                    sizeOfBet = sizeOfBet * 10 + sizeOfBet;
                }

                else
                {
                    printTxt("Don't feel bad bro! After all you're in this for helping! :D");
                    sizeOfBet = -sizeOfBet;
                }
            }

            else if (typeOfBet == 16)
            {
                if ((playerDices.Count(x => x == 6)) == 2)
                {
                    printTxt("Aaaand two 6s! Awesome! I guess....");
                    sizeOfBet = sizeOfBet * 10 + sizeOfBet;
                }

                else
                {
                    printTxt("You almost got it bro! I think....");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 17)
            {
                if (playerDices.TrueForAll(x => x.Equals(playerDices.First())))
                {
                    printTxt("Holly cow! You got triples of " + playerDices[0] + "s. Congrats......?");
                    sizeOfBet = sizeOfBet * 30 + sizeOfBet;
                }
                else
                {
                    printTxt("C'mon man! You'll eventually win... something....");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 18)
            {
                if (playerDices.Sum() == 4 || playerDices.Sum() == 17)
                {
                    printTxt("Congrats man! You got " + playerDices.Sum());
                    sizeOfBet = sizeOfBet * 60 + sizeOfBet;
                }
                else
                {
                    printTxt("Long strech pal. But keep on betting!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 19)
            {
                if (playerDices.Sum() == 5 || playerDices.Sum() == 16)
                {
                    printTxt("You actually got " + playerDices.Sum() + "well done, I guess...");
                    sizeOfBet = sizeOfBet * 30 + sizeOfBet;
                }
                else
                {
                    printTxt("C'mon man! Keep on trying!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 20)
            {
                if (playerDices.Sum() == 6 || playerDices.Sum() == 15)
                {
                    printTxt("Aaaah man! You actually got " + playerDices.Sum() + "Congrats...... hmmm");
                    sizeOfBet = sizeOfBet * 18 + sizeOfBet;
                }
                else
                {
                    printTxt("Sorry my brother! Maybe next time!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 21)
            {
                if (playerDices.Sum() == 7 || playerDices.Sum() == 14)
                {
                    printTxt("Thats...... awesome! you got " + playerDices.Sum());
                    sizeOfBet = sizeOfBet * 12 + sizeOfBet;
                }
                else
                {
                    printTxt("And that's a no go! Sorry buddy!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 22)
            {
                if (playerDices.Sum() == 8 || playerDices.Sum() == 13)
                {
                    printTxt("Oooooh C.... Congrats bro! Hehehe you got " + playerDices.Sum());
                    sizeOfBet = sizeOfBet * 8 + sizeOfBet;
                }
                else
                {
                    printTxt("Let's try again buddy!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 23)
            {
                if (playerDices.Sum() == 9 || playerDices.Sum() == 12)
                {
                    printTxt("What the...? I mean great! You actually got " + playerDices.Sum());
                    sizeOfBet = sizeOfBet * 7 + sizeOfBet;
                }
                else
                {
                    printTxt("Sorry buddy! Try again!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            if (typeOfBet == 24)
            {
                if (playerDices.Sum() == 10 || playerDices.Sum() == 11)
                {
                    printTxt("Aaaalright you did it bro! You got " + playerDices.Sum());
                    sizeOfBet = sizeOfBet * 6 + sizeOfBet;
                }
                else
                {
                    printTxt("Sorry my pal! Next time!");
                    sizeOfBet = -sizeOfBet;
                }
            }

            //Return the net win or loose of money
            return sizeOfBet;

        }

        //Checks for the type of bet the user placed and prints the corresponding message
        public void printBet(int typeOfBet)
        {
            switch (typeOfBet)
            {
                case 1:
                    Console.WriteLine("Looks like you selected Big!");
                    break;

                case 2:
                    Console.WriteLine("Looks like you selected Smal!");
                    break;

                case 3:
                    Console.WriteLine("Looks like you selected Odd!");
                    break;

                case 4:
                    Console.WriteLine("Looks like you selected Even!");
                    break;
                case 5:
                    Console.WriteLine("Looks like you selected All 1s!");
                    break;
                case 6:
                    Console.WriteLine("Looks like you selected All 2s!");
                    break;
                case 7:
                    Console.WriteLine("Looks like you selected All 3s!");
                    break;
                case 8:
                    Console.WriteLine("Looks like you selected All 4s!");
                    break;
                case 9:
                    Console.WriteLine("Looks like you selected All 5s!");
                    break;
                case 10:
                    Console.WriteLine("Looks like you selected All 6s!");
                    break;
                case 11:
                    Console.WriteLine("Looks like you selected Double 1s!");
                    break;
                case 12:
                    Console.WriteLine("Looks like you selected Double 2s!");
                    break;
                case 13:
                    Console.WriteLine("Looks like you selected Double 3s!");
                    break;
                case 14:
                    Console.WriteLine("Looks like you selected Double 4s!");
                    break;
                case 15:
                    Console.WriteLine("Looks like you selected Double 5s!");
                    break;
                case 16:
                    Console.WriteLine("Looks like you selected Double 6s!");
                    break;
                case 17:
                    Console.WriteLine("Looks like you selected Any Triples!");
                    break;
                case 18:
                    Console.WriteLine("Looks like you selected 4 or 17!");
                    break;
                case 19:
                    Console.WriteLine("Looks like you selected 5 or 16!");
                    break;
                case 20:
                    Console.WriteLine("Looks like you selected 6 or 15!");
                    break;
                case 21:
                    Console.WriteLine("Looks like you selected 7 or 14!");
                    break;
                case 22:
                    Console.WriteLine("Looks like you selected 8 or 13!");
                    break;
                case 23:
                    Console.WriteLine("Looks like you selected 9 or 12!");
                    break;
                case 24:
                    Console.WriteLine("Looks like you selected 10 or 11!");
                    break;

                default:
                    Console.WriteLine("Hey that's an invalid number bro!");
                    break;

            }
        }
    }
}

