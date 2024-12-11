namespace RPG_Battle
{
    public class Program
    {
        static Player player = new Player();
        public static void Menu()
        {
            Console.Clear();
            TextManager.center_text("Welcome to this Console Game!\n", ConsoleColor.Cyan);
            Console.ResetColor();

            TextManager.center_text("Please select an option:\n\n");
            TextManager.center_text("1 - New Game\n");
            TextManager.center_text("2 - Load Game\n");

            int option =  Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    intro();
                    break;

                case 2:
                    //todo
                    break;

                default:
                    Menu();
                    break;
            }

        }

        public static void intro()
        {
            Console.Clear();
            Console.Write("Please choose a name: ");
            string name = Console.ReadLine();

            Console.Write($"Is {name} correct? [Y/N]: ");
            string option = Console.ReadLine();

            switch(option)
            {
                case "Y":
                    Console.WriteLine("Perfect! Now You're about to start the game.");
                    player.name = name;
                    start_game();
                    break;
                case "N":
                    intro();
                    break;
                default:
                    Console.WriteLine("Thats not a valid input");
                    intro();
                    break;
            }
        }

        public static void start_game()
        {
            //to-do
            player.show_stats();
        }

        public static void Main(string[] args)
        {
            //player.load_data();
            Menu();

        }
    }
}