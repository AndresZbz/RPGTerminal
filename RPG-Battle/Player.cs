namespace RPG_Battle
{
    internal class Player
    {
        public string name = "";
        public int health = 200;
        public int money = 1000;
        public int damage = 50;
        public int defense = 20;
        public string[] inventory = { "stick", "paper" };

        public void show_stats()
        {
            string inventoryString = string.Join(',', inventory);
            string message = $"{name} stats:\nHealth: {health}\nMoney: {money}\nDamage: {damage}\nDefense: {defense}\nInventory: {inventoryString}";
            Console.WriteLine(message);
        }

        public void combat()
        {
            Console.WriteLine(" do something ");
        }

        //Saves the data in bin/Debug/net8.0/gamedata.txt
        public void save_data()
        {

            string inventoryString = string.Join(",", inventory);

            string[] data_to_save = { $"{name}", $"{health}", $"{money}", $"{damage}", $"{defense}", inventoryString };

            //this saves the file at bin/Debug/net8.0
            File.WriteAllLines("gamedata.txt", data_to_save);

            Console.WriteLine("Data saved!\n");


        }
        //Reads the data saved
        public void load_data()
        {
            string[] read_data = File.ReadAllLines("gamedata.txt");

            name = read_data[0];
            health = int.Parse(read_data[1]);
            money = int.Parse(read_data[2]);
            damage = int.Parse(read_data[3]);
            defense = int.Parse(read_data[4]);

            inventory = read_data[5].Split(',');


            //just for debugging purpouses
            //foreach(string item in read_data)
            //{
            //   Console.WriteLine(item);
            //}
        }
    }
}
