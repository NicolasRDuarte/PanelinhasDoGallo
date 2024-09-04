using Microsoft.AspNetCore.Identity;
using PanelinhasDoGallo.Data;
using PanelinhasDoGallo.ViewModels;

namespace PanelinhasDoGallo.Services;

public class UsuarioService : IUsuarioService
{
    private readonly AppDbContext _context;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UsuarioService(
        AppDbContext context, 
        SignInManager<IdentityUser> signInManager, 
        UserManager<IdentityUser> userManager,
        IHttpContextAccessor httpContextAccessor
    )
    {
       _context = context;
       _signInManager = signInManager;
       _userManager = userManager;
       _httpContextAccessor = httpContextAccessor;
    }

    public Task<UsuarioVM> GetUsuarioLogadoVM()
    {
        throw new NotImplementedException();
    }
}
