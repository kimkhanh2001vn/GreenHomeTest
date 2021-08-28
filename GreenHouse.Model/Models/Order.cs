using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenHouse.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { get; set; }

        [MaxLength(256)]
        public string CustomerEmail { get; set; }

        [MaxLength(256)]
        public string CustomerMobile { get; set; }

        [MaxLength(256)]
        public string PaymentMethod { get; set; }

        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        [MaxLength(256)]
        public string PaymentStatus { get; set; }

        public bool Status { get; set; }

        [MaxLength(256)]
        public string CustomerId { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}