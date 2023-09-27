using Application.Models.EssayModels.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles;

public class EssayProfile : Profile
{
    public EssayProfile()
    {
        CreateMap<UpdateEssayDto, Essay>();
        CreateMap<AddEssayDto, Essay>();
    }
}