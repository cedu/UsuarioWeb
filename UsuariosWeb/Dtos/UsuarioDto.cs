namespace UsuariosWeb.Dtos
{
    /// <summary>
    /// DTO para armazenar os dados do usuário
    /// </summary>
    public class UsuarioDto
    {
        public string? UsuarioId { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime DataHoraAcesso { get; set; }
        public string? AccessToken { get; set; }
    }
}
