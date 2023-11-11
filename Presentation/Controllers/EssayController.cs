using Application.Models.EssayModels.Dtos;
using Application.Models.EssayModels.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/Essay")]
[EnableCors("AllowAnyOrigin")]
[ApiController]
public class EssayController: ControllerBase
{
    private IEssayService _essayService;

    public EssayController(IEssayService essayService)
    {
        _essayService = essayService;
    }
    
    [HttpGet]
    [Route("All")]
    public async Task<List<EssaysListDto>> GetAllEssay()
    {
        return await _essayService.GetAllEssay();
    }
    
    [HttpGet]
    [Route("{essayId}")]
    public async Task<string> GetEssayById(int essayId)
    {
        return await _essayService.GetEssayById(essayId);
    }
    
    [HttpPost ]
    [Route("Add")]
    public async Task<int> AddEssay(AddEssayDto essay)
    {
        return await _essayService.AddEssay(essay);
    }

    [HttpPut]
    [Route("Edit/{id}")]
    public async Task<int> UpdateEssay(int id, UpdateEssayDto essay)
    {
        return await _essayService.UpdateEssay(id, essay);
    }
    
    [HttpDelete]
    [Route("Delete/{essayId}")]
    public async Task<int> UpdateEssay(int essayId)
    {
        return await _essayService.DeleteEssay(essayId);
    }
}