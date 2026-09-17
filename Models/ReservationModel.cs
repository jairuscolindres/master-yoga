using System;
using System.ComponentModel.DataAnnotations;

namespace MasterYoga.Models
{
    public class ReservationModel
    {
        [Required(ErrorMessage = "Jedi Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid comlink email address")]
        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please choose a yoga session")]
        public string ClassTitle { get; set; } = "Master Yoda Frog Malasana & Hip Mobility";

        [Required]
        public DateTime PreferredDate { get; set; } = DateTime.Today.AddDays(1);

        public string ForceRank { get; set; } = "Padawan";

        public string Notes { get; set; } = string.Empty;
    }

    public class YogaClassModel
    {
        public string Title { get; set; } = string.Empty;
        public string Master { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public string Days { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}