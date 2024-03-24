using Contexto.Contexto;
using Contexto.Contexto.Repository.Interfaces;

namespace Contexto.Contexto.Repository
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _context;

        public async Task<DTOs.Autenticacao.UserLoginResponse> Login(DTOs.Autenticacao.UserLoginRequest userRequest)
        {
            if (_context.Users.Any(u => u.Email == userRequest.Email && u.Senha == userRequest.Senha))
            {
                var user = _context.Users.Where(u => u.Email == userRequest.Email && u.Senha == userRequest.Senha).FirstOrDefault();

                var userResponse = new DTOs.Autenticacao.UserLoginResponse()
                {
                    Nome = user.Nome,
                    Email = user.Email
                };

                return userResponse;
            }
            else
            {
                throw new Exception("Usuário não encontrado");
            }

        }

        public Repository(AppDbContext context)
        {
            _context = context;
        }

    }
}
