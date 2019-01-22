using Microsoft.IdentityModel.Tokens;

using System;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace NitkaWebServer.Helpers.Services
{
    public static class TokenService
    {
        //TODO. Get user data for creating token based on individual data
        public static string GetAminUserToken()
        {
            var mySecretKey = ConfigurationManager.AppSettings["TokenSignatureKey"];
            var handler = new JwtSecurityTokenHandler();
            var claimsIdentity = new ClaimsIdentity(new[]
            {
                    new Claim("isAdmin", "true")
                });
            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(mySecretKey));
            var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

            var securityTokenDescriptor = new SecurityTokenDescriptor()
            {
                Expires = DateTime.Now.AddMinutes(30),
                Subject = claimsIdentity,
                SigningCredentials = signingCredentials
            };

            var now = DateTime.Now;
            var jwtToken = new JwtSecurityToken(
                    expires: now.AddMinutes(30),
                    notBefore: now,
                    claims: claimsIdentity.Claims,
                    signingCredentials: signingCredentials
                );

            var tokenString = handler.WriteToken(jwtToken);

            return tokenString;
        }
        //TODO. Return parameter for Claims and out for validatedToken
        public static bool ValidateToken(string tokenString)
        {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var mySecretKey = ConfigurationManager.AppSettings["TokenSignatureKey"];
                var param = new TokenValidationParameters
                {
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ClockSkew = TimeSpan.FromMinutes(1),
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(mySecretKey)),
                };

                SecurityToken validatedToken;
                var claims = handler.ValidateToken(tokenString, param, out validatedToken);
                var isAdminClaim = claims.Claims.FirstOrDefault(c => c.Type == "isAdmin");
                if (isAdminClaim != null)
                {
                    bool parsedValue;
                    Boolean.TryParse(isAdminClaim.Value, out parsedValue);
                    return parsedValue;
                }

                return false;
            }
            catch(SecurityTokenInvalidSignatureException e)
            {
                //Use some specific message
                return false;
            }
            catch(ArgumentException e)
            {
                //Wrong format
                //Use specific message.
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //var handler = new JwtSecurityTokenHandler();

        ////create symmetrickey
        //var buffer = new byte[64];
        //using (var random = new RNGCryptoServiceProvider())
        //{
        //    random.GetBytes(buffer);
        //}
        //var secretString = Convert.ToBase64String(buffer);

        ////create jwt
        //var token = handler.CreateToken(
        //    issuer: "issuer",
        //    audience: "audience",
        //    expires: DateTime.UtcNow.AddSeconds(10),
        //    subject: new ClaimsIdentity(new[] {
        //        new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
        //        new Claim(ClaimTypes.Name, "User")
        //    }),
        //    signingCredentials: new SigningCredentials(new InMemorySymmetricSecurityKey(buffer), SecurityAlgorithms.HmacSha256Signature, SecurityAlgorithms.Sha512Digest));


        //validate jwt
        //var tokenString = handler.WriteToken(token);
        //SecurityToken validatedToken;
        //var param = new TokenValidationParameters
        //{
        //    ClockSkew = TimeSpan.FromMinutes(1),
        //    ValidIssuer = "issuer",
        //    ValidAudience = "audience",
        //    IssuerSigningKey = new InMemorySymmetricSecurityKey(buffer),
        //};
        //var claims = handler.ValidateToken(tokenString, param, out validatedToken);
    }
}