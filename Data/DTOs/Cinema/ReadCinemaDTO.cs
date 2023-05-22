using FilmesApi.Data.DTOs.Endereco;
using FilmesApi.Data.DTOs.Sessao;

namespace FilmesApi.Data.DTOs.Cinema
{
    public class ReadCinemaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ReadEnderecoDTO Endereco { get; set; }
        public ICollection<ReadSessaoDTO> Sessoes { get; set; }
    }
}
