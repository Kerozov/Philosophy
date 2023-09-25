using Application.Models.EssayModels.Dtos;
using Application.Models.EssayModels.Interfaces;

namespace Application.Services;

public class EssayService: IEssayService
{
    public Task<List<string>> GetAllEssay()
    {
        throw new NotImplementedException();
    }

    public Task<string> GetEssayById(int essayId)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateEssay(int id, UpdateEssayDto essay)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddEssay(AddEssayDto essay)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteEssay(int essayId)
    {
        throw new NotImplementedException();
    }
}