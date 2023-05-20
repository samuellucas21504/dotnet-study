﻿using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class FilmeProfile : Profile
{
	public FilmeProfile()
	{
		CreateMap<CreateFilmeDTO, Filme>();
		CreateMap<UpdateFilmeDTO, Filme>();
		CreateMap<Filme, ReadFilmeDTO>();
	}
}
