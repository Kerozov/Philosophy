using Application.Models.EssayModels.Dtos;
using Application.Models.EssayModels.Interfaces;

namespace Application.Services;

public class EssayService: IEssayService
{
    private readonly IEssayRepository _essayRepository;

    public EssayService(IEssayRepository essayRepository)
    {
        _essayRepository = essayRepository;
    }
    public Task<List<string>> GetAllEssay()
    {
      return  _essayRepository.GetAllEssay();
    }

    public Task<string> GetEssayById(int essayId)
    {
        return _essayRepository.GetEssayById(essayId);
    }

    public Task<int> UpdateEssay(int id, UpdateEssayDto essay)
    {
        return _essayRepository.UpdateEssay(id, essay);
    }

    public Task<int> AddEssay(AddEssayDto essay)
    {
        return _essayRepository.AddEssay(essay);
    }

    public Task<int> DeleteEssay(int essayId)
    {
        return _essayRepository.DeleteEssay(essayId);
    }
}