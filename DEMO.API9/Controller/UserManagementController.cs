using DEMO.API9.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DEMO.API9.Controller;

[ApiController]
[Route("api/[controller]")]
public class UserManagementController : ControllerBase
{
    private readonly IAuth _auth;

    public UserManagementController(IAuth auth)
    {
        _auth = auth;
    }


    [HttpPost("login")]
    public ActionResult Login(LoginCredentialViewModel loginCredential)
    {
        _auth.LoginAsync(loginCredential.Password,loginCredential.Password);
        return Ok("Login Successful");
    }
}