using System;
using AutoMapper;

namespace Application.Core;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Domain.EntActivity, Domain.EntActivity>();
        // Add more mappings as needed
    }
}

