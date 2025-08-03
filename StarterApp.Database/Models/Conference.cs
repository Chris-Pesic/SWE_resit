using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarterApp.Database.Models;

[Table("conference")]
[PrimaryKey(nameof(Id))]
public class Conference
{
    public int Id { get; set; }
    [Required]
    public string Conference_Name { get; set; } = string.Empty;
    [Required]
    public string Speaker { get; set; } = string.Empty;
    [Required]
    public DateTime Time { get; set; }
    [Required]
    public string Location { get; set; } = string.Empty;
    [Required]
    public int Capacity { get; set; }
}