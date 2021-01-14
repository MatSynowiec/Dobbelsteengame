using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Let op deze opdracht is in het Engels.
             * 
             * De opdracht beschrijving: Er moet een kleine dobbelsteen generator gemaakt worden.
             * Deze dobbelsteen applicatie is echter nog niet helemaal af en deze moet jij af maken.
             * In de applicatie vind je verschillende TODO's. Op deze plekken moet jij de code aanvullen of
             * repareren.
             * BELANGRIJK: Zorg ervoor dat je voor elke TODO een commit maakt met een juiste bericht. 
             * De TODO comment mag je weg halen na het repareren van de code.
             * TODO #6 en 7 Staan in de Die class.
             */

            Console.WriteLine("Hello Dice player what's your name?");
            // TODO #1 Let the player fill in his/her name and store that in a variable

            // TODO #2 Use the filled in name to say hello to the player
            Console.WriteLine("Oh hello there. player x");

            Cup cup = new Cup(); // Created the cup object. But it's doesn't work yet. fix TODO 3.1 in the Cup class.
            // TODO #3.2 Fill the cup with dice using the right methods.

            // The user can add all different kind of dice to the cup with numbers between 1 - 100.
            Console.WriteLine("How many eyes does your dice need?");
            // TODO #3.3 Create the constructor of the Die class so you can pass through the max eyes amount   
            // TODO #3.4 Create a die with that number of eyes and add it to the cup.
            // TODO #3.5 Ask if the player want to add another die. If so, add another one. If not go to to the next part where he can throw the dice. 

            Console.WriteLine("When ever you are ready. You can throw the dice by pressing the 'any'-key.");
            Console.ReadLine();
            // TODO #4 Use the cup to throw and print the dice
            /* the print in the console should look somthing like this if the user has 4 dice in de cup:
            * Die 1: 4
            * Die 2: 2
            * Die 3: 6
            * Die 4: 1
            */

            // TODO #7 Use the cup to print out the total number of eyes the user has thrown.

            // TODO #8.1 Ask if the player wants to rethrow.
            // TODO #8.2 Make the program replayable.
            // TODO #9 Create a Class diagram of the code and make sure the Cup class is in it.
        }
    }
}
