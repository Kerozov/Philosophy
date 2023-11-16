using System.Net.Mime;
using Application.Models.EssayModels.Dtos;
using Application.Models.EssayModels.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Persistance.Repositories;

public class EssayRepository: IEssayRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public EssayRepository(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public Task<List<EssaysListDto>> GetAllEssay()
    {
     return  Task.FromResult(_context.Essays.Select(e=>new EssaysListDto()
     {
         Text = e.Text,
         CreatorName = e.CreatorName,
         Rating = e.Rating,
         EssayId = e.EssayId,
         Title = e.Title
     }).ToList());
    }

    public Task<EssaysListDto> GetEssayById(int essayId)
    {
        var essay = _context.Essays.FirstOrDefault(  e => e.EssayId == essayId);
        var  essayDto = _mapper.Map<EssaysListDto>(essay);
        return  Task.FromResult(essayDto);
    }

    public Task<int> UpdateEssay(int essayId, UpdateEssayDto essaytoUpdate)
    {
        var originalEssay =  _context.Essays.Find(essayId);
        _mapper.Map(essaytoUpdate, originalEssay);
        _context.SaveChanges();
        return  Task.FromResult(originalEssay!.EssayId);
    }

    public Task<int> AddEssay(AddEssayDto essayForAdd)
    {
        var essay = _mapper.Map<Essay>(essayForAdd);
        _context.Essays.Add(essay);
        _context.SaveChanges();
        return Task.FromResult(essay.EssayId);
    }

    public Task<int> DeleteEssay(int essayId)
    {
        var entityToDelete =  _context.Essays.Find(essayId);

        _context.Essays.Remove(entityToDelete!);
        _context.SaveChanges();

        return Task.FromResult(essayId); 
    }
}