using AutoMapper;
using CommandAPI.Dtos;
using CommandAPI.Models;

namespace CommandAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source ➤ Target
            CreateMap<Command, CommandReadDto>();

            //Source ➤ Target
            CreateMap<CommandCreateDto, Command>();

           //Source ➤ Target
           CreateMap<CommandUpdateDto, Command>(); 

           //Source ➤ Target
           CreateMap<Command, CommandUpdateDto>();
        }
    }
}