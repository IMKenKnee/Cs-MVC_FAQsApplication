// Kenny Hedlund
// Chapter 6 FAQ App
// COP.4813

using System.ComponentModel.DataAnnotations;

namespace _6_1_FAQs.Models
{
    public class Topic
    {
        [Key]
        public string Id { get; set; } // URL-friendly primary key (e.g., "bootstrap")

        [Required(ErrorMessage = "Please enter a topic name.")]
        public string Name { get; set; } // Display name for the topic

        public ICollection<FAQ> FAQs { get; set; } // One-to-many relationship
    }
}
