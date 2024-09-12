using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace ideacode.api.core.Usuario;

public class AspNetJwtUser : IAspNetUser
{
    private readonly IHttpContextAccessor _accessor;

    public AspNetJwtUser(IHttpContextAccessor accessor)
    {
        _accessor = accessor;
    }

    public string Name
    {
        get
        {
            if (_accessor.HttpContext.User.Identity is null) return string.Empty;
            
            return _accessor.HttpContext.User.Identity.Name;
        }
    }

    public Guid ObterUserId()
    {
        var claims = ObterClaims();
        if (claims is null) return Guid.Empty;

        var value = claims.FirstOrDefault(c => c.Type == "sub")?.Value;

        if (value == null) return Guid.Empty;

        return Guid.Parse(value);
    }

    public string ObterUserEmail()
    {
        var token = ObterJwtSecurityToken();
        
        var claim = token.Payload.Claims.FirstOrDefault(c => c.Type == "email");
        
        return claim?.Value;
    }

    public string ObterUserToken()
    {
        var token = ObterUserAuthorizationToken();
        var stream = token.Replace("Bearer ", "");
        return stream;
    }

    public string ObterUserRefreshToken()
    {
        var claims = ObterClaims();
        if (claims is null) return string.Empty;

        return claims.FirstOrDefault(c => c.Type == "RefreshToken")?.Value;
    }

    public string ObterUserAuthorizationToken()
    {
        return ObterHttpContext().Request.Headers["Authorization"];
    }

    public bool EstaAutenticado()
    {
        return !string.IsNullOrWhiteSpace(ObterUserAuthorizationToken());
    }

    public bool PossuiRole(string role)
    {
        var claims = ObterClaims();
        if (claims is null) return false;

        return claims.Any(c => string.Equals(c.Type.Trim(), role.Trim(), StringComparison.CurrentCultureIgnoreCase));
    }

    public IEnumerable<Claim> ObterClaims()
    {
        var tokenS = ObterJwtSecurityToken();

        return tokenS?.Payload.Claims.ToArray();
    }

    private JwtSecurityToken ObterJwtSecurityToken()
    {
        var token = ObterUserAuthorizationToken();
        var stream = token.Replace("Bearer ", "");

        var handler = new JwtSecurityTokenHandler();
        var jsonToken = handler.ReadToken(stream);
        var tokenS = jsonToken as JwtSecurityToken;
        return tokenS;
    }

    public HttpContext ObterHttpContext()
    {
        return _accessor.HttpContext;
    }
}