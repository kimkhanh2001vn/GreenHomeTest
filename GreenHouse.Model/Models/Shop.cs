using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenHouse.Model.Models
{
    [Table("Shops")]
    public class Shop
    {
        [Key]
        public int StoreID { get; set; }
        [Required]
        [MaxLength(256)]
        public string ShopName { get; set; }
    }
}