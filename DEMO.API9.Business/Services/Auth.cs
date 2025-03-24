namespace DEMO.API9.Business.Services;

public class Auth : IAuth
{
    private readonly IAuth _auth;
    
    public Auth(IAuth auth)
    {
            _auth = auth;   
    }

    public Task LoginAsync(string username, string password, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public Task LogoutAsync(CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
}