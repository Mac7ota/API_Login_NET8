using Contexto.Contexto.Repository.Interfaces;
using Service.Autenticacao.Interfaces;

namespace Service.Autenticacao
{
    public class UserService : IUserService
    {
        private readonly IRepository repository;
        public Task<DTOs.Autenticacao.UserLoginResponse> Login(DTOs.Autenticacao.UserLoginRequest userRequest)
        {
            return repository.Login(userRequest);
        }
    }
}
