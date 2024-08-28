namespace TriagemCaminhaoApp.Components.Data
{
    public class Triagem
    {
        public int Id { get; set; }
        public Caminhao Caminhao { get; set; }
        public Doca Doca { get; set; }
        public StatusTriagem StatusTriagem { get; set; }
        public PrioridadeTriagem PrioridadeTriagem { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataChegada { get; set; }
        public DateTime? DataAtendimento { get; set; }
    }
}
