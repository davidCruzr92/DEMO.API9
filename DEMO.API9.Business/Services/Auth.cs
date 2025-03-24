namespace DEMO.API9.Business.Services;

public class Auth : IAuth
{
    public async Task LoginAsync(string username, string password, CancellationToken ct = default)
    {
        var x = "stirngl";
        
    }

    public Task LogoutAsync(CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
}