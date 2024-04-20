using System;
using static System.Console;

namespace Rouge_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                WriteLine("Welcome to Rouge Roulette: Are you prepared to take on the Dealer in a game of fate...?");
                WriteLine("== WARNING EVERYTHING HERE IS FICTIONAL, DO NOT RECREATE WHAT HAPPENS WITHIN THIS GAME ==");
                WriteLine("Enter 1 to start the game.");
                WriteLine("Enter 2 to view the rules.");
                WriteLine("Enter 3 to Exit.");

                string Userinput = ReadLine();
               
                if (Userinput == "1")
                {
                    Gamestart();
                }
                else if (Userinput == "2")
                {
                    Viewrules();
                    Awaitingkeypress(); // Add this line to wait for key press after displaying rules
                }
                else if (Userinput == "3")
                {
                    break;
                }
                else
                {
                    WriteLine("The option you chose was invalid, please only enter 1, 2, or 3. Try again. ");
                    Awaitingkeypress();
                }
            }

        }

        static int GetPlayerNum(string msg)
        {
            int numPlayers;
            string input;
            do
            {
                Write(msg);
                input = ReadLine();
                numPlayers = int.Parse(input);

                if (int.Parse(input) <= 0)
                {
                    WriteLine("Invalid Input.Try Again!");
                }
            } while (int.Parse(input) <= 0);

            return numPlayers;
        }
        
        static string[] GetPlayerNames(int numPlayers)
        {
            string[] players = new string[numPlayers];

            for (int i = 0; i < numPlayers; i++)
            {
                Write("Enter the name of player {0}: ", i + 1);
                players[i] = ReadLine();
            }

            return players;
        }
        
        static void DisplayPlayerNames(string[] players)
        {
            WriteLine("Player names:");
            for (int i = 0; i < players.Length; i++)
            {
                WriteLine(players[i]);
            }
        }

        static void Gamestart()
        {
            Clear();
            WriteLine("The game is starting...");
            int numPlayers = GetPlayerNum("Enter the number of players: ");
            string[] players = GetPlayerNames(numPlayers);
            DisplayPlayerNames(players);
            Awaitingkeypress(); // Add this line to wait for key press after displaying player names

            Revolver revolver1 = new Revolver();
            
        }

        static void Viewrules()
        {
            Clear();
            WriteLine("1. Welcome to Rouge Roulette! If this is your first time playing a game like Russian Roulette please read below!");
            WriteLine("2. xyz");
            WriteLine("3. xyz");
            WriteLine("4. xyz");
        }

        static void Awaitingkeypress()
        {
            WriteLine("\nPress any key to continue...");
            ReadLine();
        }
    }
}
