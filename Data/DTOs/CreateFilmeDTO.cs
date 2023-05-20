﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDTO
{
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do título não pode exceder 50 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatório")]
    [Range(70, 600, ErrorMessage = "O tamanho do filme deve ter entre 70 a 600 minutos")]
    public int Duracao { get; set; }
}
