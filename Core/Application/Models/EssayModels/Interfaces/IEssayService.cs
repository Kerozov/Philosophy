using Application.Models.EssayModels.Dtos;

namespace Application.Models.EssayModels.Interfaces;

public interface IEssayService
{
    public Task<List<EssaysListDto>> GetAllEssay();
    public Task<string> GetEssayById(int essayId);
    public Task<int> UpdateEssay(int essayId, UpdateEssayDto essayToUpdate);
    public Task<int> AddEssay(AddEssayDto essayToAdd);
    
    public Task<int> DeleteEssay(int essayId);

}