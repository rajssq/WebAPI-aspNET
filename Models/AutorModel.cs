using System.Text.Json.Serialization;

namespace WebAPI.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [JsonIgnore] //Json de criacao n aparece a lista de livros
        public ICollection<LivroModel> Livros { get; set; }
        

    }
}
