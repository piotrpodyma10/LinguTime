using AutoMapper;
using LinguTime.Domain.Dto;
using LinguTime.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinguTime.Domain.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserPointsViewModel, UserPointsDto>();
            CreateMap<CategoryViewModel, CategoryDto>();
            CreateMap<CustomWordMetadataViewModel, CustomWordMetadataDto>();
            CreateMap<CustomWordViewModel, CustomWordsDto>();
            CreateMap<CreateUserViewModel, UsersDto>();
        }
    }
}
