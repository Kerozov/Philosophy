namespace Application.Models.EssayModels.Dtos;

public class UpdateEssayDto
{
    public string Text { get; set; }
    
    public int Rating { get; set; }
    
    public string CreatorName { get; set; }
}