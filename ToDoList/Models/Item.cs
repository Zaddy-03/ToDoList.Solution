using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ToDoList.Models
{
    public class Item
    {
        public string Description { get; set; }
        public int Id { get; }

        public Item(string description, int id)
        {
            Description = description;
            Id = Id;
        }
        public static Item Find(int searchId)
        {
            // Temporarily returning placeholder item to get beyond compiler errors until we refactor to work with database.
            Item placeholderItem = new Item("placeholder item");
            return placeholderItem;
        }

        public static void ClearAll()
        {
        }


        public static List<Item> GetAll()
        {
            List<Item> allItems = new List<Item> { };
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM items;";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while (rdr.Read())
            {
                int itemId = rdr.GetInt32(0);
                string itemDescription = rdr.GetString(1);
                Item newItem = new Item(itemDescription, itemId);
                allItems.Add(newItem);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allItems;
        }


    }
}