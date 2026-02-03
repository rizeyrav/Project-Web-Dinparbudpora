namespace WebDinparbudpora.Application.UseCases.Auth.Login;

public class LoginRequest //Berisi kontrak input usecase : Apa yang diminta oleh user :INPUT USER
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}