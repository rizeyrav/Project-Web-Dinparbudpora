namespace WebDinparbudpora.Domain.Entities;
// Layer yang berinteraksi langsung dengan database
public class User
{
    public Guid id {get; set;}
    public string username {get;set;} = default!;
    public string password {get;set;} = default!;
}