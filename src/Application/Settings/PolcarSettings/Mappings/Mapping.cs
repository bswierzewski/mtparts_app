﻿using Application.Settings.PolcarSettings.Commands;
using Application.Settings.PolcarSettings.Queries;
using AutoMapper;
using Domain.Entities.Settings;

namespace Application.Settings.PolcarSettings.Mappings
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Polcar, PolcarSettingDto>();

            CreateMap<CreatePolcarSettingCommand, Polcar>();
        }
    }
}
