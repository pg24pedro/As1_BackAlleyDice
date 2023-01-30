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

        //printTxt displays the text to a console with a delay from character to character
        public static void printTxt(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }
            Console.WriteLine();
        }

        //Prints Welcome Message. CAN BE COMMENTED BELLOW
        static void printWelcome()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗    ████████╗ ██████╗");
            Console.WriteLine("██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝    ╚══██╔══╝██╔═══██╗");
            Console.WriteLine("██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗         ██║   ██║   ██║");
            Console.WriteLine("██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝         ██║   ██║   ██║");
            Console.WriteLine("╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗       ██║   ╚██████╔╝");
            Console.WriteLine(" ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝       ╚═╝    ╚═════╝");
            Console.WriteLine();
            Console.WriteLine("████████╗███████╗███╗   ██╗ █████╗  ██████╗██╗ ██████╗ ██╗   ██╗███████╗    ██████╗ ██╗ ██████╗███████╗ ");
            Console.WriteLine("╚══██╔══╝██╔════╝████╗  ██║██╔══██╗██╔════╝██║██╔═══██╗██║   ██║██╔════╝    ██╔══██╗██║██╔════╝██╔════╝ ");
            Console.WriteLine("   ██║   █████╗  ██╔██╗ ██║███████║██║     ██║██║   ██║██║   ██║███████╗    ██║  ██║██║██║     █████╗    ");
            Console.WriteLine("   ██║   ██╔══╝  ██║╚██╗██║██╔══██║██║     ██║██║   ██║██║   ██║╚════██║    ██║  ██║██║██║     ██╔══╝   ");
            Console.WriteLine("   ██║   ███████╗██║ ╚████║██║  ██║╚██████╗██║╚██████╔╝╚██████╔╝███████║    ██████╔╝██║╚██████╗███████╗");
            Console.WriteLine("   ╚═╝   ╚══════╝╚═╝  ╚═══╝╚═╝  ╚═╝ ╚═════╝╚═╝ ╚═════╝  ╚═════╝ ╚══════╝    ╚═════╝ ╚═╝ ╚═════╝╚══════╝");
            Console.WriteLine();
            Console.WriteLine("Special Guest: Jack Black as JB, from Tenacius D");
            Console.WriteLine("Promoting a new sequel for Tenacious D: Tenacious D and the Ballad of the Sasquatch");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            printTxt("JB asked me not to say this, but I'm going to read it anyways.");
            printTxt("Because I wrote it");
            printTxt("And it's the truth:");
            printTxt("Ladies & Gentleman, may I present you the one and only rockstar who has defeated the devil...");
            printTxt("The ultimate music machine & genious");
            printTxt("A true visionary of the entretainment industry, comedy god and ladies man.");
            printTxt("Everyone please welcome: JB and KG! TENACIOUUUUUUS D!");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            printTxt("Hey dude! JB speaking here! In order to finance our new album: ");
            printTxt("\"Tenacious-D: The Balad of the Sasquatch\",my compadre KG and I are getting into the");
            printTxt("Gambling Business! Would you like to play this friggin awesome game???");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            printTxt("PRESS ENTER TO PLAY: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.ReadLine();
            printTxt("Alrtight my hard rocking amigo! That's what I'm talking about! ");
            printTxt("Okey so a few ground rules: In order for you to play, you have to give me 200 bucks");
            printTxt("(Come on man, I know you have spent much more on a Justin Bieber ticket for your GF, so dont get cheap on me).");
            printTxt("Once you pay, you'll be the proud owner of 200 Tenacius Bills $");
            printTxt("Each TBill is worth one dollar, which you can exchange back once we complete our album and it hits the best sold record in all rock history!");
            printTxt("Sounds dope, doesn't it? ");
            Console.WriteLine();
            printTxt("Okey so here's how the game work: ");
            printTxt("First, type the kind of bet you want to make, it HAS TO BE a number between 1 and 24!");
            printTxt("(Please, just be cool and type ONLY numbers between 1 and 24!, otherwise I'll get upset.)");
            printTxt("Second, type how much TBills you want to bet");
            printTxt("KG will roll those sweet dices for you and let you know weather you win, or loose.");
            printTxt("Every sinlge dolar you spent here is a generous donation to our creative juices storage");
            printTxt("So please feel free to buy more TBills in case you go broke!");
            Console.WriteLine();
            printTxt("..............................................");
            Console.WriteLine();
            printTxt("I mean, in case you want to play some more hehe...");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            printTxt("PRESS ENTER TO GIVE JB 200 BUCKS: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.ReadLine();
            printTxt("Thanks a lot my brother! We'll make sure of giving you credit as Executive Producer on the album...");
            printTxt("In the mean time, let's play some frigging dices!");
            Console.WriteLine();

        }


        static void Main(string[] args)
        {
            //Initialize main variables
            bool playerContinue = true;
            int playerMoney = 200;

            //For directly playing the game, comment Welcome
            printWelcome();
            

            while (playerContinue) 
            {
                
                Console.ForegroundColor = ConsoleColor.Blue;
                printTxt("Alright man! You have: " + playerMoney);
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
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Ask the user to enter the type of bet it wants to place, and parse it to an integer.
                printTxt("Okay so tell me. What's the bet? : ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string typeOfBetInput = Console.ReadLine();
                int typeOfBet = int.Parse(typeOfBetInput);

                //In case on an invalid bet number, it prompts the user again for it.
                if (typeOfBet <= 0 || typeOfBet > 24)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine();
                    printTxt("C'mon man! I told you 1 to 24. Do you want to upset me? Please just enter a valid number:");
                    Console.WriteLine();
                    continue;
                }

                //Pass the typeOfBet into my diceCheck class in order to print the message
                //Of which bet the user made
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                diceCheck userBetPrint = new diceCheck();
                userBetPrint.printBet(typeOfBet);

                //Ask the player how much money it wants to bet
                Console.ForegroundColor = ConsoleColor.Magenta;
                printTxt("Now, how much TBills you're betting? : ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string sizeOfBetInput = Console.ReadLine();
                int sizeOfBet = int.Parse(sizeOfBetInput);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;

                //If the player is betting more money than what he has, it will be promped to imput again the 
                //money it wants to bet
                if (sizeOfBet > playerMoney) 
                {
                    //Had to convert the playerMoney to string to work on the slow printing method
                    printTxt("Not cool bro! KG here is keeping record on how much TBills you hold. Your maximum bet is:" + playerMoney);
                    continue;
                }

                //Initialize player's roll as an int list by using the rollDice function. Have one spare list delcaration for testing specific scenarios.
                List<int> playerDices = rollDice();
                //List<int> playerDices = new List<int>() { 6,5,6};

                //Prints the dices you got on rollDice()
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=====================");
                printTxt("Dice 1: " + playerDices[0]);
                printTxt("Dice 2: " + playerDices[1]);
                printTxt("Dice 3: " + playerDices[2]);
                Console.WriteLine("=====================");

                Console.WriteLine();
                //Create a userDiceCheck object in order to use the doCheck function.
                diceCheck userDiceCheck = new diceCheck();
                
                //Call the doCheck() function which recieves the dice's values, the type of bet and the size of the bet
                //It returns the profit (or loss) of the player as an integer and prints the game messages.
                int betResult = userDiceCheck.doCheck(playerDices, typeOfBet, sizeOfBet);

                //Updates player money
                playerMoney += betResult;
                Console.WriteLine();

                //Loop braker, if the player has no more money OR if the player reached over 100000
                //He can select either to exit the game or play some more
                //If he does so, his money restarts to 200
                if (playerMoney <= 0)
                {
                    printTxt("Oh no dude! You just run out of TBills! That sucks man...");
                    printTxt("Would you like to purchase some more cash and keep on loosing?");
                    printTxt("...................");
                    printTxt("...................");
                    printTxt("I mean hehe, playing? :");
                    string userIn = Console.ReadLine();
                    if (userIn.ToUpper() != "Y")
                    {
                        playerContinue = false;
                    }

                    else
                    { 
                        playerContinue = true;
                        playerMoney = 200;
                    }


                }

                else if (playerMoney >= 100000)
                {
                    printTxt("What? How did you actually got to win " + playerMoney + " Tbills!?!?");
                    printTxt("OH c'mon man! Now we owe the landlord, the bank and YOU!");
                    printTxt("Okey man, just be patient, would'ya? We still need to get this album done...");
                    printTxt("Then the movie (for marketing purposes), and maybe in 2-5 years we'll hit the charts");
                    printTxt("Wait and see bro! You're taking a very important roll in Rock&Roll History! We'll be in museums and stuff!");
                    printTxt(".......");
                    printTxt("C'mon KG, lets bail before this dude see us, lets go!");
                    printTxt(".......");

                    printTxt("Would you like to play again?: ");
                    string userIn = Console.ReadLine();
                    if (userIn.ToUpper() != "Y")
                    {
                        playerContinue = false;
                    }

                    else
                    {
                        playerContinue = true;
                        playerMoney = 200;
                    }


                }    
            }

        }
    }
}
