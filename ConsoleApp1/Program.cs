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