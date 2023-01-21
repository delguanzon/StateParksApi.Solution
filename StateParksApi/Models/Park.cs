using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace StateParksApi.Models;

public class Park
{
    public int Id { get; set; }
    public string ParkId { get; set; }
    [Required]
    [MaxLength(30)]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public int Rating { get; set; }
}