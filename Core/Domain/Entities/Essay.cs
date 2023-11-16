using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Essay
{
    [Key]
    public int EssayId { get; set; }
    
    [Required]
    [MinLength(10)]
    public string Text { get; set; }

    [Range(1,10)]
    public int Rating { get; set; }
    
    [MinLength(3)]
    public string CreatorName { get; set; }
    public string Title { get; set; }
}