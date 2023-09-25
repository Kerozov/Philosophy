using Application.Models.EssayModels.Dtos;

namespace Application.Models.EssayModels.Interfaces;

public interface IEssayService
{
    public Task<List<string>> GetAllEssay();
    public Task<string> GetEssayById(int essayId);
    public Task<int> UpdateEssay(int id, UpdateEssayDto essay);
    public Task<int> AddEssay(AddEssayDto essay);
    
    public Task<int> DeleteEssay(int essayId);

}