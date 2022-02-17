using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int DishId { get; set; }


        [Required (ErrorMessage= "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Chef's Name")]
        public string ChefName { get; set; }


        [Required (ErrorMessage= "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Dish's Name")]
        public string DishName { get; set; }


        [Required (ErrorMessage= "is required")]
        [Range(0, int.MaxValue, ErrorMessage ="must be greater than 0")]
        [Display(Name = "Calories")]
        public int Calories { get; set; }


        [Required (ErrorMessage= "is required")]
        [Display(Name = "Tastiness")]
        public int Tastiness { get; set; }


        [Required (ErrorMessage= "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [MaxLength(45, ErrorMessage = "must be max 45 characters")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
