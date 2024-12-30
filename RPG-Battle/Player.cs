using System.Text.Json;

namespace RPG_Battle
{
    internal class Player
    {
        public string name { get; set; } = "";
        public int health { get; set; } = 200;
        public int money  { get; set; } = 1000;
        public int damage { get; set; } = 50;
        public int defense { get; set; } = 20;
        public string[] inventory { get; set; } = { "stick", "paper" };

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
        public void save_data()
        {

            string json = JsonSerializer.Serialize(this);

            //this saves the file at bin/Debug/net8.0
            File.WriteAllText("gamedata.json", json);


            Console.WriteLine("Data saved!\n");


        }
        public void load_data()
        {

            if(File.Exists("gamedata.json"))
            {
                string json = File.ReadAllText("gamedata.json");
                Player data = JsonSerializer.Deserialize<Player>(json);

                this.name = data.name;
                this.health = data.health;
                this.money = data.money;
                this.damage = data.damage;
                this.defense = data.defense;
                this.inventory = data.inventory;

                Console.WriteLine("Data loaded");
            } else
            {
                Console.WriteLine("Could not find a save file");
            }
            //just for debugging purpouses
            //foreach(string item in read_data)
            //{
            //   Console.WriteLine(item);
            //}
        }
    }
}
