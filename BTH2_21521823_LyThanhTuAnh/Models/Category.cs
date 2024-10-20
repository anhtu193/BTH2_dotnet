using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BTH2_21521823_LyThanhTuAnh.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(255)]
        public string CategoryName { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
