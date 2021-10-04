using GreenHouse.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenHouse.Model.Models
{
    [Table("Posts")]
    public class Post : AudiTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        public int CategoryID { get; set; }

        [MaxLength(256)]
        public string Images { get; set; }

        [MaxLength(256)]
        public string Images2 { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }

        [MaxLength(256)]
        public string Content { get; set; }

        public bool HomeFlag { get; set; }
        public bool HotFlag { get; set; }
        public int? ViewCount { get; set; }

        [MaxLength(256)]
        public string Tags { get; set; }

        public DateTime? ActiveDate { get; set; }
        public bool IsSetTime { get; set; }

        [MaxLength(256)]
        public string ImageFB { get; set; }

        public int CreatedByID { get; set; }
        public int? StructureID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { get; set; }
        
        public virtual IEquatable<PostTag> PostTags { get; set; }

    }
}