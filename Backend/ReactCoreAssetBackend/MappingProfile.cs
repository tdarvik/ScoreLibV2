using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCoreAssetBackend
{
    public class MappingProfile : Profile
    {
        // Work in progress
        public MappingProfile()
        {
            //CreateMap<Employee, EmployeeDto>()
            //    .ForMember(c => c.Name, opt => opt.MapFrom(x => string.Join(' ', x.Firstname, x.Lastname)))
            //    .ForMember(c => c.DepartmentName, opt => opt.MapFrom( x => x.Department.Name))
            //    .ForMember(c => c.PositionName, opt => opt.MapFrom( x => x.Position.Name));

            //CreateMap<Department, DepartmentDto>();
            //CreateMap<Position, PositionDto>();
            CreateMap<Score, ScoreDto>();
        }
    }
}
