using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace ideacode.api.core.Usuario;

public interface IAspNetUser
{
    string Name { get; }
    
    Guid ObterUserId();    
    
    string ObterUserEmail(); 
    
    string ObterUserToken();
    
    string ObterUserRefreshToken();

    string ObterUserAuthorizationToken();
    
    bool EstaAutenticado();
    
    bool PossuiRole(string role);
    
    IEnumerable<Claim> ObterClaims();
    
    HttpContext ObterHttpContext();
}