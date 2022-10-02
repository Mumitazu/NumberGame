using System;

namespace NumberGame
{ //                  Mumtaz Mohamud [NET22]
    class Program
    {
        static void Main(string[] args)
        { //Declares variables and gives them value.
            Random random = new Random();
            int randomnumber = random.Next(1, 20);
            int numberofguesses = 5;
            //Callsback CheckGame method.
            CheckGame(randomnumber,numberofguesses);        
        }   
        static void CheckGame (int randomnumber, int numberofguesses)
        {    //Instuction output.        
            int guess;
            bool GameOver = false;
            Console.WriteLine(" Välkommen! Jag tänker på ett nummer.\n Kan du gissa vilket? Du får fem försök. \n Lycka till!\n");
            Console.WriteLine(" Varsågod, skriv in din gissning:");
            //Checks if the users choice of numbers is false or true compared to the random number and gives back a text output accordingly.
            while (GameOver == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                numberofguesses--;

                if (guess != randomnumber && numberofguesses == 0)
                {
                    Console.WriteLine("Oh No!! du kunde inte gissa det på fem försök.");
                    GameOver = true;
                    break;
                }
                else if (guess == randomnumber)
                {
                    Console.WriteLine("WOW!! Grattis! Du gissade rätt");
                    GameOver = true;
                }
                else if (guess < randomnumber)
                    Console.WriteLine("Tyvärr, det är för lågt. Försök igen.");
                else if (guess > randomnumber)
                    Console.WriteLine("Tyvärr, det är för högt. Försök igen");
                                 
            }
            
            
        } 
       
    } 
}
