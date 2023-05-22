using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs.Endereco;

public class CreateEnderecoDTO
{
    public string Logradouro { get; set; }
    public int Numero { get; set; }
}