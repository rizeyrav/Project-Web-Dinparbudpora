namespace WebDinparbudpora.Application.UseCases.Auth.Login;

public class LoginUseCase
{
    public LoginResponse Execute (LoginRequest request) 
    {
        if (request.Username == "Admin" && request.Password == "123")
        {
            return new LoginResponse
            {
                IsSuccess = true,
                Message = "Selamat Datang Admin"
            };
        }
        return new LoginResponse
        {
            IsSuccess = false,
            Message = "Login Gagal! \n Username atau Password Salah"
        };   
    }
}