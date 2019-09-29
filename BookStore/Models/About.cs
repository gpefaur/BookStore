using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class About
    {
        public int Id { get; set; }

        [Display(Name = "My name")]
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "The name length should be between 2 and 50.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "The name length should be between 2 and 50.", MinimumLength = 2)]
        public string Surname { get; set; }

        public string Address { get; set; }
        [StringLength(maximumLength: 50, ErrorMessage = "The country length should be between 2 and 50.", MinimumLength = 2)]
        public string Country { get; set; }

        [Range(1, 100)]
        public decimal Age { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
