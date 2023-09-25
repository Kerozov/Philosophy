using Application.Models.EssayModels.Dtos;
using Application.Models.EssayModels.Interfaces;

namespace Persistance.Repositories;

public class EssayRepository: IEssayRepository
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