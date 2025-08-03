using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarterApp.Database.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        public int ConferenceId { get; set; }

        [Required]
        public Conference Conference { get; set; } = null!;

        [Required]
        public int UserId { get; set; }

        [Required]
        public User User { get; set; } = null!;
    }
}