namespace WebDinparbudpora.Application.UseCases.Auth.Login;

public class LoginResponse //Kontrak respone user : OUTPUT KE USER
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; } = string.Empty;
}