using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_shop_database
{
    public class Users
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }

    public class Item
    {
        public int Item_Id { get; set; }
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public int ItemQuantity { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public string Categoryname { get; set; }
    }
}
