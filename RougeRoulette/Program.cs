using System;
using System.ComponentModel.Design;
using System.Formats.Asn1;
using static System.Console;
namespace Rouge_Roulette
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numPlayers = GetPlayerNum("Enter the number of players: ");

            string[] players = GetPlayerNames(numPlayers);

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
                WriteLine("Enter the name of player {0}", i + 1);
                players[i] = ReadLine();
            }

            return players;
        }


        static void Gamestart()
        {
            Clear();
            WriteLine("The game is starting...");
        }
        static void Viewrules()
        {
            Clear();
            WriteLine("1. Welcome to Rouge Roulette! If this is your first time playing a game like Russian Roulette please read below!");
            WriteLine("2. xyz");
            WriteLine("3. xyz");
            WriteLine("4. xyz");
            Awaitingkeypress();
        }
        static void Awaitingkeypress()
        {
            WriteLine("\nPress any key to continue...");
            ReadLine();
        }
    }
}