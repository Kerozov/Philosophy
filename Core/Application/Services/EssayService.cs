using Application.Models.EssayModels.Dtos;
using Application.Models.EssayModels.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services;

public class EssayService: IEssayService
{
    private readonly IEssayRepository _essayRepository;
    private readonly IMapper _mapper;

    public EssayService(IEssayRepository essayRepository, IMapper mapper)
    {
        _essayRepository = essayRepository;
        _mapper = mapper;
    }
    public Task<List<string>> GetAllEssay()
    {
      return  _essayRepository.GetAllEssay();
    }

    public Task<string> GetEssayById(int essayId)
    {
        return _essayRepository.GetEssayById(essayId);
    }

    public Task<int> UpdateEssay(int essayId, UpdateEssayDto essaytoUpdate)
    {
        return _essayRepository.UpdateEssay(essayId, essaytoUpdate);
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