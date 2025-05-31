using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;

namespace MaterialOrderingApp.Services
{
    public class AuthService
    {
        private readonly UserRepository _userRepository;

        public AuthService()
        {
            _userRepository = new UserRepository();
        }

        public User Login(string username, string password)
        {
            var user = _userRepository.GetUserByUsername(username);

            if (user == null)
            {
                throw new Exception("Username tidak ditemukan. Silakan Sign Up dulu.");
            }

            if (user.Password != password) 
            {
                throw new Exception("Password salah. Silakan coba lagi.");
            }

            return user;
        }
    }
}
