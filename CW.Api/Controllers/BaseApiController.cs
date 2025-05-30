using CW.EntitiesLayer.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CW.Api.Controllers
{
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {
        protected string GenerateJwtToken(UserInfoDataModel pDataModel)
        {
            var key = Encoding.UTF8.GetBytes("UCi9U2H{53(1RePt{Cwc8H9B>5q%rHkS");
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(key);

            JwtSecurityToken jwtToken = new JwtSecurityToken(

                issuer: "JWTIssuer",
                audience: "JWTAudience",
                claims: new List<Claim> {
                 new Claim("Name", pDataModel.Name), //hazır token eşlemesi senin nesne ile
				 new Claim("Surname", pDataModel.Surname), // bu da hazır olmayan ben yazdım nesne de vardı
				 new Claim("Email", pDataModel.Email),
                 new Claim("UserId", pDataModel.UserId.ToString()) // bu da hazır olmayan ben yazdım nesne de vardı
				 //token oluşurken claim oluştur hazır bunlar. imza içindeki veriler
				},

                expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(60)), // token süresi
                notBefore: DateTime.UtcNow, // den önce olmasın
                signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
                //ne ile şifreleyeceksin bunu belirtiyor burada
                );

            var jwtTokenText = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            return jwtTokenText;

        }

        protected UserInfoDataModel GetCurrentUserInfo(HttpContext pContext)
        {
            UserInfoDataModel model = new UserInfoDataModel();

            var jwtToken = pContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            SecurityToken securityToken = new JwtSecurityTokenHandler().ReadToken(jwtToken);

            if (securityToken != null)
            {
                JwtSecurityToken jwt = securityToken as JwtSecurityToken;
                if (jwt != null)
                {
                    model.Name = jwt.Payload["Name"].ToString();
                    model.UserId = Convert.ToInt32(jwt.Payload["UserId"]);
                    model.Surname = jwt.Payload["Surname"].ToString();
                    model.Email = jwt.Payload["Email"].ToString();
                }

            }

            return model;
        }

    }
}


