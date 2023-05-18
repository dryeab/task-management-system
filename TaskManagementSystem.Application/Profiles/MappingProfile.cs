using AutoMapper;
using TaskManagementSystem.Application.Features.Task.DTOs;

namespace TaskManagementSystem.Application.Profiles;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Job, TaskDto>().ReverseMap();
    }
}