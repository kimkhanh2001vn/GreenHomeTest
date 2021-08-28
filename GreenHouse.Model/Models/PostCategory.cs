using GreenHouse.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenHouse.Model.Models
{
    [Table("PostCategorys")]
    public class PostCategory : AudiTable
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        public int StoreID { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }

        public int ParentID { get; set; }
        public int DisplayOrder { get; set; }
        public int FontSize { get; set; }

        [MaxLength(256)]
        public string FontAwesomeClass { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}