using System;
using System.ComponentModel.DataAnnotations;


namespace Lab3.Models
{
    public class Contact
    {
        public int ContactId { get; set;}
        [Required(ErrorMessage = "Please enter a valid first name")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Please enter a valid last name")]
        public string lastName { get; set; }
        [Required(ErrorMessage = "Please enter a valid phone")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Please enter a valid email")]
        public string email { get; set; }
        public string organization { get; set; }
        public DateTime dateAdded { get; set; }
        [Range(1, 10000, ErrorMessage = "Please select a category")]
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public string Slug => firstName?.Replace(' ', '-').ToLower()
            + "-" + lastName?.Replace(' ', '-').ToLower();
    }
}
