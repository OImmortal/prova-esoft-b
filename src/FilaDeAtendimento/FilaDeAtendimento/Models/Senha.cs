namespace FilaDeAtendimento.Models
{
    public class Senha
    {
        public string Codigo { get; set; }
        public PreferenciaTipo Tipo { get; set; }
        public DateTime Emissao { get; set; }
        public StatusAtendimento Status { get; set; }
        public DateTime chamada_em { get; set; }
    }
}
