using AutoMapper;
using FilmesApi.Data.DTOs.Filme;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class FilmeProfile : Profile
{
	public FilmeProfile()
	{
		CreateMap<CreateFilmeDTO, Filme>();
		CreateMap<UpdateFilmeDTO, Filme>();
		CreateMap<Filme, ReadFilmeDTO>()
            .ForMember(filmeDTO => filmeDTO.Sessoes,
                opt => opt.MapFrom(filme => filme.Sessoes));
	}
}
