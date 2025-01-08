using System;
using System.ComponentModel.DataAnnotations;

namespace FindAMovie.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        
        public MembershipType MembershipType { get; set; }

        [Required(ErrorMessage = "Please select a membership type.")]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}