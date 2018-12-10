using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalloutVideoGameClasses
{
    class Program
    {
        //**********************
        //Capstone Prject: Fallout Style video game Classes
        //Programmer: Cole Burns
        //Date: 12/2/18
        //***********************

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            DisplayOpeningScreen();
            DisplayMenu();
            DisplayClosingScreen();

        }

        static void DisplayMenu()
        {

            GameList Halo;
            Halo = InitializeGameHalo("HALO");
            GameList Destiny2;
            Destiny2 = InitializeGameDestiny2("DESTINY 2");

            //add game to list
            List<GameList> gameList = new List<GameList>();
            gameList.Add(Halo);
            gameList.Add(Destiny2);

            string menuChoice;
            bool exiting = false;

            while (!exiting)
            {


                DisplayHeader(" ________|-Main Menu-|________________\n\t\t|                                     |");


                Console.WriteLine("\t\t   A) Display All Games and Info");
                Console.WriteLine("\t\t   B) Add a Game to the list");
                Console.WriteLine("\t\t   C) Delete a Game from the list");
                //Console.WriteLine("\t\t   D) Display Game Info");

                Console.WriteLine("\t\t   F) Exit");

                Console.Write("\t\t   Enter Choice:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "A":
                    case "a":
                        DisplayAllGames(gameList);
                        break;

                    case "B":
                    case "b":
                        DisplayGetUsersGame(gameList);
                        break;

                    case "C":
                    case "c":
                        DisplayDeletedGame(gameList);
                        break;

                    case "D":
                    case "d":
                        //DisplayGameInfo(gameList);
                        break;

                    case "E":
                    case "e":

                        break;

                    case "F":
                    case "f":
                        exiting = true;
                        break;

                    default:
                        break;
                }
            }
        }

        static void DisplayAllGames(List<GameList> game_List)
        {
            DisplayHeader(" __________|-List of Games and Info-|________________\n\t\t|                                                   |");



            foreach (GameList gameList in game_List)
            {
                Console.WriteLine(gameList.GameInfo());

            }

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display a screen to get a new game from the user
        /// </summary>
        /// <param name="game_List">list of games</param>
        static void DisplayGetUsersGame(List<GameList> game_List)
        {

            //create (instantiate) a new Game object
            DisplayHeader("\t\tAdd a Game");

            GameList usersGame = new GameList();

            // get the users game information
            Console.Write("\t\tEnter Name:");
            usersGame.Name = Console.ReadLine().ToUpper();
            Console.Write("\t\tEnter Game Rating opinion:");
            double.TryParse(Console.ReadLine(), out double gameRating);
            usersGame.GameRating = gameRating;
            Console.Write("\t\tIs Splitscreen CO-OP:");

            if (Console.ReadLine().ToUpper() == "YES")
            {
                usersGame.SplitScreenCoOp = true;

            }
            else
            {
                usersGame.SplitScreenCoOp = false;

            }

            Console.Write("\t\tEnter the Creator of the Game:");
            usersGame.CreatorOfGame = Console.ReadLine();
            Console.Write("\t\tEnter Game Genre:");
            Enum.TryParse(Console.ReadLine().ToUpper(), out GameList.GameGenre videoGame);
            usersGame.VideoGameGenre = videoGame;



            //add Game to list
            game_List.Add(usersGame);

            DisplayContinuePrompt();
        }

        //Commented out code block
        //static void DisplayGameInfo(List<GameList> game_List)
        //{
        //    string usersGameChoice;

        //    DisplayHeader("Display Game Info");


        //    //get Game Name from user
        //    foreach (GameList gameList in game_List)
        //    {
        //        Console.WriteLine(gameList.Name);
        //    }
        //    Console.WriteLine();
        //    Console.Write("\t\tEnter Game Name:");
        //    usersGameChoice = Console.ReadLine();

        //    //Display Game info
        //    bool gameFound = false;
        //    foreach (GameList gameList in game_List)
        //    {
        //        if (gameList.Name == usersGameChoice)
        //        {
        //            Console.WriteLine(gameList.Name);
        //            Console.WriteLine(gameList.GameRating);
        //            Console.WriteLine(gameList.SplitScreenCoOp);
        //            Console.WriteLine(gameList.VideoGameGenre);
        //            Console.WriteLine(gameList.CreatorOfGame);
        //            gameFound = true;
        //            break;
        //        }

        //    }

        //    if (!gameFound)
        //    {
        //        Console.WriteLine($"\t\tUnable to locate the Game Named {usersGameChoice}");
        //    }

        //    DisplayContinuePrompt();
        //}

        static void DisplayDeletedGame(List<GameList> game_List)
        {
            string usersGameChoice;

            DisplayHeader("Delete Game Info");


            //get Game name from user
            foreach (GameList gameList in game_List)
            {
                Console.WriteLine("\t\t" + gameList.Name);
            }
            Console.WriteLine();
            Console.Write("\t\tEnter Game Name:");
            usersGameChoice = Console.ReadLine().ToUpper();

            //Delete Game Info
            bool gameFound = false;
            foreach (GameList gameList in game_List)
            {
                if (gameList.Name == usersGameChoice)
                {
                    game_List.Remove(gameList);
                    gameFound = true;
                    break;
                }

            }

            if (!gameFound)
            {
                Console.WriteLine($"\t\tUnable to locate the Game Named {usersGameChoice}");
            }

            DisplayContinuePrompt();
        }

        static GameList InitializeGameHalo(string name)
        {
            GameList Halo = new GameList(name);

            Halo.GameRating = 9;
            Halo.SplitScreenCoOp = true;
            Halo.VideoGameGenre = GameList.GameGenre.FPS;
            Halo.CreatorOfGame = "Bungie";


            return Halo;
        }

        static GameList InitializeGameDestiny2(string name)
        {
            GameList Destiny2 = new GameList(name);

            Destiny2.GameRating = 6.5;
            Destiny2.SplitScreenCoOp = false;
            Destiny2.VideoGameGenre = GameList.GameGenre.FPS;
            Destiny2.CreatorOfGame = "Bungie";


            return Destiny2;
        }


        #region HELPER METHODS

        /// <summary>
        /// display opening screen
        /// </summary>
        static void DisplayOpeningScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tWelcome to my Fallout Style Video Game Class List");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tThanks for using my Fallout Style Video Game Class List.");
            Console.WriteLine();

            Console.WriteLine("\t\tPress any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\t\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display header
        /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();


        }

        #endregion
    }
}
