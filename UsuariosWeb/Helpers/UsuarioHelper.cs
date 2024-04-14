using Blazored.LocalStorage;
using UsuariosWeb.Dtos;

namespace UsuariosWeb.Helpers
{
    /// <summary>
    /// Classe para execução de operações do sistema com Usuários
    /// </summary>
    public class UsuarioHelper
    {
        private readonly ILocalStorageService _storageService;

        public UsuarioHelper(ILocalStorageService storageService)
        {
            _storageService = storageService;
        }

        /// <summary>
        /// Método para gravar os dados do usuário na local Storage
        /// </summary>
        public async Task SignIn(UsuarioDto dto)
        {
            await _storageService.SetItemAsync("user-auth", dto);
        }
    }
}
