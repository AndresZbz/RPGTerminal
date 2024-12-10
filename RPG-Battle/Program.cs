namespace RPG_Battle
{
    public class Program
    {
        static Player player = new Player();
        public static void intro()
        {
            Console.Clear();
            Console.WriteLine("Welcome to this Console Game!\n");
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
            if (player.name == "")
            {
                intro();
            } else
            {
                Console.WriteLine("data loaded, hello ");
            }

        }
    }
}