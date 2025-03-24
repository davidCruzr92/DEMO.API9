using System.ComponentModel.DataAnnotations;

namespace DEMO.API9.Models.ViewModels;

public class LoginCredentialViewModel
{
    [Required]
    public string UserName { get; set; }
    
    [Required]
    public string Password { get; set; }
}