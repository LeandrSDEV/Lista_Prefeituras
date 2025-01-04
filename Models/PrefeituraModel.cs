namespace Prefeituras.Models
{
    public class PrefeituraModel
    {
        public int Id { get; set; }
        public string Municipio { get; set; }
        public string NomeRH { get; set; }
        public string EmailRH { get; set; }
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
