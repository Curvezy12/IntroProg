using System.Collections.Generic;
using System.Linq;

namespace rpgproject.models
{
    public class Inventory
    {
        
        public int WeightCapacity { get; set; }
        public List<Item> Items { get; set; }
        
        public Inventory(int weightCapacity, List<Item> items)
        {
            this.WeightCapacity = weightCapacity;
            this.Items = new List<Item>();
        }

        public void SortByName() {
            this.Items = this.Items.OrderBy(i => i.Name).ToList();
        }
        public void SortByWeight() {
            //complete by using above method as a base
        }
        public int GetCurrentCapacity() {
            //return total weightcapacity of items in the items list
            return 0;
        }
        public void AddNewItem(Item item) {
            //add item if it doesnt exceed weightcapacity
        }
        public void RemoveItem(string itemName) {
            //go through list 
            //check each item's name to see if it matches the search term (itemName)
            //if match - remove item, stop loop
            //if no match - keep going through loop

            foreach(Item i in this.Items) {
                if(i.Name == itemName) {
                    this.Items.Remove(i);
                    break;
                }
            }
        }
        public int GetQuantity(string itemName) { 
            return 0;
        }

        public string ListItems() { 
        string result = "Name\t\t\t\t\tWeight\t\tValue\n";
        result += "---------------------------------------------------------------------------\n";
        foreach(Item thing in this.Items) {
            result += $"{thing.Name}\t\t\t\t\t{thing.Weight}\t\t{thing.Value}\n";
        }
            return result;
        }
    }
}

