// Kenny Hedlund
// Chapter 6 FAQ App
// COP.4813

using System.ComponentModel.DataAnnotations;

namespace _6_1_FAQs.Models
{
    public class Category
    {
        [Key]
        public string Id { get; set; } // URL-friendly primary key (e.g., "general")

        [Required(ErrorMessage = "Please enter a category name.")]
        public string Name { get; set; } // Display name for the category

        public ICollection<FAQ> FAQs { get; set; } // One-to-many relationship
    }
}