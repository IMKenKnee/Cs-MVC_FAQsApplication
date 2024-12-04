// Kenny Hedlund
// Chapter 6 FAQ App
// COP.4813

using System.ComponentModel.DataAnnotations;

namespace _6_1_FAQs.Models
{
    public class FAQ
    {
        public int Id { get; set; } // Auto-generated primary key

        [Required(ErrorMessage = "Please enter a question.")]
        public string Question { get; set; }

        [Required(ErrorMessage = "Please enter an answer.")]
        public string Answer { get; set; }

        [Required(ErrorMessage = "Please select a topic.")]
        public string TopicId { get; set; } // Foreign key to Topic

        [Required(ErrorMessage = "Please select a category.")]
        public string CategoryId { get; set; } // Foreign key to Category

        public Topic Topic { get; set; } // Navigation property
        public Category Category { get; set; } // Navigation property
    }
}