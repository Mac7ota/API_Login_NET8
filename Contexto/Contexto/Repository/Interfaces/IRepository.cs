using DTOs.Autenticacao;

namespace Contexto.Contexto.Repository.Interfaces
{
    public interface IRepository
    {
        Task<UserLoginResponse> Login(UserLoginRequest userRequest);
    }
}