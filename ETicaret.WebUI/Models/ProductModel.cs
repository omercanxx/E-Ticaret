using ETicaret.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.WebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "Ürün ismi maksimum 60 karakter olmalıdır")]
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Ürün ismi maksimum 100 karakter olmalıdır")]
        public string Description { get; set; }
        [Required(ErrorMessage = "The Price field is required.")]
        public decimal? Price { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
