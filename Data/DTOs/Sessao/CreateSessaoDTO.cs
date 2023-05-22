using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs.Sessao
{
    public class CreateSessaoDTO
    {
        public int FilmeId { get; set; }
        public int CinemaId { get; set; }
    }
}
