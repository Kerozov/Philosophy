using Application.Models.EssayModels.Dtos;
using Domain.Entities;

namespace Application.Models.EssayModels.Interfaces;

public interface IEssayRepository
{
    public Task<List<EssaysListDto>> GetAllEssay();
    
    public Task<EssaysListDto> GetEssayById(int essayId);
    
    public Task<int> UpdateEssay(int id, UpdateEssayDto essay);
    
    public Task<int> AddEssay(AddEssayDto essayForAdd);
    
    public Task<int> DeleteEssay(int essayId);
}