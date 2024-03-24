using DTOs.Autenticacao;

namespace Service.Autenticacao.Interfaces
{
    public interface IUserService
    {
        Task<DTOs.Autenticacao.UserLoginResponse> Login(UserLoginRequest userRequest);
    }
}