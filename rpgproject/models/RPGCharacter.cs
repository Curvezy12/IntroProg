namespace rpgproject.models
{
    public class RPGCharacter
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public Inventory BackPack { get; set; }

        public RPGCharacter(string name, int maxHP, int maxMana) {
            this.Name = name;
            this.MaxHP = maxHP;
            //set hp to max hp
            this.HP = this.MaxHP;
            this.MaxMana = maxMana;
            //set mana to max mana
            this.Mana = this.MaxMana;
            this.BackPack = new Inventory(100);
        }
        public RPGCharacter() {
            this.Name = "Default Name";
            this.MaxHP = 100;
            //set hp to max hp
            this.HP = this.MaxHP;
            this.MaxMana = 100;
            //set mana to max mana
            this.Mana = this.MaxMana;
            this.BackPack = new Inventory(100);

            this.BackPack.Items.Add(new Item("Health Potion", 1, 10));
            this.BackPack.Items.Add(new Item("Stick", 1, 1));
            this.BackPack.Items.Add(new Weapon("Big Wacky Stick", 5, 5, 1, 5));
        }

        public int Attack(string weaponName) { return 0; }
        public void AddToBackpack(Item item) {
            this.BackPack.AddNewItem(item);
        }
        public void RemoveFromBackpack(Item item) { }
        public string LookInBackpack() { return "";}
    }
}