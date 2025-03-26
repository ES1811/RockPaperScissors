namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool programRunning = true;
            Menu();

            while (programRunning)
            {
                Random random = new Random();
                string[] choice = ["Rock", "Paper", "Scissors"];
                int CpuChoice = random.Next(choice.Length);

                //string? playerchoice;
                ConsoleKeyInfo playerChoice;

                //Console.WriteLine("CPU choice: " + choice[CpuChoice]);
                playerChoice = Console.ReadKey();
                Console.WriteLine();
                Thread.Sleep(700);

                Console.WriteLine("I choose: " + choice[CpuChoice]);
                Thread.Sleep(200);

                switch (playerChoice.Key)
                {
                    case ConsoleKey.D1: //player choice: rock
                        //Console.WriteLine($"Testing... Key pressed is {playerChoice.KeyChar} "); -- testing to see
                        if (CpuChoice == 0) //rock
                        {
                            Console.WriteLine("It's a tie! Try again.");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Menu();
                            break;

                        }
                        else if (CpuChoice == 1) //paper
                        {
                            Console.WriteLine("You lose! Paper beats Rock!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Menu();
                            break;

                        }
                        else if (CpuChoice == 2) //scissors
                        {
                            Console.WriteLine("You win! Rock beats Scissors!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Menu();
                            break;

                        }
                        break;
                    case ConsoleKey.D2: //player choice: paper
                        if (CpuChoice == 0) //rock
                        {
                            Console.WriteLine("You win! Paper beats Rock!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Menu();
                            break;

                        }
                        else if (CpuChoice == 1) //paper
                        {
                            Console.WriteLine("It's a tie! Try again.");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Menu();
                            break;

                        }
                        else if (CpuChoice == 2) //scissors
                        {
                            Console.WriteLine("You lose! Scissors beats Paper!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Menu();
                            break;

                        }
                        break;

                    case ConsoleKey.D3: //player choice: scissors
                        if (CpuChoice == 0) //rock
                        {
                            Console.WriteLine("You lose! Rock beats Scissors!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Menu();
                            break;

                        }
                        else if (CpuChoice == 1) //paper
                        {
                            Console.WriteLine("You win! Scissors beats Paper!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Menu();
                            break;

                        }
                        else if (CpuChoice == 2) //scissors
                        {
                            Console.WriteLine("It's a tie! Try again!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Menu();
                            break;

                        }
                        break;

                    case ConsoleKey.D4: //exit key
                        Console.WriteLine("Exiting game...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        programRunning = false;
                        break;

                    default:
                        Console.WriteLine("You have to make a choice. Exiting game...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        programRunning = false;

                        break;
                }

                // VERSION 3 HERE
                /* --------- 
                I decided to go back to the switch/case lol
                mainly because it'd look messy with the if statements oops
                */
                // if (playerChoice.KeyChar == '4' || playerChoice.KeyChar == 'x')
                // {
                //     Console.WriteLine("Exiting the game...");
                //     break;
                // }

                // Console.WriteLine("I choose: " + choice[CpuChoice]);
                // Thread.Sleep(200);

                // if (playerChoice.KeyChar == '1' && CpuChoice == 0)
                // {
                //     Console.WriteLine("It's a tie!");
                //     //Console.WriteLine($"You have pressed {playerChoice.KeyChar} key");
                // }
                // else if (playerChoice.KeyChar == '1' && CpuChoice == 1)
                // {
                //     Console.WriteLine("You lose! Paper beats Rock!");
                //     //Console.WriteLine($"Key pressed now is {playerChoice.KeyChar}");
                // }
                // else if (playerChoice.KeyChar == '1' && CpuChoice == 2)
                // {
                //     Console.WriteLine("You win! Rock beats Scissors");
                // }
                // else
                // {
                //     Console.WriteLine("You have to make a choice. If you wish to exit, please press 'x' or 4");
                // }

                // VERSION 2 HERE
                // ------- trying to see if i can make it work with key press instead 

                // if (playerchoice == "1" && CpuChoice == 0)
                // {
                //     Console.WriteLine("It's a tie!");
                //     break;
                // }
                // else if (playerchoice == "1" && CpuChoice == 1)
                // {
                //     Console.WriteLine("You win! Rock beats Paper");
                //     break;
                // }
                // else if (playerchoice == "1" && CpuChoice == 2)
                // {
                //     Console.WriteLine("You lose! Paper beats Rock!");
                //     break;
                // }
                // else if(string.IsNullOrWhiteSpace(playerchoice) && string.IsNullOrEmpty(playerchoice))
                // {
                //     Console.WriteLine("You need to make a choice, or press 4 to exit");
                // }
                // else
                // {
                //     break;
                // }

                //VERSION 1 HERE
                //------- i had the right gist of it but i decided to change my mind lol ----------

                // switch(playerchoice)
                // {
                //     case "1":
                //     //Console.WriteLine("hallo");
                //     Console.WriteLine("I choose... ROCK");
                //     if(playerchoice == "rock")
                //     {
                //         Console.WriteLine("It's a tie!");
                //     }
                //     else if(playerchoice == "paper")
                //     {
                //         Console.WriteLine("ROCK beats PAPER, I win!");
                //     }
                //     else if(playerchoice == "scissors")
                //     {
                //         Console.WriteLine("Ah, you win! ROCK beats SCISSORS!");
                //     }
                //     break;
                //     case "2":
                //     break;
                //     case "3":
                //     break;
                //     default:
                //         Console.WriteLine("exiting the game");
                //     break;
                // }

                // if (playerchoice == "4")
                // {
                //     break;
                // }


                //Console.WriteLine("Let's see... I pick: "+ num );
            }

        }
        public static void Menu()
        {
            Console.WriteLine("Pick:");
            Console.WriteLine("1. ROCK");
            Console.WriteLine("2. PAPER");
            Console.WriteLine("3. SCISSORS");
            Console.WriteLine("4. Exit");
        }
    }
}