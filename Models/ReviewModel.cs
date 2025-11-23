using System.ComponentModel.DataAnnotations;

namespace ReviewApp.Models
{       

    public class ReviewModel 
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }

        public ReviewModel() 
        { 

        }

        public ReviewModel (int id, string description, string title) 
        {
            Id = id;
            Description = description;
            Title = title;
        }  
    }
}