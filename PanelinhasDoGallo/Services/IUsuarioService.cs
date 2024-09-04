using PanelinhasDoGallo.ViewModels;

namespace PanelinhasDoGallo.Services;

public interface IUsuarioService
{
    Task<UsuarioVM> GetUsuarioLogadoVM();
}
