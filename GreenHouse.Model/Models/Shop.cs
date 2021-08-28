using System.ComponentModel.DataAnnotations.Schema;

namespace GreenHouse.Model.Models
{
    [Table("Shops")]
    public class Shop
    {
        public int StoreID { get; set; }
        public string ShopName { get; set; }
    }
}