using System.ComponentModel.DataAnnotations;

namespace Prefeituras.Models
{
    public class PrefeituraModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Município é obrigatorio")]
        public string Municipio { get; set; }
        [Required(ErrorMessage = "Nome é obrigatorio")]
        public string NomeRH { get; set; }
        [Required(ErrorMessage = "E-mail é obrigatorio")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido")]
        public string EmailRH { get; set; }
        [Required(ErrorMessage = "Telefone é obrigatorio")]
        [Phone(ErrorMessage = "O celular informado não é válido")]
        public string TelefoneRH { get; set; }

        public PrefeituraModel()
        {
        }

        public PrefeituraModel(int id, string municipio, string nomeRH, string emailRH, string telefoneRH)
        {
            Id = id;
            Municipio = municipio;
            NomeRH = nomeRH;
            EmailRH = emailRH;
            TelefoneRH = telefoneRH;
        }
    }
}
