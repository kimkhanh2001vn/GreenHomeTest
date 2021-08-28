using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenHouse.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string URL { get; set; }

        public int? DispalyOrder { get; set; }

        [Required]
        public int GruopID { get; set; }

        [ForeignKey("GruopID")]
        public virtual MenuGruop MenuGruop { get; set; }

        public string Target { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}