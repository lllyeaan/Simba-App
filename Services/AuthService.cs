using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Utils;
using System;

namespace MaterialOrderingApp.Services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepository;

        // DIREFRACTOR agar pakai interface
        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public User Login(string username, string password)
        {
            User user = _userRepository.GetUserByUsername(username);

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

        public bool SignUp(string username, string password, string role, Customer customer = null)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Username dan password tidak boleh kosong.");
            }

            if (_userRepository.IsUsernameTaken(username))
            {
                throw new Exception("Username sudah digunakan. Pilih username lain.");
            }

            User newUser = _userRepository.CreateUser(username, password, role, customer);
            return newUser != null;
        }
    }
}