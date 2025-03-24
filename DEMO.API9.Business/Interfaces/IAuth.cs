public interface IAuth
{
    public Task LoginAsync(string username, string password, CancellationToken ct = default);
    
    public Task LogoutAsync(CancellationToken ct = default);
}