using WebDinparbudpora.Application.Common.Interfaces;

namespace WebDinparbudpora.Application.UseCases.Auth.Login;

public class LoginUseCase
{
    private readonly IUserRepository _userRepository;

    public LoginUseCase(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    // public LoginResponse Execute (LoginRequest request) 
    // {
    //     if (request.Username == "Admin" && request.Password == "123")
    //     {
    //         return new LoginResponse
    //         {
    //             IsSuccess = true,
    //             Message = "Selamat Datang Admin"
    //         };
    //     }
    //     return new LoginResponse
    //     {
    //         IsSuccess = false,
    //         Message = "Login Gagal! \n Username atau Password Salah"
    //     };   
    // }
}