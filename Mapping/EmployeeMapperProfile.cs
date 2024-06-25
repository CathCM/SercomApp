using AutoMapper;
using SercomApp.Models;
using SercomApp.Models.DAO;

namespace SercomApp.Mapping;

public class EmployeeMapperProfile : Profile
{
    public EmployeeMapperProfile()
    {
        CreateMap<EmployeeWoffuDao.Data, Employee>()
            .ForMember(em => em.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(em => em.LastName, opt => opt.MapFrom(src => src.LastName))
            .ForMember(em => em.CompanyEmail, opt => opt.MapFrom(src => src.Email))
            .ForMember(em => em.BirthDate, opt => opt.MapFrom(src => src.Birthday))
            .ForMember(em => em.WoffuId, opt => opt.MapFrom(src => src.UserId))
            .ForMember(em => em.ScheduleId, opt => opt.MapFrom(src => src.ScheduleId))
            .ForMember(em => em.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId));
    }
}